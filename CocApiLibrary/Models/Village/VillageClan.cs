﻿using devhl.CocApi.Models.Clan;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace devhl.CocApi.Models.Village
{
    public class VillageClan : IClan
    {
        [JsonProperty("Tag")]
        public string ClanTag { get; private set; } = string.Empty;

        [JsonProperty]
        public string Name { get; private set; } = string.Empty;

        [JsonProperty]
        public BadgeUrl? BadgeUrl { get; private set; }

        [JsonProperty]
        public int ClanLevel { get; private set; }

        public void Initialize()
        {
        }
    }
}
