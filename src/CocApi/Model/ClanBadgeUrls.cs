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
    /// ClanBadgeUrls
    /// </summary>
    [DataContract(Name = "Clan_badgeUrls")]
    public partial class ClanBadgeUrls : IEquatable<ClanBadgeUrls>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClanBadgeUrls" /> class.
        /// </summary>
        /// <param name="small">small.</param>
        /// <param name="medium">medium.</param>
        /// <param name="large">large.</param>
        public ClanBadgeUrls(string small, string medium, string large)
        {
            Small = small;
            Medium = medium;
            Large = large;
        }

        /// <summary>
        /// Gets or Sets Small
        /// </summary>
        [DataMember(Name = "small", EmitDefaultValue = false)]
        public string Small { get; private set; }

        /// <summary>
        /// Gets or Sets Medium
        /// </summary>
        [DataMember(Name = "medium", EmitDefaultValue = false)]
        public string Medium { get; private set; }

        /// <summary>
        /// Gets or Sets Large
        /// </summary>
        [DataMember(Name = "large", EmitDefaultValue = false)]
        public string Large { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClanBadgeUrls {\n");
            sb.Append("  Small: ").Append(Small).Append('\n');
            sb.Append("  Medium: ").Append(Medium).Append('\n');
            sb.Append("  Large: ").Append(Large).Append('\n');
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
            return Equals(input as ClanBadgeUrls);
        }

        /// <summary>
        /// Returns true if ClanBadgeUrls instances are equal
        /// </summary>
        /// <param name="input">Instance of ClanBadgeUrls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClanBadgeUrls? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Small == input.Small ||
                    (Small != null &&
                    Small.Equals(input.Small))
                ) && 
                (
                    Medium == input.Medium ||
                    (Medium != null &&
                    Medium.Equals(input.Medium))
                ) && 
                (
                    Large == input.Large ||
                    (Large != null &&
                    Large.Equals(input.Large))
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

