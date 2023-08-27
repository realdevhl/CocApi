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
    /// PlayerItemLevel
    /// </summary>
    public partial class PlayerItemLevel : IEquatable<PlayerItemLevel?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerItemLevel" /> class.
        /// </summary>
        /// <param name="level">level</param>
        /// <param name="maxLevel">maxLevel</param>
        /// <param name="name">name</param>
        /// <param name="village">village</param>
        /// <param name="superTroopIsActive">superTroopIsActive</param>
        [JsonConstructor]
        internal PlayerItemLevel(int level, int maxLevel, string name, VillageType village, bool? superTroopIsActive = default)
        {
            Level = level;
            MaxLevel = maxLevel;
            Name = name;
            Village = village;
            SuperTroopIsActive = superTroopIsActive;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Village
        /// </summary>
        [JsonPropertyName("village")]
        public VillageType Village { get; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; }

        /// <summary>
        /// Gets or Sets MaxLevel
        /// </summary>
        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or Sets SuperTroopIsActive
        /// </summary>
        [JsonPropertyName("superTroopIsActive")]
        public bool? SuperTroopIsActive { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerItemLevel {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  MaxLevel: ").Append(MaxLevel).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Village: ").Append(Village).Append("\n");
            sb.Append("  SuperTroopIsActive: ").Append(SuperTroopIsActive).Append("\n");
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
            return this.Equals(input as PlayerItemLevel);
        }

        /// <summary>
        /// Returns true if PlayerItemLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerItemLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerItemLevel? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Level == input.Level ||
                    Level.Equals(input.Level)
                ) && 
                (
                    MaxLevel == input.MaxLevel ||
                    MaxLevel.Equals(input.MaxLevel)
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Village == input.Village ||
                    Village.Equals(input.Village)
                ) && 
                (
                    SuperTroopIsActive == input.SuperTroopIsActive ||
                    SuperTroopIsActive.Equals(input.SuperTroopIsActive)
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
                hashCode = (hashCode * 59) + Level.GetHashCode();
                hashCode = (hashCode * 59) + MaxLevel.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + Village.GetHashCode();

                if (SuperTroopIsActive != null)
                    hashCode = (hashCode * 59) + SuperTroopIsActive.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PlayerItemLevel" />
    /// </summary>
    public class PlayerItemLevelJsonConverter : JsonConverter<PlayerItemLevel>
    {
        /// <summary>
        /// Deserializes json to <see cref="PlayerItemLevel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerItemLevel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            int? level = default;
            int? maxLevel = default;
            string? name = default;
            VillageType? village = default;
            bool? superTroopIsActive = default;

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
                        case "level":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                level = utf8JsonReader.GetInt32();
                            break;
                        case "maxLevel":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                maxLevel = utf8JsonReader.GetInt32();
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "village":
                            string? villageRawValue = utf8JsonReader.GetString();
                            village = villageRawValue == null
                                ? null
                                : VillageTypeValueConverter.FromStringOrDefault(villageRawValue);
                            break;
                        case "superTroopIsActive":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                superTroopIsActive = utf8JsonReader.GetBoolean();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (level == null)
                throw new ArgumentNullException(nameof(level), "Property is required for class PlayerItemLevel.");

            if (maxLevel == null)
                throw new ArgumentNullException(nameof(maxLevel), "Property is required for class PlayerItemLevel.");

            if (name == null)
                throw new ArgumentNullException(nameof(name), "Property is required for class PlayerItemLevel.");

            if (village == null)
                throw new ArgumentNullException(nameof(village), "Property is required for class PlayerItemLevel.");

            return new PlayerItemLevel(level.Value, maxLevel.Value, name, village.Value, superTroopIsActive);
        }

        /// <summary>
        /// Serializes a <see cref="PlayerItemLevel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerItemLevel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerItemLevel playerItemLevel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, playerItemLevel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PlayerItemLevel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerItemLevel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PlayerItemLevel playerItemLevel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("level", playerItemLevel.Level);
            writer.WriteNumber("maxLevel", playerItemLevel.MaxLevel);
            writer.WriteString("name", playerItemLevel.Name);
            var villageRawValue = VillageTypeValueConverter.ToJsonValue(playerItemLevel.Village);

            if (villageRawValue != null)
                writer.WriteString("village", villageRawValue);
            else
                writer.WriteNull("village");

            if (playerItemLevel.SuperTroopIsActive != null)
                writer.WriteBoolean("superTroopIsActive", playerItemLevel.SuperTroopIsActive.Value);
            else
                writer.WriteNull("superTroopIsActive");
        }
    }
}
