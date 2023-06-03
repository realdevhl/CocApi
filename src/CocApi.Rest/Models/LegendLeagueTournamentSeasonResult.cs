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
    /// LegendLeagueTournamentSeasonResult
    /// </summary>
    public partial class LegendLeagueTournamentSeasonResult : IEquatable<LegendLeagueTournamentSeasonResult?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegendLeagueTournamentSeasonResult" /> class.
        /// </summary>
        /// <param name="trophies">trophies</param>
        /// <param name="id">id</param>
        /// <param name="rank">rank</param>
        [JsonConstructor]
        internal LegendLeagueTournamentSeasonResult(int trophies, DateTime? id = default, int? rank = default)
        {
            Trophies = trophies;
            Id = id;
            Rank = rank;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Trophies
        /// </summary>
        [JsonPropertyName("trophies")]
        public int Trophies { get; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public DateTime? Id { get; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [JsonPropertyName("rank")]
        public int? Rank { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LegendLeagueTournamentSeasonResult {\n");
            sb.Append("  Trophies: ").Append(Trophies).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
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
            return this.Equals(input as LegendLeagueTournamentSeasonResult);
        }

        /// <summary>
        /// Returns true if LegendLeagueTournamentSeasonResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LegendLeagueTournamentSeasonResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegendLeagueTournamentSeasonResult? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Trophies == input.Trophies ||
                    Trophies.Equals(input.Trophies)
                ) && 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    Rank == input.Rank ||
                    (Rank != null &&
                    Rank.Equals(input.Rank))
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
                hashCode = (hashCode * 59) + Trophies.GetHashCode();

                if (Id != null)
                    hashCode = (hashCode * 59) + Id.GetHashCode();

                if (Rank != null)
                    hashCode = (hashCode * 59) + Rank.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="LegendLeagueTournamentSeasonResult" />
    /// </summary>
    public class LegendLeagueTournamentSeasonResultJsonConverter : JsonConverter<LegendLeagueTournamentSeasonResult>
    {
        /// <summary>
        /// The format to use to serialize Id
        /// </summary>
        public static string IdFormat { get; set; } = "yyyy'-'MM";

        /// <summary>
        /// Deserializes json to <see cref="LegendLeagueTournamentSeasonResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override LegendLeagueTournamentSeasonResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            int? trophies = default;
            DateTime? id = default;
            int? rank = default;

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
                        case "trophies":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                trophies = utf8JsonReader.GetInt32();
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "rank":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rank = utf8JsonReader.GetInt32();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (trophies == null)
                throw new ArgumentNullException(nameof(trophies), "Property is required for class LegendLeagueTournamentSeasonResult.");

            return new LegendLeagueTournamentSeasonResult(trophies.Value, id, rank);
        }

        /// <summary>
        /// Serializes a <see cref="LegendLeagueTournamentSeasonResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="legendLeagueTournamentSeasonResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, LegendLeagueTournamentSeasonResult legendLeagueTournamentSeasonResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteNumber("trophies", legendLeagueTournamentSeasonResult.Trophies);

            if (legendLeagueTournamentSeasonResult.Id != null)
                writer.WriteString("id", legendLeagueTournamentSeasonResult.Id.Value.ToString(IdFormat));
            else
                writer.WriteNull("id");

            if (legendLeagueTournamentSeasonResult.Rank != null)
                writer.WriteNumber("rank", legendLeagueTournamentSeasonResult.Rank.Value);
            else
                writer.WriteNull("rank");

            writer.WriteEndObject();
        }
    }
}
