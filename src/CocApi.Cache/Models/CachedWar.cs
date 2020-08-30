﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using CocApi.Api;
using CocApi.Client;
using CocApi.Model;

namespace CocApi.Cache.Models
{
    public class CachedWar : CachedItem<ClanWar>
    {
        internal static async Task<CachedWar> FromClanWarLeagueWarResponseAsync(string warTag, ClansCacheBase clansCacheBase, ClansApi clansApi)
        {
            try
            {
                ApiResponse<ClanWar> apiResponse = await clansApi.GetClanWarLeagueWarResponseAsync(warTag);

                return new CachedWar(apiResponse, clansCacheBase.ClanWarTimeToLive(apiResponse));
            }
            catch (ApiException e)
            {
                return new CachedWar(warTag, e, clansCacheBase.ClanWarTimeToLive(e));
            }
        }

        public string ClanTag { get; internal set; }

        public string OpponentTag { get; internal set; }

        public DateTime? PreparationStartTime { get; internal set; }

        public DateTime? EndTime { get; internal set; }

        public string? WarTag { get; internal set; }

        public ClanWar.StateEnum? State { get; internal set; }

        public bool IsFinal { get; internal set; }

        public HttpStatusCode? StatusCodeOpponent { get; internal set; }

        public Announcements Announcements { get; internal set; }

        public ClanWar.TypeEnum Type { get; internal set; }

#nullable disable

        private SortedSet<string> _clanTags;

#nullable enable

        public SortedSet<string> ClanTags
        {
            get
            {
                if (_clanTags != null)
                    return _clanTags;

                _clanTags = new SortedSet<string>
                {
                    ClanTag,

                    OpponentTag
                };

                return _clanTags;
            }
        }

#nullable disable

        public CachedWar()
        {

        }

#nullable enable

        public CachedWar(CachedClan cachedClan, CachedClanWar fetched, string? warTag = null)
        {
            if (fetched.Data == null)
                throw new ArgumentException("Data should not be null.");

            UpdateFrom(fetched);

            ClanTag = fetched.Data.Clans.First().Value.Tag;

            OpponentTag = fetched.Data.Clans.Skip(1).First().Value.Tag;

            PreparationStartTime = fetched.Data.PreparationStartTime;

            EndTime = fetched.Data.EndTime;

            State = fetched.Data.State;

            WarTag = warTag;

            RawContent = fetched.RawContent;

            Type = fetched.Data.Type;

            if (cachedClan.Tag == fetched.Data.Clans.First().Value.Tag)
                StatusCode = fetched.StatusCode;
            else
                StatusCodeOpponent = fetched.StatusCode;
        }

        public CachedWar(CachedClanWar cachedClanWar)
        {
            if (cachedClanWar.Data == null)
                throw new ArgumentException("Data should not be null");

            UpdateFrom(cachedClanWar);

            ClanTag = cachedClanWar.Data.Clans.First().Value.Tag;

            OpponentTag = cachedClanWar.Data.Clans.Skip(1).First().Value.Tag;
        }

        private CachedWar(ApiResponse<ClanWar> apiResponse, TimeSpan localExpiration)
        {
            ClanTag = apiResponse.Data.Clans.First().Value.Tag;

            OpponentTag = apiResponse.Data.Clans.Skip(1).First().Value.Tag;

            UpdateFrom(apiResponse.Data.Clans.First().Value.Tag, apiResponse, localExpiration);
        }

        private CachedWar(string warTag, ApiException apiException, TimeSpan localExpiration)
        {
            WarTag = warTag;

            UpdateFrom(apiException, localExpiration);
        }

        internal void UpdateFrom(CachedClanWar fetched)
        {
            if (ServerExpiration > fetched.ServerExpiration)
                return;

            RawContent = fetched.RawContent;

            Downloaded = fetched.Downloaded;

            ServerExpiration = fetched.ServerExpiration;

            LocalExpiration = fetched.LocalExpiration;

            if (fetched.Data != null)
            {
                Data = fetched.Data;
                
                State = fetched.Data.State;

                EndTime = fetched.Data.EndTime;

                if (fetched.Data.State == ClanWar.StateEnum.WarEnded)
                    IsFinal = true;
            }
        }

        //todo remove these
        internal void UpdateFrom(string clanTagContext, ApiResponse<ClanWar> apiResponse, TimeSpan localExpiration)
        {
            base.UpdateFrom(apiResponse, localExpiration);

            State = apiResponse.Data.State;

            if (State == ClanWar.StateEnum.WarEnded)
                IsFinal = true;

            if (clanTagContext == apiResponse.Data.Clan.Tag)
                StatusCode = apiResponse.StatusCode;
            else
                StatusCodeOpponent = apiResponse.StatusCode;
        }

        internal void UpdateFrom(string clanTagContext, ApiException apiException, TimeSpan localExpiration)
        {
            if (clanTagContext == Data.Clan.Tag)
                StatusCode = (HttpStatusCode)apiException.ErrorCode;
            else
                StatusCodeOpponent = (HttpStatusCode)apiException.ErrorCode;

            UpdateFrom(apiException, localExpiration);
        }

        internal new void UpdateFrom(ApiException apiException, TimeSpan localExpiration)
        {
            base.UpdateFrom(apiException, localExpiration);
        }

        public bool AllAttacksUsed()
        {
            int totalMembers = Data.TeamSize * 2;

            int totalAttacks = totalMembers;

            if (WarTag == null)
                totalAttacks *= 2;

            int attacks = Data.Clan.Attacks + Data.Opponent.Attacks;

            return totalAttacks == attacks;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(PreparationStartTime);
            hash.Add(ClanTags.First());
            hash.Add(ClanTags.Skip(1).First());
            return hash.ToHashCode();
        }
    }
}
