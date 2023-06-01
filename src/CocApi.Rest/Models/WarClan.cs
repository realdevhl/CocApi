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
    /// WarClan
    /// </summary>
    public partial class WarClan : IEquatable<WarClan?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarClan" /> class.
        /// </summary>
        /// <param name="attacks">attacks</param>
        /// <param name="badgeUrls">badgeUrls</param>
        /// <param name="clanLevel">clanLevel</param>
        /// <param name="destructionPercentage">destructionPercentage</param>
        /// <param name="expEarned">expEarned</param>
        /// <param name="members">members</param>
        /// <param name="name">name</param>
        /// <param name="stars">stars</param>
        /// <param name="tag">tag</param>
        [JsonConstructor]
        internal WarClan(int attacks, BadgeUrls badgeUrls, int clanLevel, float destructionPercentage, int expEarned, List<ClanWarMember> members, string name, int stars, string tag)
        {
            Attacks = attacks;
            BadgeUrls = badgeUrls;
            ClanLevel = clanLevel;
            DestructionPercentage = destructionPercentage;
            ExpEarned = expEarned;
            Members = members;
            Name = name;
            Stars = stars;
            Tag = tag;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Attacks
        /// </summary>
        [JsonPropertyName("attacks")]
        public int Attacks { get; }

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
        /// Gets or Sets DestructionPercentage
        /// </summary>
        [JsonPropertyName("destructionPercentage")]
        public float DestructionPercentage { get; }

        /// <summary>
        /// Gets or Sets ExpEarned
        /// </summary>
        [JsonPropertyName("expEarned")]
        public int ExpEarned { get; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [JsonPropertyName("members")]
        public List<ClanWarMember> Members { get; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [JsonPropertyName("stars")]
        public int Stars { get; }

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
            sb.Append("class WarClan {\n");
            sb.Append("  Attacks: ").Append(Attacks).Append("\n");
            sb.Append("  BadgeUrls: ").Append(BadgeUrls).Append("\n");
            sb.Append("  ClanLevel: ").Append(ClanLevel).Append("\n");
            sb.Append("  DestructionPercentage: ").Append(DestructionPercentage).Append("\n");
            sb.Append("  ExpEarned: ").Append(ExpEarned).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
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
            return this.Equals(input as WarClan);
        }

        /// <summary>
        /// Returns true if WarClan instances are equal
        /// </summary>
        /// <param name="input">Instance of WarClan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WarClan? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Attacks == input.Attacks ||
                    Attacks.Equals(input.Attacks)
                ) && 
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
                    DestructionPercentage == input.DestructionPercentage ||
                    DestructionPercentage.Equals(input.DestructionPercentage)
                ) && 
                (
                    ExpEarned == input.ExpEarned ||
                    ExpEarned.Equals(input.ExpEarned)
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
                    Stars == input.Stars ||
                    Stars.Equals(input.Stars)
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
                hashCode = (hashCode * 59) + Attacks.GetHashCode();
                hashCode = (hashCode * 59) + BadgeUrls.GetHashCode();
                hashCode = (hashCode * 59) + ClanLevel.GetHashCode();
                hashCode = (hashCode * 59) + DestructionPercentage.GetHashCode();
                hashCode = (hashCode * 59) + ExpEarned.GetHashCode();
                hashCode = (hashCode * 59) + Members.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + Stars.GetHashCode();
                hashCode = (hashCode * 59) + Tag.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="WarClan" />
    /// </summary>
    public class WarClanJsonConverter : JsonConverter<WarClan>
    {
        /// <summary>
        /// Deserializes json to <see cref="WarClan" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WarClan Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            int? attacks = default;
            BadgeUrls? badgeUrls = default;
            int? clanLevel = default;
            float? destructionPercentage = default;
            int? expEarned = default;
            List<ClanWarMember>? members = default;
            string? name = default;
            int? stars = default;
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
                        case "attacks":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attacks = utf8JsonReader.GetInt32();
                            break;
                        case "badgeUrls":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                badgeUrls = JsonSerializer.Deserialize<BadgeUrls>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "clanLevel":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                clanLevel = utf8JsonReader.GetInt32();
                            break;
                        case "destructionPercentage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                destructionPercentage = (float)utf8JsonReader.GetDouble();
                            break;
                        case "expEarned":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                expEarned = utf8JsonReader.GetInt32();
                            break;
                        case "members":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                members = JsonSerializer.Deserialize<List<ClanWarMember>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "stars":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stars = utf8JsonReader.GetInt32();
                            break;
                        case "tag":
                            tag = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (destructionPercentage == null)
                throw new ArgumentNullException("destructionPercentage is a required property for WarClan and cannot be null.");

            //if (tag == null)
                //    throw new ArgumentNullException("tag is a required property for WarClan and cannot be null.");

            //if (name == null)
                //    throw new ArgumentNullException("name is a required property for WarClan and cannot be null.");

            if (badgeUrls == null)
                throw new ArgumentNullException("badgeUrls is a required property for WarClan and cannot be null.");

            if (clanLevel == null)
                throw new ArgumentNullException("clanLevel is a required property for WarClan and cannot be null.");

            if (attacks == null)
                throw new ArgumentNullException("attacks is a required property for WarClan and cannot be null.");

            if (stars == null)
                throw new ArgumentNullException("stars is a required property for WarClan and cannot be null.");

            //if (expEarned == null)
            //    throw new ArgumentNullException("expEarned is a required property for WarClan and cannot be null.");

            //if (members == null)
            //    throw new ArgumentNullException("members is a required property for WarClan and cannot be null.");

            return new WarClan(attacks.Value, badgeUrls, clanLevel.Value, destructionPercentage.Value, expEarned.GetValueOrDefault(), members, name, stars.Value, tag);
        }

        /// <summary>
        /// Serializes a <see cref="WarClan" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="warClan"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WarClan warClan, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteNumber("attacks", warClan.Attacks);
            writer.WritePropertyName("badgeUrls");
            JsonSerializer.Serialize(writer, warClan.BadgeUrls, jsonSerializerOptions);
            writer.WriteNumber("clanLevel", warClan.ClanLevel);
            writer.WriteNumber("destructionPercentage", warClan.DestructionPercentage);
            writer.WriteNumber("expEarned", warClan.ExpEarned);
            writer.WritePropertyName("members");
            JsonSerializer.Serialize(writer, warClan.Members, jsonSerializerOptions);
            writer.WriteString("name", warClan.Name);
            writer.WriteNumber("stars", warClan.Stars);
            writer.WriteString("tag", warClan.Tag);

            writer.WriteEndObject();
        }
    }
}
