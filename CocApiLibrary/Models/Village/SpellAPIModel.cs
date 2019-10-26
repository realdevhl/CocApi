﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static CocApiLibrary.Enums;

namespace CocApiLibrary.Models
{
    public class SpellAPIModel
    {
        [ForeignKey(nameof(VillageTag))]
        public string VillageTag { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public int Level { get; set; }

        public int MaxLevel { get; set; }

        public VillageType Village { get; set; }
    }
}
