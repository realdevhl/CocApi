﻿using System;
using System.Collections.Generic;
using System.Text;
////System.Text.Json.Serialization
using Newtonsoft.Json;

namespace devhl.CocApi.Models.Clan
{
    public class TopBuilderClan : TopClan, IClanApiModel
    {
        [JsonProperty("clanVersusPoints")]
        public int ClanVersusPoints { get; set; }

    }
}
