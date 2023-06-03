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
    /// ClanWarAttack
    /// </summary>
    public partial class ClanWarAttack : IEquatable<ClanWarAttack?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanWarAttack" /> class.
        /// </summary>
        /// <param name="attackerTag">attackerTag</param>
        /// <param name="defenderTag">defenderTag</param>
        /// <param name="destructionPercentage">destructionPercentage</param>
        /// <param name="order">order</param>
        /// <param name="stars">stars</param>
        /// <param name="duration">duration</param>
        [JsonConstructor]
        internal ClanWarAttack(string attackerTag, string defenderTag, int destructionPercentage, int order, int stars, int? duration = default)
        {
            AttackerTag = attackerTag;
            DefenderTag = defenderTag;
            DestructionPercentage = destructionPercentage;
            Order = order;
            Stars = stars;
            Duration = duration;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AttackerTag
        /// </summary>
        [JsonPropertyName("attackerTag")]
        public string AttackerTag { get; }

        /// <summary>
        /// Gets or Sets DefenderTag
        /// </summary>
        [JsonPropertyName("defenderTag")]
        public string DefenderTag { get; }

        /// <summary>
        /// Gets or Sets DestructionPercentage
        /// </summary>
        [JsonPropertyName("destructionPercentage")]
        public int DestructionPercentage { get; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; }

        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [JsonPropertyName("stars")]
        public int Stars { get; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClanWarAttack {\n");
            sb.Append("  AttackerTag: ").Append(AttackerTag).Append("\n");
            sb.Append("  DefenderTag: ").Append(DefenderTag).Append("\n");
            sb.Append("  DestructionPercentage: ").Append(DestructionPercentage).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as ClanWarAttack);
        }

        /// <summary>
        /// Returns true if ClanWarAttack instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanWarAttack to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanWarAttack? input)
        {
            if (input == null)
                return false;

            return 
                (
                    AttackerTag == input.AttackerTag ||
                    (AttackerTag != null &&
                    AttackerTag.Equals(input.AttackerTag))
                ) && 
                (
                    DefenderTag == input.DefenderTag ||
                    (DefenderTag != null &&
                    DefenderTag.Equals(input.DefenderTag))
                ) && 
                (
                    DestructionPercentage == input.DestructionPercentage ||
                    DestructionPercentage.Equals(input.DestructionPercentage)
                ) && 
                (
                    Order == input.Order ||
                    Order.Equals(input.Order)
                ) && 
                (
                    Stars == input.Stars ||
                    Stars.Equals(input.Stars)
                ) && 
                (
                    Duration == input.Duration ||
                    (Duration != null &&
                    Duration.Equals(input.Duration))
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
                hashCode = (hashCode * 59) + AttackerTag.GetHashCode();
                hashCode = (hashCode * 59) + DefenderTag.GetHashCode();
                hashCode = (hashCode * 59) + DestructionPercentage.GetHashCode();
                hashCode = (hashCode * 59) + Order.GetHashCode();
                hashCode = (hashCode * 59) + Stars.GetHashCode();

                if (Duration != null)
                    hashCode = (hashCode * 59) + Duration.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ClanWarAttack" />
    /// </summary>
    public class ClanWarAttackJsonConverter : JsonConverter<ClanWarAttack>
    {
        /// <summary>
        /// Deserializes json to <see cref="ClanWarAttack" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClanWarAttack Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? attackerTag = default;
            string? defenderTag = default;
            int? destructionPercentage = default;
            int? order = default;
            int? stars = default;
            int? duration = default;

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
                        case "attackerTag":
                            attackerTag = utf8JsonReader.GetString();
                            break;
                        case "defenderTag":
                            defenderTag = utf8JsonReader.GetString();
                            break;
                        case "destructionPercentage":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                destructionPercentage = utf8JsonReader.GetInt32();
                            break;
                        case "order":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                order = utf8JsonReader.GetInt32();
                            break;
                        case "stars":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stars = utf8JsonReader.GetInt32();
                            break;
                        case "duration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                duration = utf8JsonReader.GetInt32();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (attackerTag == null)
                throw new ArgumentNullException(nameof(attackerTag), "Property is required for class ClanWarAttack.");

            if (defenderTag == null)
                throw new ArgumentNullException(nameof(defenderTag), "Property is required for class ClanWarAttack.");

            if (destructionPercentage == null)
                throw new ArgumentNullException(nameof(destructionPercentage), "Property is required for class ClanWarAttack.");

            if (order == null)
                throw new ArgumentNullException(nameof(order), "Property is required for class ClanWarAttack.");

            if (stars == null)
                throw new ArgumentNullException(nameof(stars), "Property is required for class ClanWarAttack.");

            return new ClanWarAttack(attackerTag, defenderTag, destructionPercentage.Value, order.Value, stars.Value, duration);
        }

        /// <summary>
        /// Serializes a <see cref="ClanWarAttack" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clanWarAttack"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClanWarAttack clanWarAttack, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("attackerTag", clanWarAttack.AttackerTag);
            writer.WriteString("defenderTag", clanWarAttack.DefenderTag);
            writer.WriteNumber("destructionPercentage", clanWarAttack.DestructionPercentage);
            writer.WriteNumber("order", clanWarAttack.Order);
            writer.WriteNumber("stars", clanWarAttack.Stars);

            if (clanWarAttack.Duration != null)
                writer.WriteNumber("duration", clanWarAttack.Duration.Value);
            else
                writer.WriteNull("duration");

            writer.WriteEndObject();
        }
    }
}
