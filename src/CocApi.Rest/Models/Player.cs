// <auto-generated>
/*
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CocApi.Rest.Models
{
    /// <summary>
    /// Player
    /// </summary>
    public partial class Player : IEquatable<Player?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="achievements">achievements</param>
        /// <param name="attackWins">attackWins</param>
        /// <param name="bestTrophies">bestTrophies</param>
        /// <param name="bestVersusTrophies">bestVersusTrophies</param>
        /// <param name="builderHallLevel">builderHallLevel</param>
        /// <param name="clanCapitalContributions">clanCapitalContributions</param>
        /// <param name="defenseWins">defenseWins</param>
        /// <param name="donations">donations</param>
        /// <param name="donationsReceived">donationsReceived</param>
        /// <param name="expLevel">expLevel</param>
        /// <param name="heroes">heroes</param>
        /// <param name="labels">labels</param>
        /// <param name="name">name</param>
        /// <param name="spells">spells</param>
        /// <param name="tag">tag</param>
        /// <param name="townHallLevel">townHallLevel</param>
        /// <param name="troops">troops</param>
        /// <param name="trophies">trophies</param>
        /// <param name="versusBattleWinCount">versusBattleWinCount</param>
        /// <param name="versusBattleWins">versusBattleWins</param>
        /// <param name="versusTrophies">versusTrophies</param>
        /// <param name="warStars">warStars</param>
        /// <param name="clan">clan</param>
        /// <param name="league">league</param>
        /// <param name="legendStatistics">legendStatistics</param>
        /// <param name="playerHouse">playerHouse</param>
        /// <param name="role">role</param>
        /// <param name="townHallWeaponLevel">townHallWeaponLevel</param>
        /// <param name="warPreference">warPreference</param>
        [JsonConstructor]
        internal Player(List<PlayerAchievementProgress> achievements, int attackWins, int bestTrophies, int bestVersusTrophies, int builderHallLevel, int clanCapitalContributions, int defenseWins, int donations, int donationsReceived, int expLevel, List<PlayerItemLevel> heroes, List<Label> labels, string name, List<PlayerItemLevel> spells, string tag, int townHallLevel, List<PlayerItemLevel> troops, int trophies, int versusBattleWinCount, int versusBattleWins, int versusTrophies, int warStars, PlayerClan? clan = default, League? league = default, PlayerLegendStatistics? legendStatistics = default, PlayerHouse? playerHouse = default, Role? role = default, int? townHallWeaponLevel = default, WarPreference? warPreference = default)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (attackWins == null)
                throw new ArgumentNullException("attackWins is a required property for Player and cannot be null.");

            if (defenseWins == null)
                throw new ArgumentNullException("defenseWins is a required property for Player and cannot be null.");

            if (townHallLevel == null)
                throw new ArgumentNullException("townHallLevel is a required property for Player and cannot be null.");

            if (versusBattleWins == null)
                throw new ArgumentNullException("versusBattleWins is a required property for Player and cannot be null.");

            if (troops == null)
                throw new ArgumentNullException("troops is a required property for Player and cannot be null.");

            if (heroes == null)
                throw new ArgumentNullException("heroes is a required property for Player and cannot be null.");

            if (spells == null)
                throw new ArgumentNullException("spells is a required property for Player and cannot be null.");

            if (labels == null)
                throw new ArgumentNullException("labels is a required property for Player and cannot be null.");

            if (tag == null)
                throw new ArgumentNullException("tag is a required property for Player and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for Player and cannot be null.");

            if (expLevel == null)
                throw new ArgumentNullException("expLevel is a required property for Player and cannot be null.");

            if (trophies == null)
                throw new ArgumentNullException("trophies is a required property for Player and cannot be null.");

            if (bestTrophies == null)
                throw new ArgumentNullException("bestTrophies is a required property for Player and cannot be null.");

            if (donations == null)
                throw new ArgumentNullException("donations is a required property for Player and cannot be null.");

            if (donationsReceived == null)
                throw new ArgumentNullException("donationsReceived is a required property for Player and cannot be null.");

            if (builderHallLevel == null)
                throw new ArgumentNullException("builderHallLevel is a required property for Player and cannot be null.");

            if (versusTrophies == null)
                throw new ArgumentNullException("versusTrophies is a required property for Player and cannot be null.");

            if (bestVersusTrophies == null)
                throw new ArgumentNullException("bestVersusTrophies is a required property for Player and cannot be null.");

            if (warStars == null)
                throw new ArgumentNullException("warStars is a required property for Player and cannot be null.");

            if (achievements == null)
                throw new ArgumentNullException("achievements is a required property for Player and cannot be null.");

            if (clanCapitalContributions == null)
                throw new ArgumentNullException("clanCapitalContributions is a required property for Player and cannot be null.");

            if (versusBattleWinCount == null)
                throw new ArgumentNullException("versusBattleWinCount is a required property for Player and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Achievements = achievements;
            AttackWins = attackWins;
            BestTrophies = bestTrophies;
            BestVersusTrophies = bestVersusTrophies;
            BuilderHallLevel = builderHallLevel;
            ClanCapitalContributions = clanCapitalContributions;
            DefenseWins = defenseWins;
            Donations = donations;
            DonationsReceived = donationsReceived;
            ExpLevel = expLevel;
            Heroes = heroes;
            Labels = labels;
            Name = name;
            Spells = spells;
            Tag = tag;
            TownHallLevel = townHallLevel;
            Troops = troops;
            Trophies = trophies;
            VersusBattleWinCount = versusBattleWinCount;
            VersusBattleWins = versusBattleWins;
            VersusTrophies = versusTrophies;
            WarStars = warStars;
            Clan = clan;
            League = league;
            LegendStatistics = legendStatistics;
            PlayerHouse = playerHouse;
            Role = role;
            TownHallWeaponLevel = townHallWeaponLevel;
            WarPreference = warPreference;
        }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [JsonPropertyName("role")]
        public Role? Role { get; }

        /// <summary>
        /// Gets or Sets WarPreference
        /// </summary>
        [JsonPropertyName("warPreference")]
        public WarPreference? WarPreference { get; }

        /// <summary>
        /// Gets or Sets Achievements
        /// </summary>
        [JsonPropertyName("achievements")]
        public List<PlayerAchievementProgress> Achievements { get; }

        /// <summary>
        /// Gets or Sets AttackWins
        /// </summary>
        [JsonPropertyName("attackWins")]
        public int AttackWins { get; }

        /// <summary>
        /// Gets or Sets BestTrophies
        /// </summary>
        [JsonPropertyName("bestTrophies")]
        public int BestTrophies { get; }

        /// <summary>
        /// Gets or Sets BestVersusTrophies
        /// </summary>
        [JsonPropertyName("bestVersusTrophies")]
        public int BestVersusTrophies { get; }

        /// <summary>
        /// Gets or Sets BuilderHallLevel
        /// </summary>
        [JsonPropertyName("builderHallLevel")]
        public int BuilderHallLevel { get; }

        /// <summary>
        /// Gets or Sets ClanCapitalContributions
        /// </summary>
        [JsonPropertyName("clanCapitalContributions")]
        public int ClanCapitalContributions { get; }

        /// <summary>
        /// Gets or Sets DefenseWins
        /// </summary>
        [JsonPropertyName("defenseWins")]
        public int DefenseWins { get; }

        /// <summary>
        /// Gets or Sets Donations
        /// </summary>
        [JsonPropertyName("donations")]
        public int Donations { get; }

        /// <summary>
        /// Gets or Sets DonationsReceived
        /// </summary>
        [JsonPropertyName("donationsReceived")]
        public int DonationsReceived { get; }

        /// <summary>
        /// Gets or Sets ExpLevel
        /// </summary>
        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; }

        /// <summary>
        /// Gets or Sets Heroes
        /// </summary>
        [JsonPropertyName("heroes")]
        public List<PlayerItemLevel> Heroes { get; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [JsonPropertyName("labels")]
        public List<Label> Labels { get; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or Sets Spells
        /// </summary>
        [JsonPropertyName("spells")]
        public List<PlayerItemLevel> Spells { get; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; }

        /// <summary>
        /// Gets or Sets TownHallLevel
        /// </summary>
        [JsonPropertyName("townHallLevel")]
        public int TownHallLevel { get; }

        /// <summary>
        /// Gets or Sets Troops
        /// </summary>
        [JsonPropertyName("troops")]
        public List<PlayerItemLevel> Troops { get; }

        /// <summary>
        /// Gets or Sets Trophies
        /// </summary>
        [JsonPropertyName("trophies")]
        public int Trophies { get; }

        /// <summary>
        /// Gets or Sets VersusBattleWinCount
        /// </summary>
        [JsonPropertyName("versusBattleWinCount")]
        public int VersusBattleWinCount { get; }

        /// <summary>
        /// Gets or Sets VersusBattleWins
        /// </summary>
        [JsonPropertyName("versusBattleWins")]
        public int VersusBattleWins { get; }

        /// <summary>
        /// Gets or Sets VersusTrophies
        /// </summary>
        [JsonPropertyName("versusTrophies")]
        public int VersusTrophies { get; }

        /// <summary>
        /// Gets or Sets WarStars
        /// </summary>
        [JsonPropertyName("warStars")]
        public int WarStars { get; }

        /// <summary>
        /// Gets or Sets Clan
        /// </summary>
        [JsonPropertyName("clan")]
        public PlayerClan? Clan { get; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [JsonPropertyName("league")]
        public League? League { get; }

        /// <summary>
        /// Gets or Sets LegendStatistics
        /// </summary>
        [JsonPropertyName("legendStatistics")]
        public PlayerLegendStatistics? LegendStatistics { get; }

        /// <summary>
        /// Gets or Sets PlayerHouse
        /// </summary>
        [JsonPropertyName("playerHouse")]
        public PlayerHouse? PlayerHouse { get; }

        /// <summary>
        /// Gets or Sets TownHallWeaponLevel
        /// </summary>
        [JsonPropertyName("townHallWeaponLevel")]
        public int? TownHallWeaponLevel { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Player {\n");
            sb.Append("  Achievements: ").Append(Achievements).Append("\n");
            sb.Append("  AttackWins: ").Append(AttackWins).Append("\n");
            sb.Append("  BestTrophies: ").Append(BestTrophies).Append("\n");
            sb.Append("  BestVersusTrophies: ").Append(BestVersusTrophies).Append("\n");
            sb.Append("  BuilderHallLevel: ").Append(BuilderHallLevel).Append("\n");
            sb.Append("  ClanCapitalContributions: ").Append(ClanCapitalContributions).Append("\n");
            sb.Append("  DefenseWins: ").Append(DefenseWins).Append("\n");
            sb.Append("  Donations: ").Append(Donations).Append("\n");
            sb.Append("  DonationsReceived: ").Append(DonationsReceived).Append("\n");
            sb.Append("  ExpLevel: ").Append(ExpLevel).Append("\n");
            sb.Append("  Heroes: ").Append(Heroes).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Spells: ").Append(Spells).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  TownHallLevel: ").Append(TownHallLevel).Append("\n");
            sb.Append("  Troops: ").Append(Troops).Append("\n");
            sb.Append("  Trophies: ").Append(Trophies).Append("\n");
            sb.Append("  VersusBattleWinCount: ").Append(VersusBattleWinCount).Append("\n");
            sb.Append("  VersusBattleWins: ").Append(VersusBattleWins).Append("\n");
            sb.Append("  VersusTrophies: ").Append(VersusTrophies).Append("\n");
            sb.Append("  WarStars: ").Append(WarStars).Append("\n");
            sb.Append("  Clan: ").Append(Clan).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  LegendStatistics: ").Append(LegendStatistics).Append("\n");
            sb.Append("  PlayerHouse: ").Append(PlayerHouse).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  TownHallWeaponLevel: ").Append(TownHallWeaponLevel).Append("\n");
            sb.Append("  WarPreference: ").Append(WarPreference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return this.Equals(input as Player);
        }

        /// <summary>
        /// Returns true if Player instances are equal
        /// </summary>
        /// <param name="input">Instance of Player to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Player? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Achievements == input.Achievements ||
                    Achievements != null &&
                    input.Achievements != null &&
                    Achievements.SequenceEqual(input.Achievements)
                ) && 
                (
                    AttackWins == input.AttackWins ||
                    (AttackWins != null &&
                    AttackWins.Equals(input.AttackWins))
                ) && 
                (
                    BestTrophies == input.BestTrophies ||
                    (BestTrophies != null &&
                    BestTrophies.Equals(input.BestTrophies))
                ) && 
                (
                    BestVersusTrophies == input.BestVersusTrophies ||
                    (BestVersusTrophies != null &&
                    BestVersusTrophies.Equals(input.BestVersusTrophies))
                ) && 
                (
                    BuilderHallLevel == input.BuilderHallLevel ||
                    (BuilderHallLevel != null &&
                    BuilderHallLevel.Equals(input.BuilderHallLevel))
                ) && 
                (
                    ClanCapitalContributions == input.ClanCapitalContributions ||
                    (ClanCapitalContributions != null &&
                    ClanCapitalContributions.Equals(input.ClanCapitalContributions))
                ) && 
                (
                    DefenseWins == input.DefenseWins ||
                    (DefenseWins != null &&
                    DefenseWins.Equals(input.DefenseWins))
                ) && 
                (
                    Donations == input.Donations ||
                    (Donations != null &&
                    Donations.Equals(input.Donations))
                ) && 
                (
                    DonationsReceived == input.DonationsReceived ||
                    (DonationsReceived != null &&
                    DonationsReceived.Equals(input.DonationsReceived))
                ) && 
                (
                    ExpLevel == input.ExpLevel ||
                    (ExpLevel != null &&
                    ExpLevel.Equals(input.ExpLevel))
                ) && 
                (
                    Heroes == input.Heroes ||
                    Heroes != null &&
                    input.Heroes != null &&
                    Heroes.SequenceEqual(input.Heroes)
                ) && 
                (
                    Labels == input.Labels ||
                    Labels != null &&
                    input.Labels != null &&
                    Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Spells == input.Spells ||
                    Spells != null &&
                    input.Spells != null &&
                    Spells.SequenceEqual(input.Spells)
                ) && 
                (
                    Tag == input.Tag ||
                    (Tag != null &&
                    Tag.Equals(input.Tag))
                ) && 
                (
                    TownHallLevel == input.TownHallLevel ||
                    (TownHallLevel != null &&
                    TownHallLevel.Equals(input.TownHallLevel))
                ) && 
                (
                    Troops == input.Troops ||
                    Troops != null &&
                    input.Troops != null &&
                    Troops.SequenceEqual(input.Troops)
                ) && 
                (
                    Trophies == input.Trophies ||
                    (Trophies != null &&
                    Trophies.Equals(input.Trophies))
                ) && 
                (
                    VersusBattleWinCount == input.VersusBattleWinCount ||
                    (VersusBattleWinCount != null &&
                    VersusBattleWinCount.Equals(input.VersusBattleWinCount))
                ) && 
                (
                    VersusBattleWins == input.VersusBattleWins ||
                    (VersusBattleWins != null &&
                    VersusBattleWins.Equals(input.VersusBattleWins))
                ) && 
                (
                    VersusTrophies == input.VersusTrophies ||
                    (VersusTrophies != null &&
                    VersusTrophies.Equals(input.VersusTrophies))
                ) && 
                (
                    WarStars == input.WarStars ||
                    (WarStars != null &&
                    WarStars.Equals(input.WarStars))
                ) && 
                (
                    Clan == input.Clan ||
                    (Clan != null &&
                    Clan.Equals(input.Clan))
                ) && 
                (
                    League == input.League ||
                    (League != null &&
                    League.Equals(input.League))
                ) && 
                (
                    LegendStatistics == input.LegendStatistics ||
                    (LegendStatistics != null &&
                    LegendStatistics.Equals(input.LegendStatistics))
                ) && 
                (
                    PlayerHouse == input.PlayerHouse ||
                    (PlayerHouse != null &&
                    PlayerHouse.Equals(input.PlayerHouse))
                ) && 
                (
                    Role == input.Role ||
                    (Role != null &&
                    Role.Equals(input.Role))
                ) && 
                (
                    TownHallWeaponLevel == input.TownHallWeaponLevel ||
                    (TownHallWeaponLevel != null &&
                    TownHallWeaponLevel.Equals(input.TownHallWeaponLevel))
                ) && 
                (
                    WarPreference == input.WarPreference ||
                    (WarPreference != null &&
                    WarPreference.Equals(input.WarPreference))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + Achievements.GetHashCode();
                hashCode = (hashCode * 59) + AttackWins.GetHashCode();
                hashCode = (hashCode * 59) + BestTrophies.GetHashCode();
                hashCode = (hashCode * 59) + BestVersusTrophies.GetHashCode();
                hashCode = (hashCode * 59) + BuilderHallLevel.GetHashCode();
                hashCode = (hashCode * 59) + ClanCapitalContributions.GetHashCode();
                hashCode = (hashCode * 59) + DefenseWins.GetHashCode();
                hashCode = (hashCode * 59) + Donations.GetHashCode();
                hashCode = (hashCode * 59) + DonationsReceived.GetHashCode();
                hashCode = (hashCode * 59) + ExpLevel.GetHashCode();
                hashCode = (hashCode * 59) + Heroes.GetHashCode();
                hashCode = (hashCode * 59) + Labels.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + Spells.GetHashCode();
                hashCode = (hashCode * 59) + Tag.GetHashCode();
                hashCode = (hashCode * 59) + TownHallLevel.GetHashCode();
                hashCode = (hashCode * 59) + Troops.GetHashCode();
                hashCode = (hashCode * 59) + Trophies.GetHashCode();
                hashCode = (hashCode * 59) + VersusBattleWinCount.GetHashCode();
                hashCode = (hashCode * 59) + VersusBattleWins.GetHashCode();
                hashCode = (hashCode * 59) + VersusTrophies.GetHashCode();
                hashCode = (hashCode * 59) + WarStars.GetHashCode();

                if (Clan != null)
                    hashCode = (hashCode * 59) + Clan.GetHashCode();

                if (League != null)
                    hashCode = (hashCode * 59) + League.GetHashCode();

                if (LegendStatistics != null)
                    hashCode = (hashCode * 59) + LegendStatistics.GetHashCode();

                if (PlayerHouse != null)
                    hashCode = (hashCode * 59) + PlayerHouse.GetHashCode();

                if (Role != null)
                    hashCode = (hashCode * 59) + Role.GetHashCode();

                if (TownHallWeaponLevel != null)
                    hashCode = (hashCode * 59) + TownHallWeaponLevel.GetHashCode();

                if (WarPreference != null)
                    hashCode = (hashCode * 59) + WarPreference.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type Player
    /// </summary>
    public class PlayerJsonConverter : JsonConverter<Player>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Player Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            List<PlayerAchievementProgress> achievements = default;
            int attackWins = default;
            int bestTrophies = default;
            int bestVersusTrophies = default;
            int builderHallLevel = default;
            int clanCapitalContributions = default;
            int defenseWins = default;
            int donations = default;
            int donationsReceived = default;
            int expLevel = default;
            List<PlayerItemLevel> heroes = default;
            List<Label> labels = default;
            string name = default;
            List<PlayerItemLevel> spells = default;
            string tag = default;
            int townHallLevel = default;
            List<PlayerItemLevel> troops = default;
            int trophies = default;
            int versusBattleWinCount = default;
            int versusBattleWins = default;
            int versusTrophies = default;
            int warStars = default;
            PlayerClan clan = default;
            League league = default;
            PlayerLegendStatistics legendStatistics = default;
            PlayerHouse playerHouse = default;
            Role? role = default;
            int? townHallWeaponLevel = default;
            WarPreference? warPreference = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "achievements":
                            achievements = JsonSerializer.Deserialize<List<PlayerAchievementProgress>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "attackWins":
                            attackWins = utf8JsonReader.GetInt32();
                            break;
                        case "bestTrophies":
                            bestTrophies = utf8JsonReader.GetInt32();
                            break;
                        case "bestVersusTrophies":
                            bestVersusTrophies = utf8JsonReader.GetInt32();
                            break;
                        case "builderHallLevel":
                            builderHallLevel = utf8JsonReader.GetInt32();
                            break;
                        case "clanCapitalContributions":
                            clanCapitalContributions = utf8JsonReader.GetInt32();
                            break;
                        case "defenseWins":
                            defenseWins = utf8JsonReader.GetInt32();
                            break;
                        case "donations":
                            donations = utf8JsonReader.GetInt32();
                            break;
                        case "donationsReceived":
                            donationsReceived = utf8JsonReader.GetInt32();
                            break;
                        case "expLevel":
                            expLevel = utf8JsonReader.GetInt32();
                            break;
                        case "heroes":
                            heroes = JsonSerializer.Deserialize<List<PlayerItemLevel>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "labels":
                            labels = JsonSerializer.Deserialize<List<Label>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "spells":
                            spells = JsonSerializer.Deserialize<List<PlayerItemLevel>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "tag":
                            tag = utf8JsonReader.GetString();
                            break;
                        case "townHallLevel":
                            townHallLevel = utf8JsonReader.GetInt32();
                            break;
                        case "troops":
                            troops = JsonSerializer.Deserialize<List<PlayerItemLevel>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "trophies":
                            trophies = utf8JsonReader.GetInt32();
                            break;
                        case "versusBattleWinCount":
                            versusBattleWinCount = utf8JsonReader.GetInt32();
                            break;
                        case "versusBattleWins":
                            versusBattleWins = utf8JsonReader.GetInt32();
                            break;
                        case "versusTrophies":
                            versusTrophies = utf8JsonReader.GetInt32();
                            break;
                        case "warStars":
                            warStars = utf8JsonReader.GetInt32();
                            break;
                        case "clan":
                            clan = JsonSerializer.Deserialize<PlayerClan>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "league":
                            league = JsonSerializer.Deserialize<League>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "legendStatistics":
                            legendStatistics = JsonSerializer.Deserialize<PlayerLegendStatistics>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "playerHouse":
                            playerHouse = JsonSerializer.Deserialize<PlayerHouse>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "role":
                            string roleRawValue = utf8JsonReader.GetString();
                            role = RoleConverter.FromStringOrDefault(roleRawValue);
                            break;
                        case "townHallWeaponLevel":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                townHallWeaponLevel = utf8JsonReader.GetInt32();
                            break;
                        case "warPreference":
                            string warPreferenceRawValue = utf8JsonReader.GetString();
                            warPreference = WarPreferenceConverter.FromStringOrDefault(warPreferenceRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new Player(achievements, attackWins, bestTrophies, bestVersusTrophies, builderHallLevel, clanCapitalContributions, defenseWins, donations, donationsReceived, expLevel, heroes, labels, name, spells, tag, townHallLevel, troops, trophies, versusBattleWinCount, versusBattleWins, versusTrophies, warStars, clan, league, legendStatistics, playerHouse, role, townHallWeaponLevel, warPreference);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="player"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Player player, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("achievements");
            JsonSerializer.Serialize(writer, player.Achievements, jsonSerializerOptions);
            writer.WriteNumber("attackWins", player.AttackWins);
            writer.WriteNumber("bestTrophies", player.BestTrophies);
            writer.WriteNumber("bestVersusTrophies", player.BestVersusTrophies);
            writer.WriteNumber("builderHallLevel", player.BuilderHallLevel);
            writer.WriteNumber("clanCapitalContributions", player.ClanCapitalContributions);
            writer.WriteNumber("defenseWins", player.DefenseWins);
            writer.WriteNumber("donations", player.Donations);
            writer.WriteNumber("donationsReceived", player.DonationsReceived);
            writer.WriteNumber("expLevel", player.ExpLevel);
            writer.WritePropertyName("heroes");
            JsonSerializer.Serialize(writer, player.Heroes, jsonSerializerOptions);
            writer.WritePropertyName("labels");
            JsonSerializer.Serialize(writer, player.Labels, jsonSerializerOptions);
            writer.WriteString("name", player.Name);
            writer.WritePropertyName("spells");
            JsonSerializer.Serialize(writer, player.Spells, jsonSerializerOptions);
            writer.WriteString("tag", player.Tag);
            writer.WriteNumber("townHallLevel", player.TownHallLevel);
            writer.WritePropertyName("troops");
            JsonSerializer.Serialize(writer, player.Troops, jsonSerializerOptions);
            writer.WriteNumber("trophies", player.Trophies);
            writer.WriteNumber("versusBattleWinCount", player.VersusBattleWinCount);
            writer.WriteNumber("versusBattleWins", player.VersusBattleWins);
            writer.WriteNumber("versusTrophies", player.VersusTrophies);
            writer.WriteNumber("warStars", player.WarStars);
            writer.WritePropertyName("clan");
            JsonSerializer.Serialize(writer, player.Clan, jsonSerializerOptions);
            writer.WritePropertyName("league");
            JsonSerializer.Serialize(writer, player.League, jsonSerializerOptions);
            writer.WritePropertyName("legendStatistics");
            JsonSerializer.Serialize(writer, player.LegendStatistics, jsonSerializerOptions);
            writer.WritePropertyName("playerHouse");
            JsonSerializer.Serialize(writer, player.PlayerHouse, jsonSerializerOptions);
            if (player.Role == null)
                writer.WriteNull("role");
            var roleRawValue = RoleConverter.ToJsonValue(player.Role.Value);
            if (roleRawValue != null)
                writer.WriteString("role", roleRawValue);
            else
                writer.WriteNull("role");
            if (player.TownHallWeaponLevel != null)
                writer.WriteNumber("townHallWeaponLevel", player.TownHallWeaponLevel.Value);
            else
                writer.WriteNull("townHallWeaponLevel");
            if (player.WarPreference == null)
                writer.WriteNull("warPreference");
            var warPreferenceRawValue = WarPreferenceConverter.ToJsonValue(player.WarPreference.Value);
            if (warPreferenceRawValue != null)
                writer.WriteString("warPreference", warPreferenceRawValue);
            else
                writer.WriteNull("warPreference");

            writer.WriteEndObject();
        }
    }
}
