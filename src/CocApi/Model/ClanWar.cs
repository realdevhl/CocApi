/* 
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CocApi.Client.OpenAPIDateConverter;

namespace CocApi.Model
{
/// <summary>
    /// ClanWar
    /// </summary>
    [DataContract]
    public partial class ClanWar :  IEquatable<ClanWar>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum NotInWar for value: notInWar
            /// </summary>
            [EnumMember(Value = "notInWar")]
            NotInWar = 1,

            /// <summary>
            /// Enum Preparation for value: preparation
            /// </summary>
            [EnumMember(Value = "preparation")]
            Preparation = 2,

            /// <summary>
            /// Enum InWar for value: inWar
            /// </summary>
            [EnumMember(Value = "inWar")]
            InWar = 3,

            /// <summary>
            /// Enum WarEnded for value: warEnded
            /// </summary>
            [EnumMember(Value = "warEnded")]
            WarEnded = 4

        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanWar" /> class.
        /// </summary>
        /// <param name="clan">clan.</param>
        /// <param name="teamSize">teamSize.</param>
        /// <param name="opponent">opponent.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="state">state.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="preparationStartTime">preparationStartTime.</param>
        public ClanWar(WarClan clan = default(WarClan), int teamSize = default(int), WarClan opponent = default(WarClan), DateTime startTime = default(DateTime), StateEnum? state = default(StateEnum?), DateTime endTime = default(DateTime), DateTime preparationStartTime = default(DateTime))
        {
            this.Clan = clan;
            this.TeamSize = teamSize;
            this.Opponent = opponent;
            this.StartTime = startTime;
            this.State = state;
            this.EndTime = endTime;
            this.PreparationStartTime = preparationStartTime;
        }
        
        /// <summary>
        /// Gets or Sets Clan
        /// </summary>
        [DataMember(Name="clan", EmitDefaultValue=false)]
        public WarClan Clan { get; set; }

        /// <summary>
        /// Gets or Sets TeamSize
        /// </summary>
        [DataMember(Name="teamSize", EmitDefaultValue=false)]
        public int TeamSize { get; set; }

        /// <summary>
        /// Gets or Sets Opponent
        /// </summary>
        [DataMember(Name="opponent", EmitDefaultValue=false)]
        public WarClan Opponent { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or Sets PreparationStartTime
        /// </summary>
        [DataMember(Name="preparationStartTime", EmitDefaultValue=false)]
        public DateTime PreparationStartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClanWar {\n");
            sb.Append("  Clan: ").Append(Clan).Append("\n");
            sb.Append("  TeamSize: ").Append(TeamSize).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  PreparationStartTime: ").Append(PreparationStartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClanWar);
        }

        /// <summary>
        /// Returns true if ClanWar instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanWar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanWar input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Clan == input.Clan ||
                    (this.Clan != null &&
                    this.Clan.Equals(input.Clan))
                ) && 
                (
                    this.TeamSize == input.TeamSize ||
                    this.TeamSize.Equals(input.TeamSize)
                ) && 
                (
                    this.Opponent == input.Opponent ||
                    (this.Opponent != null &&
                    this.Opponent.Equals(input.Opponent))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.PreparationStartTime == input.PreparationStartTime ||
                    (this.PreparationStartTime != null &&
                    this.PreparationStartTime.Equals(input.PreparationStartTime))
                );
        }

        ///// <summary>
        ///// Gets the hash code
        ///// </summary>
        ///// <returns>Hash code</returns>
        //public override int GetHashCode()
        //{
        //    unchecked // Overflow is fine, just wrap
        //    {
        //        int hashCode = 41;
        //        return hashCode;
        //    }
        //}

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
