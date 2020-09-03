﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CocApi.Api;
using CocApi.Cache;
using CocApi.Client;
using CocApi.Model;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace CocApi.Test
{
    public class ClansCache : ClansClientBase, IHostedService
    {
        private readonly PlayersCache _playersCache;
        private readonly LogService _logService;

        public ClansCache(TokenProvider tokenProvider, ClientConfigurationBase cacheConfiguration, ClansApi clansApi, PlayersCache playersCache, LogService logService) 
            : base(tokenProvider, cacheConfiguration, clansApi, playersCache)
        {
            _playersCache = playersCache;
            _logService = logService;

            ClanUpdated += ClansCache_ClanUpdated;
            ClanWarAdded += ClansCache_ClanWarAdded;
            ClanWarEndingSoon += ClansCache_ClanWarEndingSoon;
            ClanWarEndNotSeen += ClansCache_ClanWarEndNotSeen;
            ClanWarLeagueGroupUpdated += ClansCache_ClanWarLeagueGroupUpdated;
            ClanWarLogUpdated += ClansCache_ClanWarLogUpdated;
            ClanWarStartingSoon += ClansCache_ClanWarStartingSoon;
            ClanWarUpdated += ClansCache_ClanWarUpdated;
            clansApi.QueryResult += QueryResult;
        }

        public override TimeSpan ClanWarTimeToLive(Exception exception)
        {
            return base.ClanWarTimeToLive(exception);
        }

        protected override bool HasUpdated(Clan stored, Clan fetched)
        {
            return base.HasUpdated(stored, fetched);
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _playersCache.AddAsync("#29GPU9CUJ"); //squirrel man
            await _playersCache.RunAsync(cancellationToken);

            await UpdateAsync("#8J82PV0C", downloadMembers: true); //fysb unbuckled
            await UpdateAsync("#22G0JJR8", downloadMembers: true); //fysb
            await AddAsync("#28RUGUYJU"); //devhls lab
            await AddAsync("#2C8V29YJ"); // russian clan
            await RunAsync(cancellationToken);
        }

        private Task ClansCache_ClanWarUpdated(object sender, ClanWarUpdatedEventArgs e)
        {
            _logService.Log(LogLevel.Debug, this.GetType().Name, null, "War updated " + ClanWar.NewAttacks(e.Stored, e.Fetched).Count);

            return Task.CompletedTask;
        }

        private Task ClansCache_ClanWarStartingSoon(object sender, ClanWarEventArgs e)
        {
            _logService.Log(LogLevel.Debug, this.GetType().Name, null, "War starting soon");

            return Task.CompletedTask;
        }

        private Task ClansCache_ClanWarEndNotSeen(object sender, ClanWarEventArgs e)
        {
            _logService.Log(LogLevel.Debug, this.GetType().Name, null, "War war end not seen");

            return Task.CompletedTask;
        }

        private Task ClansCache_ClanWarEndingSoon(object sender, ClanWarEventArgs e)
        {
            _logService.Log(LogLevel.Debug, this.GetType().Name, null, "War ending soon");

            return Task.CompletedTask;
        }

        private Task ClansCache_ClanWarAdded(object sender, ClanWarEventArgs e)
        {
            //await Task.Delay(1);

            _logService.Log(LogLevel.Debug, this.GetType().Name, null, "New war");

            string json = JsonConvert.SerializeObject(e.ClanWar);

            ClanWar clanWar = (ClanWar) JsonConvert.DeserializeObject<ClanWar>(json);

            //Console.WriteLine(clanWar.Attacks.Count);

            //throw new Exception();

            //ClanWarMember clanWarMember = new ClanWarMember(mapPosition: 1, rosterPosition: 2);

            //string json2 = JsonConvert.SerializeObject(clanWarMember);

            //string json3 = JsonConvert.SerializeObject(clanWarMember, Clash.JsonSerializerSettings);

            return Task.CompletedTask;
        }

        private Task ClansCache_ClanWarLeagueGroupUpdated(object sender, ClanWarLeagueGroupUpdatedEventArgs e)
        {
            _logService.Log(LogLevel.Debug, this.GetType().Name, null, "Group updated");

            return Task.CompletedTask;
        }

        private Task ClansCache_ClanWarLogUpdated(object sender, ClanWarLogUpdatedEventArgs e)
        {
            _logService.Log(LogLevel.Debug, this.GetType().Name, null, "War log updated");

            return Task.CompletedTask;
        }

        private Task QueryResult(object sender, QueryResultEventArgs log)
        {
            string seconds = ((int)log.QueryResult.Stopwatch.Elapsed.TotalSeconds).ToString();

            if (log.QueryResult is QueryException exception)
            {
                if (exception.Exception is ApiException apiException)
                    _logService.Log(LogLevel.Debug, sender.GetType().Name, seconds, log.QueryResult.EncodedUrl(), apiException.ErrorContent.ToString());
                else
                    _logService.Log(LogLevel.Debug, sender.GetType().Name, seconds, log.QueryResult.EncodedUrl(), exception.Exception.Message);
            }

            if (log.QueryResult is QuerySuccess)
                _logService.Log(LogLevel.Information, sender.GetType().Name, seconds, log.QueryResult.EncodedUrl());

            return Task.CompletedTask;
        }

        private Task ClansCache_ClanUpdated(object sender, ClanUpdatedEventArgs e)
        {
            var donations = Clan.Donations(e.Stored, e.Fetched);

            if (donations.Count > 0)
                _logService.Log(LogLevel.Debug, this.GetType().Name, null, "Clan updated" + donations.Count + " " + donations.Sum(d => d.Quanity));
            else
                _logService.Log(LogLevel.Debug, this.GetType().Name, null, "Clan updated");

            foreach (ClanMember member in Clan.ClanMembersLeft(e.Stored, e.Fetched))
                Console.WriteLine(member.Name + " left");

            foreach (ClanMember member in Clan.ClanMembersJoined(e.Stored, e.Fetched))
                Console.WriteLine(member.Name + " joined");

            return Task.CompletedTask;
        }
    }
}
