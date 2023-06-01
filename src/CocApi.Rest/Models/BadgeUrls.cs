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
    /// BadgeUrls
    /// </summary>
    public partial class BadgeUrls : IEquatable<BadgeUrls?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadgeUrls" /> class.
        /// </summary>
        /// <param name="large">large</param>
        /// <param name="medium">medium</param>
        /// <param name="small">small</param>
        [JsonConstructor]
        internal BadgeUrls(string large, string medium, string small)
        {
            Large = large;
            Medium = medium;
            Small = small;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Large
        /// </summary>
        [JsonPropertyName("large")]
        public string Large { get; }

        /// <summary>
        /// Gets or Sets Medium
        /// </summary>
        [JsonPropertyName("medium")]
        public string Medium { get; }

        /// <summary>
        /// Gets or Sets Small
        /// </summary>
        [JsonPropertyName("small")]
        public string Small { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BadgeUrls {\n");
            sb.Append("  Large: ").Append(Large).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
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
            return this.Equals(input as BadgeUrls);
        }

        /// <summary>
        /// Returns true if BadgeUrls instances are equal
        /// </summary>
        /// <param name="input">Instance of BadgeUrls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BadgeUrls? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Large == input.Large ||
                    (Large != null &&
                    Large.Equals(input.Large))
                ) && 
                (
                    Medium == input.Medium ||
                    (Medium != null &&
                    Medium.Equals(input.Medium))
                ) && 
                (
                    Small == input.Small ||
                    (Small != null &&
                    Small.Equals(input.Small))
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
                hashCode = (hashCode * 59) + Large.GetHashCode();
                hashCode = (hashCode * 59) + Medium.GetHashCode();
                hashCode = (hashCode * 59) + Small.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="BadgeUrls" />
    /// </summary>
    public class BadgeUrlsJsonConverter : JsonConverter<BadgeUrls>
    {
        /// <summary>
        /// Deserializes json to <see cref="BadgeUrls" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BadgeUrls Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? large = default;
            string? medium = default;
            string? small = default;

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
                        case "large":
                            large = utf8JsonReader.GetString();
                            break;
                        case "medium":
                            medium = utf8JsonReader.GetString();
                            break;
                        case "small":
                            small = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (small == null)
                throw new ArgumentNullException(nameof(small), "Property is required for class BadgeUrls.");

            if (medium == null)
                throw new ArgumentNullException(nameof(medium), "Property is required for class BadgeUrls.");

            if (large == null)
                throw new ArgumentNullException(nameof(large), "Property is required for class BadgeUrls.");

            return new BadgeUrls(large, medium, small);
        }

        /// <summary>
        /// Serializes a <see cref="BadgeUrls" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="badgeUrls"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BadgeUrls badgeUrls, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("large", badgeUrls.Large);
            writer.WriteString("medium", badgeUrls.Medium);
            writer.WriteString("small", badgeUrls.Small);

            writer.WriteEndObject();
        }
    }
}
