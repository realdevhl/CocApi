﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using CocApi.Api;
using CocApi.Cache.Models;
using CocApi.Cache.View;
using CocApi.Client;
using CocApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CocApi.Cache
{
    internal class ClanWarMonitor : ClientBase
    {
        private readonly ClansApi _clansApi;
        private readonly ClansClientBase _clansClient;

        public ClanWarMonitor
            (TokenProvider tokenProvider, ClientConfiguration cacheConfiguration, ClansApi clansApi, ClansClientBase clansClientBase)
            : base(tokenProvider, cacheConfiguration)
        {
            _clansApi = clansApi;
            _clansClient = clansClientBase;
        }

        public async Task RunAsync(CancellationToken cancellationToken)
        {
            try
            {
                if (_isRunning)
                    return;

                _isRunning = true;

                _stopRequestedTokenSource = new CancellationTokenSource();

                _clansClient.OnLog(this, new LogEventArgs(nameof(RunAsync), LogLevel.Information));

                while (_stopRequestedTokenSource.IsCancellationRequested == false && cancellationToken.IsCancellationRequested == false)
                {
                    if (_clansClient.DownloadCurrentWars == false && _clansClient.DownloadCwl == false)
                    {
                        await Task.Delay(ClientConfiguration.DelayBetweenTasks, _stopRequestedTokenSource.Token).ConfigureAwait(false);

                        continue;
                    }

                    using var scope = Services.CreateScope();

                    CacheContext dbContext = scope.ServiceProvider.GetRequiredService<CacheContext>();

                    List<Task> tasks = new List<Task>();

                    var cachedWarLogs = await dbContext.ClanWarWithLogStatus
                        .AsNoTracking()
                        .Where(w =>
                            w.Id > _id &&
                            w.IsWarLogPublic == true &&
                            w.DownloadCurrentWar &&
                            w.ServerExpiration < DateTime.UtcNow.AddSeconds(-3) &&
                            w.LocalExpiration < DateTime.UtcNow)
                        .OrderBy(w => w.Id)
                        .Take(ClientConfiguration.ConcurrentUpdates)
                        .Select(l => new { l.Id, l.Tag })
                        .ToListAsync()
                        .ConfigureAwait(false);

                    for (int i = 0; i < cachedWarLogs.Count; i++)
                    {
                        tasks.Add(MonitorClanWarAsync(cachedWarLogs[i].Tag));
                    }

                    if (cachedWarLogs.Count < ClientConfiguration.ConcurrentUpdates)
                        _id = 0;
                    else
                        _id = cachedWarLogs.Max(c => c.Id);

                    await Task.WhenAll(tasks).ConfigureAwait(false);

                    await Task.Delay(ClientConfiguration.DelayBetweenTasks, _stopRequestedTokenSource.Token).ConfigureAwait(false);
                }

                _isRunning = false;
            }
            catch (Exception e)
            {
                _isRunning = false;

                if (_stopRequestedTokenSource.IsCancellationRequested)
                    return;

                _clansClient.OnLog(this, new ExceptionEventArgs(nameof(RunAsync), e));

                if (cancellationToken.IsCancellationRequested == false)
                    _ = RunAsync(cancellationToken);
            }
        }

        public new async Task StopAsync(CancellationToken cancellationToken)
        {
            _stopRequestedTokenSource.Cancel();

            await base.StopAsync(cancellationToken);

            _clansClient.OnLog(this, new LogEventArgs(nameof(StopAsync), LogLevel.Information));
        }

        private async Task MonitorClanWarAsync(string tag)
        {
            if (_clansClient.UpdatingClanWar.TryAdd(tag, new byte()) == false)
                return;

            try
            {
                using var scope = Services.CreateScope();

                CacheContext dbContext = scope.ServiceProvider.GetRequiredService<CacheContext>();

                CachedClanWar? cachedClanWar = await dbContext.ClanWars
                    .Where(w => w.Tag == tag)
                    .FirstAsync(_stopRequestedTokenSource.Token)
                    .ConfigureAwait(false);

                CachedClanWar fetched = await CachedClanWar
                    .FromCurrentWarResponseAsync(tag, _clansClient, _clansApi, _stopRequestedTokenSource.Token);

                if (fetched.Data != null && CachedClanWar.IsNewWar(cachedClanWar, fetched))
                {
                    await _clansClient.InsertNewWarAsync(new CachedWar(fetched));

                    cachedClanWar.Type = fetched.Data.GetWarType();
                }

                cachedClanWar.UpdateFrom(fetched);

                await dbContext.SaveChangesAsync(_stopRequestedTokenSource.Token);
            }
            finally
            {
                _clansClient.UpdatingClanWar.TryRemove(tag, out _);
            }
        }
    }
}