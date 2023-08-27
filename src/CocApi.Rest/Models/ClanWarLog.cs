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
    /// ClanWarLog
    /// </summary>
    public partial class ClanWarLog : IEquatable<ClanWarLog?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanWarLog" /> class.
        /// </summary>
        /// <param name="items">items</param>
        [JsonConstructor]
        internal ClanWarLog(List<ClanWarLogEntry> items)
        {
            Items = items;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [JsonPropertyName("items")]
        public List<ClanWarLogEntry> Items { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClanWarLog {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as ClanWarLog);
        }

        /// <summary>
        /// Returns true if ClanWarLog instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanWarLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanWarLog? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Items == input.Items ||
                    Items != null &&
                    input.Items != null &&
                    Items.SequenceEqual(input.Items)
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
                hashCode = (hashCode * 59) + Items.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ClanWarLog" />
    /// </summary>
    public class ClanWarLogJsonConverter : JsonConverter<ClanWarLog>
    {
        /// <summary>
        /// Deserializes json to <see cref="ClanWarLog" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClanWarLog Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            List<ClanWarLogEntry>? items = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "items":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                items = JsonSerializer.Deserialize<List<ClanWarLogEntry>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (items == null)
                throw new ArgumentNullException(nameof(items), "Property is required for class ClanWarLog.");

            return new ClanWarLog(items);
        }

        /// <summary>
        /// Serializes a <see cref="ClanWarLog" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clanWarLog"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClanWarLog clanWarLog, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, clanWarLog, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ClanWarLog" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clanWarLog"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ClanWarLog clanWarLog, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WritePropertyName("items");
            JsonSerializer.Serialize(writer, clanWarLog.Items, jsonSerializerOptions);
        }
    }
}
