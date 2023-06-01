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
    /// PlayerLegendStatistics
    /// </summary>
    public partial class PlayerLegendStatistics : IEquatable<PlayerLegendStatistics?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerLegendStatistics" /> class.
        /// </summary>
        /// <param name="currentSeason">currentSeason</param>
        /// <param name="legendTrophies">legendTrophies</param>
        /// <param name="bestBuilderBaseSeason">bestBuilderBaseSeason</param>
        /// <param name="bestSeason">bestSeason</param>
        /// <param name="previousBuilderBaseSeason">previousBuilderBaseSeason</param>
        /// <param name="previousSeason">previousSeason</param>
        [JsonConstructor]
        internal PlayerLegendStatistics(LegendLeagueTournamentSeasonResult currentSeason, int legendTrophies, LegendLeagueTournamentSeasonResult? bestBuilderBaseSeason = default, LegendLeagueTournamentSeasonResult? bestSeason = default, LegendLeagueTournamentSeasonResult? previousBuilderBaseSeason = default, LegendLeagueTournamentSeasonResult? previousSeason = default)
        {
            CurrentSeason = currentSeason;
            LegendTrophies = legendTrophies;
            BestBuilderBaseSeason = bestBuilderBaseSeason;
            BestSeason = bestSeason;
            PreviousBuilderBaseSeason = previousBuilderBaseSeason;
            PreviousSeason = previousSeason;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets CurrentSeason
        /// </summary>
        [JsonPropertyName("currentSeason")]
        public LegendLeagueTournamentSeasonResult CurrentSeason { get; }

        /// <summary>
        /// Gets or Sets LegendTrophies
        /// </summary>
        [JsonPropertyName("legendTrophies")]
        public int LegendTrophies { get; }

        /// <summary>
        /// Gets or Sets BestBuilderBaseSeason
        /// </summary>
        [JsonPropertyName("bestBuilderBaseSeason")]
        public LegendLeagueTournamentSeasonResult? BestBuilderBaseSeason { get; }

        /// <summary>
        /// Gets or Sets BestSeason
        /// </summary>
        [JsonPropertyName("bestSeason")]
        public LegendLeagueTournamentSeasonResult? BestSeason { get; }

        /// <summary>
        /// Gets or Sets PreviousBuilderBaseSeason
        /// </summary>
        [JsonPropertyName("previousBuilderBaseSeason")]
        public LegendLeagueTournamentSeasonResult? PreviousBuilderBaseSeason { get; }

        /// <summary>
        /// Gets or Sets PreviousSeason
        /// </summary>
        [JsonPropertyName("previousSeason")]
        public LegendLeagueTournamentSeasonResult? PreviousSeason { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerLegendStatistics {\n");
            sb.Append("  CurrentSeason: ").Append(CurrentSeason).Append("\n");
            sb.Append("  LegendTrophies: ").Append(LegendTrophies).Append("\n");
            sb.Append("  BestBuilderBaseSeason: ").Append(BestBuilderBaseSeason).Append("\n");
            sb.Append("  BestSeason: ").Append(BestSeason).Append("\n");
            sb.Append("  PreviousBuilderBaseSeason: ").Append(PreviousBuilderBaseSeason).Append("\n");
            sb.Append("  PreviousSeason: ").Append(PreviousSeason).Append("\n");
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
            return this.Equals(input as PlayerLegendStatistics);
        }

        /// <summary>
        /// Returns true if PlayerLegendStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerLegendStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerLegendStatistics? input)
        {
            if (input == null)
                return false;

            return 
                (
                    CurrentSeason == input.CurrentSeason ||
                    (CurrentSeason != null &&
                    CurrentSeason.Equals(input.CurrentSeason))
                ) && 
                (
                    LegendTrophies == input.LegendTrophies ||
                    LegendTrophies.Equals(input.LegendTrophies)
                ) && 
                (
                    BestBuilderBaseSeason == input.BestBuilderBaseSeason ||
                    (BestBuilderBaseSeason != null &&
                    BestBuilderBaseSeason.Equals(input.BestBuilderBaseSeason))
                ) && 
                (
                    BestSeason == input.BestSeason ||
                    (BestSeason != null &&
                    BestSeason.Equals(input.BestSeason))
                ) && 
                (
                    PreviousBuilderBaseSeason == input.PreviousBuilderBaseSeason ||
                    (PreviousBuilderBaseSeason != null &&
                    PreviousBuilderBaseSeason.Equals(input.PreviousBuilderBaseSeason))
                ) && 
                (
                    PreviousSeason == input.PreviousSeason ||
                    (PreviousSeason != null &&
                    PreviousSeason.Equals(input.PreviousSeason))
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
                hashCode = (hashCode * 59) + CurrentSeason.GetHashCode();
                hashCode = (hashCode * 59) + LegendTrophies.GetHashCode();

                if (BestBuilderBaseSeason != null)
                    hashCode = (hashCode * 59) + BestBuilderBaseSeason.GetHashCode();

                if (BestSeason != null)
                    hashCode = (hashCode * 59) + BestSeason.GetHashCode();

                if (PreviousBuilderBaseSeason != null)
                    hashCode = (hashCode * 59) + PreviousBuilderBaseSeason.GetHashCode();

                if (PreviousSeason != null)
                    hashCode = (hashCode * 59) + PreviousSeason.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayerLegendStatistics" />
    /// </summary>
    public class PlayerLegendStatisticsJsonConverter : JsonConverter<PlayerLegendStatistics>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerLegendStatistics" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerLegendStatistics Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            LegendLeagueTournamentSeasonResult? currentSeason = default;
            int? legendTrophies = default;
            LegendLeagueTournamentSeasonResult? bestBuilderBaseSeason = default;
            LegendLeagueTournamentSeasonResult? bestSeason = default;
            LegendLeagueTournamentSeasonResult? previousBuilderBaseSeason = default;
            LegendLeagueTournamentSeasonResult? previousSeason = default;

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
                        case "currentSeason":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                currentSeason = JsonSerializer.Deserialize<LegendLeagueTournamentSeasonResult>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "legendTrophies":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                legendTrophies = utf8JsonReader.GetInt32();
                            break;
                        case "bestBuilderBaseSeason":
                        case "bestVersusSeason": // legacy property
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                bestBuilderBaseSeason = JsonSerializer.Deserialize<LegendLeagueTournamentSeasonResult>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "bestSeason":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                bestSeason = JsonSerializer.Deserialize<LegendLeagueTournamentSeasonResult>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "previousBuilderBaseSeason":
                        case "previousVersusSeason": // legacy property
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                previousBuilderBaseSeason = JsonSerializer.Deserialize<LegendLeagueTournamentSeasonResult>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "previousSeason":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                previousSeason = JsonSerializer.Deserialize<LegendLeagueTournamentSeasonResult>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (currentSeason == null)
                throw new ArgumentNullException(nameof(currentSeason), "Property is required for class PlayerLegendStatistics.");

            if (legendTrophies == null)
                throw new ArgumentNullException(nameof(legendTrophies), "Property is required for class PlayerLegendStatistics.");

            return new PlayerLegendStatistics(currentSeason, legendTrophies.Value, bestBuilderBaseSeason, bestSeason, previousBuilderBaseSeason, previousSeason);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerLegendStatistics" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerLegendStatistics"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerLegendStatistics playerLegendStatistics, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("currentSeason");
            JsonSerializer.Serialize(writer, playerLegendStatistics.CurrentSeason, jsonSerializerOptions);
            writer.WriteNumber("legendTrophies", playerLegendStatistics.LegendTrophies);
            writer.WritePropertyName("bestBuilderBaseSeason");
            JsonSerializer.Serialize(writer, playerLegendStatistics.BestBuilderBaseSeason, jsonSerializerOptions);
            writer.WritePropertyName("bestSeason");
            JsonSerializer.Serialize(writer, playerLegendStatistics.BestSeason, jsonSerializerOptions);
            writer.WritePropertyName("previousBuilderBaseSeason");
            JsonSerializer.Serialize(writer, playerLegendStatistics.PreviousBuilderBaseSeason, jsonSerializerOptions);
            writer.WritePropertyName("previousSeason");
            JsonSerializer.Serialize(writer, playerLegendStatistics.PreviousSeason, jsonSerializerOptions);

            writer.WriteEndObject();
        }
    }
}
