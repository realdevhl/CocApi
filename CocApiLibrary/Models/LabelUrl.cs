﻿using Newtonsoft.Json;

namespace devhl.CocApi.Models
{
    public class LabelUrl
    {
        [JsonProperty]
        public int Id { get; internal set; }

        [JsonProperty]
        public string Medium { get; private set; } = string.Empty;

        [JsonProperty]
        public string Small { get; private set; } = string.Empty;
        
    }
}
