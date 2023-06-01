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
    /// PlayerBuilderBaseRanking
    /// </summary>
    public partial class PlayerBuilderBaseRanking : IEquatable<PlayerBuilderBaseRanking?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerBuilderBaseRanking" /> class.
        /// </summary>
        /// <param name="builderBaseLeague">builderBaseLeague</param>
        /// <param name="builderBaseTrophies">builderBaseTrophies</param>
        /// <param name="expLevel">expLevel</param>
        /// <param name="name">name</param>
        /// <param name="previousRank">previousRank</param>
        /// <param name="rank">rank</param>
        /// <param name="tag">tag</param>
        /// <param name="clan">clan</param>
        [JsonConstructor]
        internal PlayerBuilderBaseRanking(BuilderBaseLeague builderBaseLeague, int builderBaseTrophies, int expLevel, string name, int previousRank, int rank, string tag, PlayerRankingClan? clan = default)
        {
            BuilderBaseLeague = builderBaseLeague;
            BuilderBaseTrophies = builderBaseTrophies;
            ExpLevel = expLevel;
            Name = name;
            PreviousRank = previousRank;
            Rank = rank;
            Tag = tag;
            Clan = clan;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets BuilderBaseLeague
        /// </summary>
        [JsonPropertyName("builderBaseLeague")]
        public BuilderBaseLeague BuilderBaseLeague { get; }

        /// <summary>
        /// Gets or Sets BuilderBaseTrophies
        /// </summary>
        [JsonPropertyName("builderBaseTrophies")]
        public int BuilderBaseTrophies { get; }

        /// <summary>
        /// Gets or Sets ExpLevel
        /// </summary>
        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; }

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
            sb.Append("class PlayerBuilderBaseRanking {\n");
            sb.Append("  BuilderBaseLeague: ").Append(BuilderBaseLeague).Append("\n");
            sb.Append("  BuilderBaseTrophies: ").Append(BuilderBaseTrophies).Append("\n");
            sb.Append("  ExpLevel: ").Append(ExpLevel).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PreviousRank: ").Append(PreviousRank).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as PlayerBuilderBaseRanking);
        }

        /// <summary>
        /// Returns true if PlayerBuilderBaseRanking instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerBuilderBaseRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerBuilderBaseRanking? input)
        {
            if (input == null)
                return false;

            return 
                (
                    BuilderBaseLeague == input.BuilderBaseLeague ||
                    (BuilderBaseLeague != null &&
                    BuilderBaseLeague.Equals(input.BuilderBaseLeague))
                ) && 
                (
                    BuilderBaseTrophies == input.BuilderBaseTrophies ||
                    BuilderBaseTrophies.Equals(input.BuilderBaseTrophies)
                ) && 
                (
                    ExpLevel == input.ExpLevel ||
                    ExpLevel.Equals(input.ExpLevel)
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    PreviousRank == input.PreviousRank ||
                    PreviousRank.Equals(input.PreviousRank)
                ) && 
                (
                    Rank == input.Rank ||
                    Rank.Equals(input.Rank)
                ) && 
                (
                    Tag == input.Tag ||
                    (Tag != null &&
                    Tag.Equals(input.Tag))
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
                hashCode = (hashCode * 59) + BuilderBaseLeague.GetHashCode();
                hashCode = (hashCode * 59) + BuilderBaseTrophies.GetHashCode();
                hashCode = (hashCode * 59) + ExpLevel.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + PreviousRank.GetHashCode();
                hashCode = (hashCode * 59) + Rank.GetHashCode();
                hashCode = (hashCode * 59) + Tag.GetHashCode();

                if (Clan != null)
                    hashCode = (hashCode * 59) + Clan.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayerBuilderBaseRanking" />
    /// </summary>
    public class PlayerBuilderBaseRankingJsonConverter : JsonConverter<PlayerBuilderBaseRanking>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerBuilderBaseRanking" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerBuilderBaseRanking Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            BuilderBaseLeague? builderBaseLeague = default;
            int? builderBaseTrophies = default;
            int? expLevel = default;
            string? name = default;
            int? previousRank = default;
            int? rank = default;
            string? tag = default;
            PlayerRankingClan? clan = default;

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
                        case "builderBaseLeague":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                builderBaseLeague = JsonSerializer.Deserialize<BuilderBaseLeague>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "builderBaseTrophies":
                        case "versusTrophies": // legacy property
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                builderBaseTrophies = utf8JsonReader.GetInt32();
                            break;
                        case "expLevel":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                expLevel = utf8JsonReader.GetInt32();
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "previousRank":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                previousRank = utf8JsonReader.GetInt32();
                            break;
                        case "rank":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rank = utf8JsonReader.GetInt32();
                            break;
                        case "tag":
                            tag = utf8JsonReader.GetString();
                            break;
                        case "clan":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                clan = JsonSerializer.Deserialize<PlayerRankingClan>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (builderBaseLeague == null)
                throw new ArgumentNullException(nameof(builderBaseLeague), "Property is required for class PlayerBuilderBaseRanking.");

            if (tag == null)
                throw new ArgumentNullException(nameof(tag), "Property is required for class PlayerBuilderBaseRanking.");

            if (name == null)
                throw new ArgumentNullException(nameof(name), "Property is required for class PlayerBuilderBaseRanking.");

            if (expLevel == null)
                throw new ArgumentNullException(nameof(expLevel), "Property is required for class PlayerBuilderBaseRanking.");

            if (rank == null)
                throw new ArgumentNullException(nameof(rank), "Property is required for class PlayerBuilderBaseRanking.");

            if (previousRank == null)
                throw new ArgumentNullException(nameof(previousRank), "Property is required for class PlayerBuilderBaseRanking.");

            if (builderBaseTrophies == null)
                throw new ArgumentNullException(nameof(builderBaseTrophies), "Property is required for class PlayerBuilderBaseRanking.");

            return new PlayerBuilderBaseRanking(builderBaseLeague, builderBaseTrophies.Value, expLevel.Value, name, previousRank.Value, rank.Value, tag, clan);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerBuilderBaseRanking" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerBuilderBaseRanking"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerBuilderBaseRanking playerBuilderBaseRanking, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("builderBaseLeague");
            JsonSerializer.Serialize(writer, playerBuilderBaseRanking.BuilderBaseLeague, jsonSerializerOptions);
            writer.WriteNumber("builderBaseTrophies", playerBuilderBaseRanking.BuilderBaseTrophies);
            writer.WriteNumber("expLevel", playerBuilderBaseRanking.ExpLevel);
            writer.WriteString("name", playerBuilderBaseRanking.Name);
            writer.WriteNumber("previousRank", playerBuilderBaseRanking.PreviousRank);
            writer.WriteNumber("rank", playerBuilderBaseRanking.Rank);
            writer.WriteString("tag", playerBuilderBaseRanking.Tag);
            writer.WritePropertyName("clan");
            JsonSerializer.Serialize(writer, playerBuilderBaseRanking.Clan, jsonSerializerOptions);

            writer.WriteEndObject();
        }
    }
}
