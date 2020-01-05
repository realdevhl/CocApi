﻿using Newtonsoft.Json;

namespace devhl.CocApi.Models.Village
{
    public class League : IInitialize
    {
        [JsonProperty]
        public int Id { get; internal set; }

        [JsonProperty]
        public string Name { get; internal set; } = string.Empty;

        [JsonProperty("iconUrls")]
        public LeagueIcon? LeagueIcon { get; internal set; }

        public void Initialize()
        {
            if (LeagueIcon != null) LeagueIcon.LeaugeId = Id;
        }
    }
}
