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
    /// League
    /// </summary>
    public partial class League : IEquatable<League?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="League" /> class.
        /// </summary>
        /// <param name="iconUrls">iconUrls</param>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        [JsonConstructor]
        internal League(IconUrls iconUrls, int id, string name)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (name == null)
                throw new ArgumentNullException("name is a required property for League and cannot be null.");

            if (id == null)
                throw new ArgumentNullException("id is a required property for League and cannot be null.");

            if (iconUrls == null)
                throw new ArgumentNullException("iconUrls is a required property for League and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            IconUrls = iconUrls;
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Gets or Sets IconUrls
        /// </summary>
        [JsonPropertyName("iconUrls")]
        public IconUrls IconUrls { get; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class League {\n");
            sb.Append("  IconUrls: ").Append(IconUrls).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as League);
        }

        /// <summary>
        /// Returns true if League instances are equal
        /// </summary>
        /// <param name="input">Instance of League to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(League? input)
        {
            if (input == null)
                return false;

            return 
                (
                    IconUrls == input.IconUrls ||
                    (IconUrls != null &&
                    IconUrls.Equals(input.IconUrls))
                ) && 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + IconUrls.GetHashCode();
                hashCode = (hashCode * 59) + Id.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type League
    /// </summary>
    public class LeagueJsonConverter : JsonConverter<League>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override League Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            IconUrls iconUrls = default;
            int id = default;
            string name = default;

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
                        case "iconUrls":
                            Utf8JsonReader iconUrlsReader = reader;
                            iconUrls = JsonSerializer.Deserialize<IconUrls>(ref reader, options);
                            break;
                        case "id":
                            id = reader.GetInt32();
                            break;
                        case "name":
                            Utf8JsonReader nameReader = reader;
                            name = JsonSerializer.Deserialize<string>(ref reader, options);
                            break;
                    }
                }
            }

            return new League(iconUrls, id, name);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="league"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, League league, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("iconUrls");
            JsonSerializer.Serialize(writer, league.IconUrls, options);
            writer.WriteNumber("id", (int)league.Id);
            writer.WritePropertyName("name");
            JsonSerializer.Serialize(writer, league.Name, options);

            writer.WriteEndObject();
        }
    }
}

