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
    /// LabelIconUrls
    /// </summary>
    [DataContract(Name = "Label_iconUrls")]
    public partial class LabelIconUrls : IEquatable<LabelIconUrls>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelIconUrls" /> class.
        /// </summary>
        /// <param name="tiny">tiny.</param>
        /// <param name="small">small.</param>
        /// <param name="medium">medium.</param>
        public LabelIconUrls(string tiny, string small, string medium)
        {
            Tiny = tiny;
            Small = small;
            Medium = medium;
        }

        /// <summary>
        /// Gets or Sets Tiny
        /// </summary>
        [DataMember(Name = "tiny", EmitDefaultValue = false)]
        public string Tiny { get; private set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelIconUrls {\n");
            sb.Append("  Tiny: ").Append(Tiny).Append('\n');
            sb.Append("  Small: ").Append(Small).Append('\n');
            sb.Append("  Medium: ").Append(Medium).Append('\n');
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
            return Equals(input as LabelIconUrls);
        }

        /// <summary>
        /// Returns true if LabelIconUrls instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelIconUrls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelIconUrls? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Tiny == input.Tiny ||
                    (Tiny != null &&
                    Tiny.Equals(input.Tiny))
                ) && 
                (
                    Small == input.Small ||
                    (Small != null &&
                    Small.Equals(input.Small))
                ) && 
                (
                    Medium == input.Medium ||
                    (Medium != null &&
                    Medium.Equals(input.Medium))
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

