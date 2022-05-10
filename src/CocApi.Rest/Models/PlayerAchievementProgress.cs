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
    /// PlayerAchievementProgress
    /// </summary>
    public partial class PlayerAchievementProgress : IEquatable<PlayerAchievementProgress?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerAchievementProgress" /> class.
        /// </summary>
        /// <param name="info">info</param>
        /// <param name="name">name</param>
        /// <param name="stars">stars</param>
        /// <param name="target">target</param>
        /// <param name="value">value</param>
        /// <param name="village">village</param>
        /// <param name="completionInfo">completionInfo</param>
        [JsonConstructor]
        internal PlayerAchievementProgress(string info, string name, int stars, int target, int value, string village, string? completionInfo = default)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (stars == null)
                throw new ArgumentNullException("stars is a required property for PlayerAchievementProgress and cannot be null.");

            if (value == null)
                throw new ArgumentNullException("value is a required property for PlayerAchievementProgress and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for PlayerAchievementProgress and cannot be null.");

            if (target == null)
                throw new ArgumentNullException("target is a required property for PlayerAchievementProgress and cannot be null.");

            if (info == null)
                throw new ArgumentNullException("info is a required property for PlayerAchievementProgress and cannot be null.");

            if (village == null)
                throw new ArgumentNullException("village is a required property for PlayerAchievementProgress and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Info = info;
            Name = name;
            Stars = stars;
            Target = target;
            Value = value;
            Village = village;
            CompletionInfo = completionInfo;
        }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; }

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
        /// Gets or Sets Target
        /// </summary>
        [JsonPropertyName("target")]
        public int Target { get; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; }

        /// <summary>
        /// Gets or Sets Village
        /// </summary>
        [JsonPropertyName("village")]
        public string Village { get; }

        /// <summary>
        /// Gets or Sets CompletionInfo
        /// </summary>
        [JsonPropertyName("completionInfo")]
        public string? CompletionInfo { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerAchievementProgress {\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Village: ").Append(Village).Append("\n");
            sb.Append("  CompletionInfo: ").Append(CompletionInfo).Append("\n");
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
            return this.Equals(input as PlayerAchievementProgress);
        }

        /// <summary>
        /// Returns true if PlayerAchievementProgress instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerAchievementProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerAchievementProgress? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Info == input.Info ||
                    (Info != null &&
                    Info.Equals(input.Info))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Stars == input.Stars ||
                    (Stars != null &&
                    Stars.Equals(input.Stars))
                ) && 
                (
                    Target == input.Target ||
                    (Target != null &&
                    Target.Equals(input.Target))
                ) && 
                (
                    Value == input.Value ||
                    (Value != null &&
                    Value.Equals(input.Value))
                ) && 
                (
                    Village == input.Village ||
                    (Village != null &&
                    Village.Equals(input.Village))
                ) && 
                (
                    CompletionInfo == input.CompletionInfo ||
                    (CompletionInfo != null &&
                    CompletionInfo.Equals(input.CompletionInfo))
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
                hashCode = (hashCode * 59) + Info.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + Stars.GetHashCode();
                hashCode = (hashCode * 59) + Target.GetHashCode();
                hashCode = (hashCode * 59) + Value.GetHashCode();
                hashCode = (hashCode * 59) + Village.GetHashCode();

                if (CompletionInfo != null)
                    hashCode = (hashCode * 59) + CompletionInfo.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type PlayerAchievementProgress
    /// </summary>
    public class PlayerAchievementProgressJsonConverter : JsonConverter<PlayerAchievementProgress>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PlayerAchievementProgress Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            string info = default;
            string name = default;
            int stars = default;
            int target = default;
            int value = default;
            string village = default;
            string completionInfo = default;

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
                        case "info":
                            info = reader.GetString();
                            break;
                        case "name":
                            name = reader.GetString();
                            break;
                        case "stars":
                            stars = reader.GetInt32();
                            break;
                        case "target":
                            target = reader.GetInt32();
                            break;
                        case "value":
                            value = reader.GetInt32();
                            break;
                        case "village":
                            village = reader.GetString();
                            break;
                        case "completionInfo":
                            Utf8JsonReader completionInfoReader = reader;
                            completionInfo = JsonSerializer.Deserialize<string>(ref reader, options);
                            break;
                    }
                }
            }

            return new PlayerAchievementProgress(info, name, stars, target, value, village, completionInfo);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="playerAchievementProgress"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PlayerAchievementProgress playerAchievementProgress, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("info", playerAchievementProgress.Info);
            writer.WriteString("name", playerAchievementProgress.Name);
            writer.WriteNumber("stars", (int)playerAchievementProgress.Stars);
            writer.WriteNumber("target", (int)playerAchievementProgress.Target);
            writer.WriteNumber("value", (int)playerAchievementProgress.Value);
            writer.WriteString("village", playerAchievementProgress.Village);
            writer.WritePropertyName("completionInfo");
            JsonSerializer.Serialize(writer, playerAchievementProgress.CompletionInfo, options);

            writer.WriteEndObject();
        }
    }
}

