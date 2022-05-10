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
    /// ClanWarLeagueRound
    /// </summary>
    public partial class ClanWarLeagueRound : IEquatable<ClanWarLeagueRound?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanWarLeagueRound" /> class.
        /// </summary>
        /// <param name="warTags">warTags</param>
        [JsonConstructor]
        internal ClanWarLeagueRound(List<string> warTags)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (warTags == null)
                throw new ArgumentNullException("warTags is a required property for ClanWarLeagueRound and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            WarTags = warTags;
        }

        /// <summary>
        /// Gets or Sets WarTags
        /// </summary>
        [JsonPropertyName("warTags")]
        public List<string> WarTags { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClanWarLeagueRound {\n");
            sb.Append("  WarTags: ").Append(WarTags).Append("\n");
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
            return this.Equals(input as ClanWarLeagueRound);
        }

        /// <summary>
        /// Returns true if ClanWarLeagueRound instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanWarLeagueRound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanWarLeagueRound? input)
        {
            if (input == null)
                return false;

            return 
                (
                    WarTags == input.WarTags ||
                    WarTags != null &&
                    input.WarTags != null &&
                    WarTags.SequenceEqual(input.WarTags)
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
                hashCode = (hashCode * 59) + WarTags.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type ClanWarLeagueRound
    /// </summary>
    public class ClanWarLeagueRoundJsonConverter : JsonConverter<ClanWarLeagueRound>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClanWarLeagueRound Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            List<string> warTags = default;

            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "warTags":
                            Utf8JsonReader warTagsReader = reader;
                            warTags = JsonSerializer.Deserialize<List<string>>(ref reader, options);
                            break;
                    }
                }
            }

            return new ClanWarLeagueRound(warTags);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clanWarLeagueRound"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClanWarLeagueRound clanWarLeagueRound, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("warTags");
            JsonSerializer.Serialize(writer, clanWarLeagueRound.WarTags, options);

            writer.WriteEndObject();
        }
    }
}

