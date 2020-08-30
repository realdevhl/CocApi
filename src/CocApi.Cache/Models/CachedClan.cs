﻿using System;
using CocApi.Model;
using CocApi.Client;
using System.Threading.Tasks;
using CocApi.Api;

namespace CocApi.Cache.Models
{
    public class CachedClan : CachedItem<Clan>
    {
        internal static async Task<CachedClan> FromClanResponseAsync(string tag, ClansCacheBase clansCacheBase, ClansApi clansApi)
        {
            try
            {
                ApiResponse<Clan> apiResponse = await clansApi.GetClanResponseAsync(tag).ConfigureAwait(false);

                return new CachedClan(apiResponse, clansCacheBase.ClanTimeToLive(apiResponse));
            }
            catch (ApiException apiException)
            {
                return new CachedClan(tag, apiException, clansCacheBase.ClanTimeToLive(apiException));
            }
        }

        public string Tag { get; internal set; }

        public bool Download { get; internal set; }

        public bool DownloadMembers { get; internal set; }

        public bool DownloadCurrentWar { get; internal set; }

        public bool DownloadCwl { get; internal set; }

        private CachedClan(ApiResponse<Clan> response, TimeSpan localExpiration) : base (response, localExpiration)
        {
            Tag = response.Data.Tag;
        }

        private CachedClan(string tag, ApiException apiException, TimeSpan localExpiration) : base(apiException, localExpiration)
        {
            Tag = tag;
        }

        internal CachedClan(string tag)
        {
            Tag = tag;
        }

        internal void UpdateFrom(CachedClan fetched)
        {
            if (ServerExpiration > fetched.ServerExpiration)
                return;

            base.UpdateFrom(fetched);
        }
    }
}
