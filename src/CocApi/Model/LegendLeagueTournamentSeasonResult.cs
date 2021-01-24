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
    /// LegendLeagueTournamentSeasonResult
    /// </summary>
    [DataContract(Name = "LegendLeagueTournamentSeasonResult")]
    public partial class LegendLeagueTournamentSeasonResult : IEquatable<LegendLeagueTournamentSeasonResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegendLeagueTournamentSeasonResult" /> class.
        /// </summary>
        /// <param name="trophies">trophies.</param>
        /// <param name="id">id.</param>
        /// <param name="rank">rank.</param>
        public LegendLeagueTournamentSeasonResult(int trophies, DateTime id, int rank)
        {
            Trophies = trophies;
            Id = id;
            Rank = rank;
        }

        /// <summary>
        /// Gets or Sets Trophies
        /// </summary>
        [DataMember(Name = "trophies", EmitDefaultValue = false)]
        public int Trophies { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public DateTime Id { get; private set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int Rank { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegendLeagueTournamentSeasonResult {\n");
            sb.Append("  Trophies: ").Append(Trophies).Append('\n');
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  Rank: ").Append(Rank).Append('\n');
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
            return Equals(input as LegendLeagueTournamentSeasonResult);
        }

        /// <summary>
        /// Returns true if LegendLeagueTournamentSeasonResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LegendLeagueTournamentSeasonResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegendLeagueTournamentSeasonResult? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Trophies == input.Trophies ||
                    Trophies.Equals(input.Trophies)
                ) && 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    Rank == input.Rank ||
                    Rank.Equals(input.Rank)
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

