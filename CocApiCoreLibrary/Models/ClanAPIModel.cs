﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using static CocApiLibrary.Enums;

namespace CocApiLibrary.Models
{
    public partial class ClanAPIModel
    {
        public string Tag { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public LocationModel? Location { get; set; }

        public BadgeUrlModel? BadgeUrls { get; set; }

        public int ClanLevel { get; set; }

        public int ClanPoints { get; set; }

        public int ClanVersusPoints { get; set; }

        public int RequiredTrophies { get; set; }

        private string _warFrequencyString = string.Empty;

        [JsonPropertyName("warFrequency")]
        public string WarFrequencyString
        {
            get { return _warFrequencyString; }

            set {
                _warFrequencyString = value;
                if (Enum.TryParse(_warFrequencyString, out WarFrequency warFrequency))
                {
                    WarFrequencyEnum = warFrequency;
                }
            }
        }

        public int WarWinStreak { get; set; }

        public int WarWins { get; set; }

        public int WarTies { get; set; }

        public int WarLosses { get; set; }

        public bool IsWarLogPublic { get; set; }

        public int Members { get; set; }

        public IEnumerable<MemberListAPIModel>? MemberList { get; set; }





        [JsonIgnore]
        public WarFrequency WarFrequencyEnum { get; set; }






        internal void Process()
        {
            MemberList?.ForEach(memberListAPIModel =>
            {
                memberListAPIModel.ClanTag = Tag;
            });
        }
    }
}
