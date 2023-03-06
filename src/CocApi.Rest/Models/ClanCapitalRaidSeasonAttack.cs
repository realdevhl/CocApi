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
    /// ClanCapitalRaidSeasonAttack
    /// </summary>
    public partial class ClanCapitalRaidSeasonAttack : IEquatable<ClanCapitalRaidSeasonAttack?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanCapitalRaidSeasonAttack" /> class.
        /// </summary>
        /// <param name="attacker">attacker</param>
        /// <param name="destructionPercent">destructionPercent</param>
        /// <param name="stars">stars</param>
        [JsonConstructor]
        internal ClanCapitalRaidSeasonAttack(ClanCapitalRaidSeasonAttacker attacker, int destructionPercent, int stars)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (attacker == null)
                throw new ArgumentNullException("attacker is a required property for ClanCapitalRaidSeasonAttack and cannot be null.");

            if (destructionPercent == null)
                throw new ArgumentNullException("destructionPercent is a required property for ClanCapitalRaidSeasonAttack and cannot be null.");

            if (stars == null)
                throw new ArgumentNullException("stars is a required property for ClanCapitalRaidSeasonAttack and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Attacker = attacker;
            DestructionPercent = destructionPercent;
            Stars = stars;
        }

        /// <summary>
        /// Gets or Sets Attacker
        /// </summary>
        [JsonPropertyName("attacker")]
        public ClanCapitalRaidSeasonAttacker Attacker { get; }

        /// <summary>
        /// Gets or Sets DestructionPercent
        /// </summary>
        [JsonPropertyName("destructionPercent")]
        public int DestructionPercent { get; }

        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [JsonPropertyName("stars")]
        public int Stars { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClanCapitalRaidSeasonAttack {\n");
            sb.Append("  Attacker: ").Append(Attacker).Append("\n");
            sb.Append("  DestructionPercent: ").Append(DestructionPercent).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
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
            return this.Equals(input as ClanCapitalRaidSeasonAttack);
        }

        /// <summary>
        /// Returns true if ClanCapitalRaidSeasonAttack instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanCapitalRaidSeasonAttack to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanCapitalRaidSeasonAttack? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Attacker == input.Attacker ||
                    (Attacker != null &&
                    Attacker.Equals(input.Attacker))
                ) && 
                (
                    DestructionPercent == input.DestructionPercent ||
                    (DestructionPercent != null &&
                    DestructionPercent.Equals(input.DestructionPercent))
                ) && 
                (
                    Stars == input.Stars ||
                    (Stars != null &&
                    Stars.Equals(input.Stars))
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
                hashCode = (hashCode * 59) + Attacker.GetHashCode();
                hashCode = (hashCode * 59) + DestructionPercent.GetHashCode();
                hashCode = (hashCode * 59) + Stars.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type ClanCapitalRaidSeasonAttack
    /// </summary>
    public class ClanCapitalRaidSeasonAttackJsonConverter : JsonConverter<ClanCapitalRaidSeasonAttack>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClanCapitalRaidSeasonAttack Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            ClanCapitalRaidSeasonAttacker attacker = default;
            int destructionPercent = default;
            int stars = default;

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
                        case "attacker":
                            attacker = JsonSerializer.Deserialize<ClanCapitalRaidSeasonAttacker>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "destructionPercent":
                            destructionPercent = utf8JsonReader.GetInt32();
                            break;
                        case "stars":
                            stars = utf8JsonReader.GetInt32();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ClanCapitalRaidSeasonAttack(attacker, destructionPercent, stars);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clanCapitalRaidSeasonAttack"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClanCapitalRaidSeasonAttack clanCapitalRaidSeasonAttack, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("attacker");
            JsonSerializer.Serialize(writer, clanCapitalRaidSeasonAttack.Attacker, jsonSerializerOptions);
            writer.WriteNumber("destructionPercent", clanCapitalRaidSeasonAttack.DestructionPercent);
            writer.WriteNumber("stars", clanCapitalRaidSeasonAttack.Stars);

            writer.WriteEndObject();
        }
    }
}
