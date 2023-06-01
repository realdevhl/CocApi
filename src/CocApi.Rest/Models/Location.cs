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
    /// Location
    /// </summary>
    public partial class Location : IEquatable<Location?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="isCountry">isCountry</param>
        /// <param name="name">name</param>
        /// <param name="countryCode">countryCode</param>
        /// <param name="localizedName">localizedName</param>
        [JsonConstructor]
        internal Location(int id, bool isCountry, string name, string? countryCode = default, string? localizedName = default)
        {
            Id = id;
            IsCountry = isCountry;
            Name = name;
            CountryCode = countryCode;
            LocalizedName = localizedName;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; }

        /// <summary>
        /// Gets or Sets IsCountry
        /// </summary>
        [JsonPropertyName("isCountry")]
        public bool IsCountry { get; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string? CountryCode { get; }

        /// <summary>
        /// Gets or Sets LocalizedName
        /// </summary>
        [JsonPropertyName("localizedName")]
        public string? LocalizedName { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsCountry: ").Append(IsCountry).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  LocalizedName: ").Append(LocalizedName).Append("\n");
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
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Id == input.Id ||
                    Id.Equals(input.Id)
                ) && 
                (
                    IsCountry == input.IsCountry ||
                    IsCountry.Equals(input.IsCountry)
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    CountryCode == input.CountryCode ||
                    (CountryCode != null &&
                    CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    LocalizedName == input.LocalizedName ||
                    (LocalizedName != null &&
                    LocalizedName.Equals(input.LocalizedName))
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
                hashCode = (hashCode * 59) + Id.GetHashCode();
                hashCode = (hashCode * 59) + IsCountry.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();

                if (CountryCode != null)
                    hashCode = (hashCode * 59) + CountryCode.GetHashCode();

                if (LocalizedName != null)
                    hashCode = (hashCode * 59) + LocalizedName.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Location" />
    /// </summary>
    public class LocationJsonConverter : JsonConverter<Location>
    {
        /// <summary>
        /// Deserializes json to <see cref="Location" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Location Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            int? id = default;
            bool? isCountry = default;
            string? name = default;
            string? countryCode = default;
            string? localizedName = default;

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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = utf8JsonReader.GetInt32();
                            break;
                        case "isCountry":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isCountry = utf8JsonReader.GetBoolean();
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "countryCode":
                            countryCode = utf8JsonReader.GetString();
                            break;
                        case "localizedName":
                            localizedName = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id == null)
                throw new ArgumentNullException(nameof(id), "Property is required for class Location.");

            if (name == null)
                throw new ArgumentNullException(nameof(name), "Property is required for class Location.");

            if (isCountry == null)
                throw new ArgumentNullException(nameof(isCountry), "Property is required for class Location.");

            return new Location(id.Value, isCountry.Value, name, countryCode, localizedName);
        }

        /// <summary>
        /// Serializes a <see cref="Location" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="location"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Location location, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteNumber("id", location.Id);
            writer.WriteBoolean("isCountry", location.IsCountry);
            writer.WriteString("name", location.Name);
            writer.WriteString("countryCode", location.CountryCode);
            writer.WriteString("localizedName", location.LocalizedName);

            writer.WriteEndObject();
        }
    }
}
