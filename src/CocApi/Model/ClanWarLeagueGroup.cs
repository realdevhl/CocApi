/*
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CocApi.Client.OpenAPIDateConverter;

namespace CocApi.Model
{
    /// <summary>
    /// ClanWarLeagueGroup
    /// </summary>
    [DataContract(Name = "ClanWarLeagueGroup")]
    public partial class ClanWarLeagueGroup : IEquatable<ClanWarLeagueGroup>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Preparation for value: preparation
            /// </summary>
            [EnumMember(Value = "preparation")]
            Preparation = 1,

            /// <summary>
            /// Enum InWar for value: inWar
            /// </summary>
            [EnumMember(Value = "inWar")]
            InWar = 2,

            /// <summary>
            /// Enum Ended for value: ended
            /// </summary>
            [EnumMember(Value = "ended")]
            Ended = 3

        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public GroupState? State { get; private set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanWarLeagueGroup" /> class.
        /// </summary>
        /// <param name="tag">tag.</param>
        /// <param name="state">state.</param>
        /// <param name="season">season.</param>
        /// <param name="clans">clans.</param>
        /// <param name="rounds">rounds.</param>
        public ClanWarLeagueGroup(string tag = default(string), GroupState? state = default(GroupState?), DateTime season = default(DateTime), List<ClanWarLeagueClan> clans = default(List<ClanWarLeagueClan>), List<ClanWarLeagueRound> rounds = default(List<ClanWarLeagueRound>))
        {
            Tag = tag;
            State = state;
            Season = season;
            Clans = clans;
            Rounds = rounds;
        }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; private set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        public DateTime Season { get; private set; }

        /// <summary>
        /// Gets or Sets Clans
        /// </summary>
        [DataMember(Name = "clans", EmitDefaultValue = false)]
        public List<ClanWarLeagueClan> Clans { get; private set; }

        /// <summary>
        /// Gets or Sets Rounds
        /// </summary>
        [DataMember(Name = "rounds", EmitDefaultValue = false)]
        public List<ClanWarLeagueRound> Rounds { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClanWarLeagueGroup {\n");
            sb.Append("  Tag: ").Append(Tag).Append('\n');
            sb.Append("  State: ").Append(State).Append('\n');
            sb.Append("  Season: ").Append(Season).Append('\n');
            sb.Append("  Clans: ").Append(Clans).Append('\n');
            sb.Append("  Rounds: ").Append(Rounds).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson(Newtonsoft.Json.JsonSerializerSettings? jsonSerializerSettings = null)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, jsonSerializerSettings ?? CocApi.Client.ClientUtils.JsonSerializerSettings);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return Equals(input as ClanWarLeagueGroup);
        }

        /// <summary>
        /// Returns true if ClanWarLeagueGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanWarLeagueGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanWarLeagueGroup? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Tag == input.Tag ||
                    (Tag != null &&
                    Tag.Equals(input.Tag))
                ) && 
                (
                    State == input.State ||
                    State.Equals(input.State)
                ) && 
                (
                    Season == input.Season ||
                    (Season != null &&
                    Season.Equals(input.Season))
                ) && 
                (
                    Clans == input.Clans ||
                    Clans != null &&
                    input.Clans != null &&
                    Clans.SequenceEqual(input.Clans)
                ) && 
                (
                    Rounds == input.Rounds ||
                    Rounds != null &&
                    input.Rounds != null &&
                    Rounds.SequenceEqual(input.Rounds)
                );
        }

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

