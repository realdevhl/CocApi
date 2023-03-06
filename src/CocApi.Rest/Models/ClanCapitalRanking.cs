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
    /// ClanCapitalRanking
    /// </summary>
    public partial class ClanCapitalRanking : IEquatable<ClanCapitalRanking?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanCapitalRanking" /> class.
        /// </summary>
        /// <param name="badgeUrls">badgeUrls</param>
        /// <param name="clanCapitalPoints">clanCapitalPoints</param>
        /// <param name="clanLevel">clanLevel</param>
        /// <param name="members">members</param>
        /// <param name="name">name</param>
        /// <param name="previousRank">previousRank</param>
        /// <param name="rank">rank</param>
        /// <param name="tag">tag</param>
        /// <param name="location">location</param>
        [JsonConstructor]
        internal ClanCapitalRanking(BadgeUrls badgeUrls, int clanCapitalPoints, int clanLevel, int members, string name, int previousRank, int rank, string tag, Location? location = default)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (clanCapitalPoints == null)
                throw new ArgumentNullException("clanCapitalPoints is a required property for ClanCapitalRanking and cannot be null.");

            if (tag == null)
                throw new ArgumentNullException("tag is a required property for ClanCapitalRanking and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for ClanCapitalRanking and cannot be null.");

            if (badgeUrls == null)
                throw new ArgumentNullException("badgeUrls is a required property for ClanCapitalRanking and cannot be null.");

            if (clanLevel == null)
                throw new ArgumentNullException("clanLevel is a required property for ClanCapitalRanking and cannot be null.");

            if (members == null)
                throw new ArgumentNullException("members is a required property for ClanCapitalRanking and cannot be null.");

            if (rank == null)
                throw new ArgumentNullException("rank is a required property for ClanCapitalRanking and cannot be null.");

            if (previousRank == null)
                throw new ArgumentNullException("previousRank is a required property for ClanCapitalRanking and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            BadgeUrls = badgeUrls;
            ClanCapitalPoints = clanCapitalPoints;
            ClanLevel = clanLevel;
            Members = members;
            Name = name;
            PreviousRank = previousRank;
            Rank = rank;
            Tag = tag;
            Location = location;
        }

        /// <summary>
        /// Gets or Sets BadgeUrls
        /// </summary>
        [JsonPropertyName("badgeUrls")]
        public BadgeUrls BadgeUrls { get; }

        /// <summary>
        /// Gets or Sets ClanCapitalPoints
        /// </summary>
        [JsonPropertyName("clanCapitalPoints")]
        public int ClanCapitalPoints { get; }

        /// <summary>
        /// Gets or Sets ClanLevel
        /// </summary>
        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [JsonPropertyName("members")]
        public int Members { get; }

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
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public Location? Location { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClanCapitalRanking {\n");
            sb.Append("  BadgeUrls: ").Append(BadgeUrls).Append("\n");
            sb.Append("  ClanCapitalPoints: ").Append(ClanCapitalPoints).Append("\n");
            sb.Append("  ClanLevel: ").Append(ClanLevel).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PreviousRank: ").Append(PreviousRank).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as ClanCapitalRanking);
        }

        /// <summary>
        /// Returns true if ClanCapitalRanking instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanCapitalRanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanCapitalRanking? input)
        {
            if (input == null)
                return false;

            return 
                (
                    BadgeUrls == input.BadgeUrls ||
                    (BadgeUrls != null &&
                    BadgeUrls.Equals(input.BadgeUrls))
                ) && 
                (
                    ClanCapitalPoints == input.ClanCapitalPoints ||
                    (ClanCapitalPoints != null &&
                    ClanCapitalPoints.Equals(input.ClanCapitalPoints))
                ) && 
                (
                    ClanLevel == input.ClanLevel ||
                    (ClanLevel != null &&
                    ClanLevel.Equals(input.ClanLevel))
                ) && 
                (
                    Members == input.Members ||
                    (Members != null &&
                    Members.Equals(input.Members))
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
                    Location == input.Location ||
                    (Location != null &&
                    Location.Equals(input.Location))
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
                hashCode = (hashCode * 59) + BadgeUrls.GetHashCode();
                hashCode = (hashCode * 59) + ClanCapitalPoints.GetHashCode();
                hashCode = (hashCode * 59) + ClanLevel.GetHashCode();
                hashCode = (hashCode * 59) + Members.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + PreviousRank.GetHashCode();
                hashCode = (hashCode * 59) + Rank.GetHashCode();
                hashCode = (hashCode * 59) + Tag.GetHashCode();

                if (Location != null)
                    hashCode = (hashCode * 59) + Location.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type ClanCapitalRanking
    /// </summary>
    public class ClanCapitalRankingJsonConverter : JsonConverter<ClanCapitalRanking>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClanCapitalRanking Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            BadgeUrls badgeUrls = default;
            int clanCapitalPoints = default;
            int clanLevel = default;
            int members = default;
            string name = default;
            int previousRank = default;
            int rank = default;
            string tag = default;
            Location location = default;

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
                        case "badgeUrls":
                            badgeUrls = JsonSerializer.Deserialize<BadgeUrls>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "clanCapitalPoints":
                            clanCapitalPoints = utf8JsonReader.GetInt32();
                            break;
                        case "clanLevel":
                            clanLevel = utf8JsonReader.GetInt32();
                            break;
                        case "members":
                            members = utf8JsonReader.GetInt32();
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "previousRank":
                            previousRank = utf8JsonReader.GetInt32();
                            break;
                        case "rank":
                            rank = utf8JsonReader.GetInt32();
                            break;
                        case "tag":
                            tag = utf8JsonReader.GetString();
                            break;
                        case "location":
                            location = JsonSerializer.Deserialize<Location>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ClanCapitalRanking(badgeUrls, clanCapitalPoints, clanLevel, members, name, previousRank, rank, tag, location);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clanCapitalRanking"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClanCapitalRanking clanCapitalRanking, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("badgeUrls");
            JsonSerializer.Serialize(writer, clanCapitalRanking.BadgeUrls, jsonSerializerOptions);
            writer.WriteNumber("clanCapitalPoints", clanCapitalRanking.ClanCapitalPoints);
            writer.WriteNumber("clanLevel", clanCapitalRanking.ClanLevel);
            writer.WriteNumber("members", clanCapitalRanking.Members);
            writer.WriteString("name", clanCapitalRanking.Name);
            writer.WriteNumber("previousRank", clanCapitalRanking.PreviousRank);
            writer.WriteNumber("rank", clanCapitalRanking.Rank);
            writer.WriteString("tag", clanCapitalRanking.Tag);
            writer.WritePropertyName("location");
            JsonSerializer.Serialize(writer, clanCapitalRanking.Location, jsonSerializerOptions);

            writer.WriteEndObject();
        }
    }
}
