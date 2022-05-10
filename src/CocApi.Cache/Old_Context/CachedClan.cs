﻿using System;
using CocApi.Rest.Models;
using CocApi.Rest.Client;
using System.Threading.Tasks;
using CocApi.Rest.Apis;
using System.Threading;

namespace CocApi.Cache.Models
{
    public class CachedClan : CachedItem<Clan>
    {
        internal static async Task<CachedClan> FromClanResponseAsync(string tag, TimeToLiveProvider ttl, ClansApi clansApi, CancellationToken? cancellationToken = default)
        {
            try
            {
                ApiResponse<Clan> apiResponse = await clansApi.FetchClanResponseAsync(tag, cancellationToken).ConfigureAwait(false);

                return new CachedClan(tag, apiResponse, await ttl.TimeToLiveOrDefaultAsync(apiResponse).ConfigureAwait(false));
            }
            catch (Exception e)
            {
                cancellationToken?.ThrowIfCancellationRequested();

                return new CachedClan(tag, await ttl.TimeToLiveOrDefaultAsync<Clan>(e).ConfigureAwait(false));
            }
        }

        public string Tag { get; internal set; }

        public bool DownloadMembers { get; internal set; }

        public bool DownloadCurrentWar { get; internal set; }

        public bool DownloadCwl { get; internal set; }

        public bool? IsWarLogPublic { get; internal set; }

        private CachedClan(string tag, ApiResponse<Clan> response, TimeSpan localExpiration) : base(response, localExpiration)
        {
            Tag = tag;

            if (response.Content != null)
                IsWarLogPublic = response.Content.IsWarLogPublic;
        }

        private CachedClan(string tag, TimeSpan localExpiration) : base(localExpiration)
        {
            Tag = tag;
        }

        public CachedClan(string tag)
        {
            Tag = tag;
        }

        public void UpdateFrom(CachedClan fetched)
        {
            if (ServerExpiration > fetched.ServerExpiration)
                return;

            IsWarLogPublic = fetched.IsWarLogPublic;

            base.UpdateFrom(fetched);
        }

    }
}
