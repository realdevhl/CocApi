﻿using CocApiLibrary.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static CocApiLibrary.Enums;

namespace CocApiLibrary.Models
{
    public class ClanAPIModel : IClanAPIModel
    {
        public string Tag { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public BadgeUrlModel? BadgeUrls { get; set; }

        public int ClanLevel { get; set; }

        [JsonPropertyName("memberList")]
        public IEnumerable<MemberListAPIModel>? Members { get; set; }




        public string Type { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public LocationModel? Location { get; set; }



        public int ClanPoints { get; set; }

        public int ClanVersusPoints { get; set; }

        public int RequiredTrophies { get; set; }

        public int WarWinStreak { get; set; }

        public int WarWins { get; set; }

        public int WarTies { get; set; }

        public int WarLosses { get; set; }

        public bool IsWarLogPublic { get; set; }

        [JsonPropertyName("members")]
        public int MemberCount { get; set; }

        public WarFrequency WarFrequency { get; set; }



        [JsonIgnore]
        public ConcurrentDictionary<string, CurrentWarAPIModel> Wars { get; set; } = new ConcurrentDictionary<string, CurrentWarAPIModel>();
    }
}
