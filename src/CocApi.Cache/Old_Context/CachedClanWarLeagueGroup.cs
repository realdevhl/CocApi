﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CocApi.Rest.Apis;
using CocApi.Rest.Client;
using CocApi.Rest.Models;

namespace CocApi.Cache.Models
{
    public class CachedClanWarLeagueGroup : CachedItem<ClanWarLeagueGroup>
    {
        internal static async Task<CachedClanWarLeagueGroup> FromClanWarLeagueGroupResponseAsync(string tag, bool? realtime, TimeToLiveProvider ttl, ClansApi clansApi, CancellationToken? cancellationToken = default)
        {
            try
            {
                ApiResponse<ClanWarLeagueGroup?> apiResponse = await clansApi.FetchClanWarLeagueGroupResponseAsync(tag, realtime, cancellationToken).ConfigureAwait(false);

                return new CachedClanWarLeagueGroup(tag, apiResponse, await ttl.TimeToLiveOrDefaultAsync(apiResponse).ConfigureAwait(false));
            }
            catch (Exception e)
            {
                cancellationToken?.ThrowIfCancellationRequested();

                return new CachedClanWarLeagueGroup(tag, await ttl.TimeToLiveOrDefaultAsync<ClanWarLeagueGroup>(e).ConfigureAwait(false));
            }
        }

        public string Tag { get; internal set; }

        public DateTime? Season { get; internal set; }

        public Rest.Models.GroupState? State { get; internal set; }

        internal CachedClanWarLeagueGroup(string tag)
        {
            Tag = tag;
        }

        private CachedClanWarLeagueGroup(string tag, ApiResponse<ClanWarLeagueGroup?> apiResponse, TimeSpan localExpiration) : this(tag)
        {
            UpdateFrom(apiResponse, localExpiration);

            Season = apiResponse.Content?.Season;

            State = apiResponse.Content?.State;
        }

        private CachedClanWarLeagueGroup(string tag, TimeSpan localExpiration) : this(tag)
        {
            UpdateFrom(localExpiration);
        }

        internal void UpdateFrom(CachedClanWarLeagueGroup fetched)
        {
            if (ServerExpiration > fetched.ServerExpiration)
                return;

            base.UpdateFrom(fetched);

            if (fetched.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Season = fetched.Season;

                State = fetched.State;
            }
        }
    }
}
