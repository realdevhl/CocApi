﻿using System.Text.Json.Serialization;

namespace CocApiStandardLibrary.Models
{
    public class LeagueAPIModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IconUrlsModel? IconUrls { get; set; }

    }
}
