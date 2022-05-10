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
    /// ClanWar
    /// </summary>
    public partial class ClanWar : IEquatable<ClanWar?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanWar" /> class.
        /// </summary>
        /// <param name="attacksPerMember">attacksPerMember</param>
        /// <param name="clan">clan</param>
        /// <param name="endTime">endTime</param>
        /// <param name="opponent">opponent</param>
        /// <param name="preparationStartTime">preparationStartTime</param>
        /// <param name="startTime">startTime</param>
        /// <param name="teamSize">teamSize</param>
        /// <param name="state">state</param>
        [JsonConstructor]
        internal ClanWar(int attacksPerMember, WarClan clan, DateTime endTime, WarClan opponent, DateTime preparationStartTime, DateTime startTime, int teamSize, WarState? state = default)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (clan == null)
                throw new ArgumentNullException("clan is a required property for ClanWar and cannot be null.");

            if (teamSize == null)
                throw new ArgumentNullException("teamSize is a required property for ClanWar and cannot be null.");

            if (attacksPerMember == null)
                throw new ArgumentNullException("attacksPerMember is a required property for ClanWar and cannot be null.");

            if (opponent == null)
                throw new ArgumentNullException("opponent is a required property for ClanWar and cannot be null.");

            if (startTime == null)
                throw new ArgumentNullException("startTime is a required property for ClanWar and cannot be null.");

            if (endTime == null)
                throw new ArgumentNullException("endTime is a required property for ClanWar and cannot be null.");

            if (preparationStartTime == null)
                throw new ArgumentNullException("preparationStartTime is a required property for ClanWar and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            AttacksPerMember = attacksPerMember;
            Clan = clan;
            EndTime = endTime;
            Opponent = opponent;
            PreparationStartTime = preparationStartTime;
            StartTime = startTime;
            TeamSize = teamSize;
            State = state;
            Initialize();
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonPropertyName("state")]
        public WarState? State { get; }

        /// <summary>
        /// Gets or Sets AttacksPerMember
        /// </summary>
        [JsonPropertyName("attacksPerMember")]
        public int AttacksPerMember { get; }

        /// <summary>
        /// Gets or Sets Clan
        /// </summary>
        [JsonPropertyName("clan")]
        public WarClan Clan { get; private set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; }

        /// <summary>
        /// Gets or Sets Opponent
        /// </summary>
        [JsonPropertyName("opponent")]
        public WarClan Opponent { get; private set; }

        /// <summary>
        /// Gets or Sets PreparationStartTime
        /// </summary>
        [JsonPropertyName("preparationStartTime")]
        public DateTime PreparationStartTime { get; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; }

        /// <summary>
        /// Gets or Sets TeamSize
        /// </summary>
        [JsonPropertyName("teamSize")]
        public int TeamSize { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClanWar {\n");
            sb.Append("  AttacksPerMember: ").Append(AttacksPerMember).Append("\n");
            sb.Append("  Clan: ").Append(Clan).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
            sb.Append("  PreparationStartTime: ").Append(PreparationStartTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  TeamSize: ").Append(TeamSize).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as ClanWar);
        }

        /// <summary>
        /// Returns true if ClanWar instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanWar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanWar? input)
        {
            if (input == null)
                return false;

            return 
                (
                    AttacksPerMember == input.AttacksPerMember ||
                    (AttacksPerMember != null &&
                    AttacksPerMember.Equals(input.AttacksPerMember))
                ) && 
                (
                    Clan == input.Clan ||
                    (Clan != null &&
                    Clan.Equals(input.Clan))
                ) && 
                (
                    EndTime == input.EndTime ||
                    (EndTime != null &&
                    EndTime.Equals(input.EndTime))
                ) && 
                (
                    Opponent == input.Opponent ||
                    (Opponent != null &&
                    Opponent.Equals(input.Opponent))
                ) && 
                (
                    PreparationStartTime == input.PreparationStartTime ||
                    (PreparationStartTime != null &&
                    PreparationStartTime.Equals(input.PreparationStartTime))
                ) && 
                (
                    StartTime == input.StartTime ||
                    (StartTime != null &&
                    StartTime.Equals(input.StartTime))
                ) && 
                (
                    TeamSize == input.TeamSize ||
                    (TeamSize != null &&
                    TeamSize.Equals(input.TeamSize))
                ) && 
                (
                    State == input.State ||
                    (State != null &&
                    State.Equals(input.State))
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
                hashCode = (hashCode * 59) + AttacksPerMember.GetHashCode();
                hashCode = (hashCode * 59) + Clan.GetHashCode();
                hashCode = (hashCode * 59) + EndTime.GetHashCode();
                hashCode = (hashCode * 59) + Opponent.GetHashCode();
                hashCode = (hashCode * 59) + PreparationStartTime.GetHashCode();
                hashCode = (hashCode * 59) + StartTime.GetHashCode();
                hashCode = (hashCode * 59) + TeamSize.GetHashCode();

                if (State != null)
                    hashCode = (hashCode * 59) + State.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type ClanWar
    /// </summary>
    public class ClanWarJsonConverter : JsonConverter<ClanWar>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClanWar Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            int attacksPerMember = default;
            WarClan clan = default;
            DateTime endTime = default;
            WarClan opponent = default;
            DateTime preparationStartTime = default;
            DateTime startTime = default;
            int teamSize = default;
            WarState? state = default;

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
                        case "attacksPerMember":
                            attacksPerMember = reader.GetInt32();
                            break;
                        case "clan":
                            Utf8JsonReader clanReader = reader;
                            clan = JsonSerializer.Deserialize<WarClan>(ref reader, options);
                            break;
                        case "endTime":
                            Utf8JsonReader endTimeReader = reader;
                            endTime = JsonSerializer.Deserialize<DateTime>(ref reader, options);
                            break;
                        case "opponent":
                            Utf8JsonReader opponentReader = reader;
                            opponent = JsonSerializer.Deserialize<WarClan>(ref reader, options);
                            break;
                        case "preparationStartTime":
                            Utf8JsonReader preparationStartTimeReader = reader;
                            preparationStartTime = JsonSerializer.Deserialize<DateTime>(ref reader, options);
                            break;
                        case "startTime":
                            Utf8JsonReader startTimeReader = reader;
                            startTime = JsonSerializer.Deserialize<DateTime>(ref reader, options);
                            break;
                        case "teamSize":
                            teamSize = reader.GetInt32();
                            break;
                        case "state":
                            string stateRawValue = reader.GetString();
                            state = WarStateConverter.FromString(stateRawValue);
                            break;
                    }
                }
            }

            return new ClanWar(attacksPerMember, clan, endTime, opponent, preparationStartTime, startTime, teamSize, state);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clanWar"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClanWar clanWar, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteNumber("attacksPerMember", (int)clanWar.AttacksPerMember);
            writer.WritePropertyName("clan");
            JsonSerializer.Serialize(writer, clanWar.Clan, options);
            writer.WritePropertyName("endTime");
            JsonSerializer.Serialize(writer, clanWar.EndTime, options);
            writer.WritePropertyName("opponent");
            JsonSerializer.Serialize(writer, clanWar.Opponent, options);
            writer.WritePropertyName("preparationStartTime");
            JsonSerializer.Serialize(writer, clanWar.PreparationStartTime, options);
            writer.WritePropertyName("startTime");
            JsonSerializer.Serialize(writer, clanWar.StartTime, options);
            writer.WriteNumber("teamSize", (int)clanWar.TeamSize);
            if (clanWar.State == null)
                writer.WriteNull("state");
            var stateRawValue = WarStateConverter.ToJsonValue(clanWar.State.Value);
            if (stateRawValue != null)
                writer.WriteString("state", stateRawValue);
            else
                writer.WriteNull("state");

            writer.WriteEndObject();
        }
    }
}

