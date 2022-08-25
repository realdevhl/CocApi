﻿// <auto-generated>
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
    /// PlayerRanking
    /// </summary>
    public partial class PlayerRanking : IEquatable<PlayerRanking?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRanking" /> class.
        /// </summary>
        /// <param name="attackWins">attackWins</param>
        /// <param name="defenseWins">defenseWins</param>
        /// <param name="expLevel">expLevel</param>
        /// <param name="league">league</param>
        /// <param name="name">name</param>
        /// <param name="previousRank">previousRank</param>
        /// <param name="rank">rank</param>
        /// <param name="tag">tag</param>
        /// <param name="trophies">trophies</param>
        /// <param name="clan">clan</param>
        [JsonConstructor]
        internal PlayerRanking(int attackWins, int defenseWins, int expLevel, League league, string name, int previousRank, int rank, string tag, int trophies, PlayerRankingClan? clan = default)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (league == null)
                throw new ArgumentNullException("league is a required property for PlayerRanking and cannot be null.");

            if (attackWins == null)
                throw new ArgumentNullException("attackWins is a required property for PlayerRanking and cannot be null.");

            if (defenseWins == null)
                throw new ArgumentNullException("defenseWins is a required property for PlayerRanking and cannot be null.");

            if (tag == null)
                throw new ArgumentNullException("tag is a required property for PlayerRanking and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for PlayerRanking and cannot be null.");

            if (expLevel == null)
                throw new ArgumentNullException("expLevel is a required property for PlayerRanking and cannot be null.");

            if (rank == null)
                throw new ArgumentNullException("rank is a required property for PlayerRanking and cannot be null.");

            if (previousRank == null)
                throw new ArgumentNullException("previousRank is a required property for PlayerRanking and cannot be null.");

            if (trophies == null)
                throw new ArgumentNullException("trophies is a required property for PlayerRanking and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            AttackWins = attackWins;
            DefenseWins = defenseWins;
            ExpLevel = expLevel;
            League = league;
            Name = name;
            PreviousRank = previousRank;
            Rank = rank;
            Tag = tag;
            Trophies = trophies;
            Clan = clan;
        }

        /// <summary>
        /// Gets or Sets AttackWins
        /// </summary>
        [JsonPropertyName("attackWins")]
        public int AttackWins { get; }

        /// <summary>
        /// Gets or Sets DefenseWins
        /// </summary>
        [JsonPropertyName("defenseWins")]
        public int DefenseWins { get; }

        /// <summary>
        /// Gets or Sets ExpLevel
        /// </summary>
        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [JsonPropertyName("league")]
        public League League { get; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or Sets PreviousRank
        /// </summary>
        [JsonPropertyName("previousRank")]
        public int PreviousRank { get; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [JsonPropertyName("rank")]
        public int Rank { get; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; }

        /// <summary>
        /// Gets or Sets Trophies
        /// </summary>
        [JsonPropertyName("trophies")]
        public int Trophies { get; }

        /// <summary>
        /// Gets or Sets Clan
        /// </summary>
        [JsonPropertyName("clan")]
        public PlayerRankingClan? Clan { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerRanking {\n");
            sb.Append("  AttackWins: ").Append(AttackWins).Append("\n");
            sb.Append("  DefenseWins: ").Append(DefenseWins).Append("\n");
            sb.Append("  ExpLevel: ").Append(ExpLevel).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PreviousRank: ").Append(PreviousRank).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Trophies: ").Append(Trophies).Append("\n");
            sb.Append("  Clan: ").Append(Clan).Append("\n");
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
            return this.Equals(input as PlayerRanking);
        }

        /// <summary>
        /// Returns true if PlayerRanking instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerRanking? input)
        {
            if (input == null)
                return false;

            return 
                (
                    AttackWins == input.AttackWins ||
                    (AttackWins != null &&
                    AttackWins.Equals(input.AttackWins))
                ) && 
                (
                    DefenseWins == input.DefenseWins ||
                    (DefenseWins != null &&
                    DefenseWins.Equals(input.DefenseWins))
                ) && 
                (
                    ExpLevel == input.ExpLevel ||
                    (ExpLevel != null &&
                    ExpLevel.Equals(input.ExpLevel))
                ) && 
                (
                    League == input.League ||
                    (League != null &&
                    League.Equals(input.League))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    PreviousRank == input.PreviousRank ||
                    (PreviousRank != null &&
                    PreviousRank.Equals(input.PreviousRank))
                ) && 
                (
                    Rank == input.Rank ||
                    (Rank != null &&
                    Rank.Equals(input.Rank))
                ) && 
                (
                    Tag == input.Tag ||
                    (Tag != null &&
                    Tag.Equals(input.Tag))
                ) && 
                (
                    Trophies == input.Trophies ||
                    (Trophies != null &&
                    Trophies.Equals(input.Trophies))
                ) && 
                (
                    Clan == input.Clan ||
                    (Clan != null &&
                    Clan.Equals(input.Clan))
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
                hashCode = (hashCode * 59) + AttackWins.GetHashCode();
                hashCode = (hashCode * 59) + DefenseWins.GetHashCode();
                hashCode = (hashCode * 59) + ExpLevel.GetHashCode();
                hashCode = (hashCode * 59) + League.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + PreviousRank.GetHashCode();
                hashCode = (hashCode * 59) + Rank.GetHashCode();
                hashCode = (hashCode * 59) + Tag.GetHashCode();
                hashCode = (hashCode * 59) + Trophies.GetHashCode();

                if (Clan != null)
                    hashCode = (hashCode * 59) + Clan.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type PlayerRanking
    /// </summary>
    public class PlayerRankingJsonConverter : JsonConverter<PlayerRanking>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerRanking Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            int attackWins = default;
            int defenseWins = default;
            int expLevel = default;
            League league = default;
            string name = default;
            int previousRank = default;
            int rank = default;
            string tag = default;
            int trophies = default;
            PlayerRankingClan clan = default;

            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName && currentDepth == reader.CurrentDepth - 1)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "attackWins":
                            attackWins = reader.GetInt32();
                            break;
                        case "defenseWins":
                            defenseWins = reader.GetInt32();
                            break;
                        case "expLevel":
                            expLevel = reader.GetInt32();
                            break;
                        case "league":
                            league = JsonSerializer.Deserialize<League>(ref reader, options);
                            break;
                        case "name":
                            name = reader.GetString();
                            break;
                        case "previousRank":
                            previousRank = reader.GetInt32();
                            break;
                        case "rank":
                            rank = reader.GetInt32();
                            break;
                        case "tag":
                            tag = reader.GetString();
                            break;
                        case "trophies":
                            trophies = reader.GetInt32();
                            break;
                        case "clan":
                            clan = JsonSerializer.Deserialize<PlayerRankingClan>(ref reader, options);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new PlayerRanking(attackWins, defenseWins, expLevel, league, name, previousRank, rank, tag, trophies, clan);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerRanking"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerRanking playerRanking, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteNumber("attackWins", (int)playerRanking.AttackWins);
            writer.WriteNumber("defenseWins", (int)playerRanking.DefenseWins);
            writer.WriteNumber("expLevel", (int)playerRanking.ExpLevel);
            writer.WritePropertyName("league");
            JsonSerializer.Serialize(writer, playerRanking.League, options);
            writer.WriteString("name", playerRanking.Name);
            writer.WriteNumber("previousRank", (int)playerRanking.PreviousRank);
            writer.WriteNumber("rank", (int)playerRanking.Rank);
            writer.WriteString("tag", playerRanking.Tag);
            writer.WriteNumber("trophies", (int)playerRanking.Trophies);
            writer.WritePropertyName("clan");
            JsonSerializer.Serialize(writer, playerRanking.Clan, options);

            writer.WriteEndObject();
        }
    }
}
