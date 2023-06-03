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
    /// ClanWarLeagueClan
    /// </summary>
    public partial class ClanWarLeagueClan : IEquatable<ClanWarLeagueClan?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanWarLeagueClan" /> class.
        /// </summary>
        /// <param name="badgeUrls">badgeUrls</param>
        /// <param name="clanLevel">clanLevel</param>
        /// <param name="members">members</param>
        /// <param name="name">name</param>
        /// <param name="tag">tag</param>
        [JsonConstructor]
        internal ClanWarLeagueClan(BadgeUrls badgeUrls, int clanLevel, List<ClanWarLeagueClanMember> members, string name, string tag)
        {
            BadgeUrls = badgeUrls;
            ClanLevel = clanLevel;
            Members = members;
            Name = name;
            Tag = tag;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets BadgeUrls
        /// </summary>
        [JsonPropertyName("badgeUrls")]
        public BadgeUrls BadgeUrls { get; }

        /// <summary>
        /// Gets or Sets ClanLevel
        /// </summary>
        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [JsonPropertyName("members")]
        public List<ClanWarLeagueClanMember> Members { get; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClanWarLeagueClan {\n");
            sb.Append("  BadgeUrls: ").Append(BadgeUrls).Append("\n");
            sb.Append("  ClanLevel: ").Append(ClanLevel).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as ClanWarLeagueClan);
        }

        /// <summary>
        /// Returns true if ClanWarLeagueClan instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanWarLeagueClan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanWarLeagueClan? input)
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
                    ClanLevel == input.ClanLevel ||
                    ClanLevel.Equals(input.ClanLevel)
                ) && 
                (
                    Members == input.Members ||
                    Members != null &&
                    input.Members != null &&
                    Members.SequenceEqual(input.Members)
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Tag == input.Tag ||
                    (Tag != null &&
                    Tag.Equals(input.Tag))
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
                hashCode = (hashCode * 59) + ClanLevel.GetHashCode();
                hashCode = (hashCode * 59) + Members.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + Tag.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ClanWarLeagueClan" />
    /// </summary>
    public class ClanWarLeagueClanJsonConverter : JsonConverter<ClanWarLeagueClan>
    {
        /// <summary>
        /// Deserializes json to <see cref="ClanWarLeagueClan" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClanWarLeagueClan Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            BadgeUrls? badgeUrls = default;
            int? clanLevel = default;
            List<ClanWarLeagueClanMember>? members = default;
            string? name = default;
            string? tag = default;

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
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                badgeUrls = JsonSerializer.Deserialize<BadgeUrls>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "clanLevel":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                clanLevel = utf8JsonReader.GetInt32();
                            break;
                        case "members":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                members = JsonSerializer.Deserialize<List<ClanWarLeagueClanMember>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "tag":
                            tag = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (badgeUrls == null)
                throw new ArgumentNullException(nameof(badgeUrls), "Property is required for class ClanWarLeagueClan.");

            if (clanLevel == null)
                throw new ArgumentNullException(nameof(clanLevel), "Property is required for class ClanWarLeagueClan.");

            if (members == null)
                throw new ArgumentNullException(nameof(members), "Property is required for class ClanWarLeagueClan.");

            if (name == null)
                throw new ArgumentNullException(nameof(name), "Property is required for class ClanWarLeagueClan.");

            if (tag == null)
                throw new ArgumentNullException(nameof(tag), "Property is required for class ClanWarLeagueClan.");

            return new ClanWarLeagueClan(badgeUrls, clanLevel.Value, members, name, tag);
        }

        /// <summary>
        /// Serializes a <see cref="ClanWarLeagueClan" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clanWarLeagueClan"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClanWarLeagueClan clanWarLeagueClan, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("badgeUrls");
            JsonSerializer.Serialize(writer, clanWarLeagueClan.BadgeUrls, jsonSerializerOptions);
            writer.WriteNumber("clanLevel", clanWarLeagueClan.ClanLevel);
            writer.WritePropertyName("members");
            JsonSerializer.Serialize(writer, clanWarLeagueClan.Members, jsonSerializerOptions);
            writer.WriteString("name", clanWarLeagueClan.Name);
            writer.WriteString("tag", clanWarLeagueClan.Tag);

            writer.WriteEndObject();
        }
    }
}
