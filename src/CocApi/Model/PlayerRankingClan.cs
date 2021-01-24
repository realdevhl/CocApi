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
    /// PlayerRankingClan
    /// </summary>
    [DataContract(Name = "PlayerRankingClan")]
    public partial class PlayerRankingClan : IEquatable<PlayerRankingClan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRankingClan" /> class.
        /// </summary>
        /// <param name="tag">tag.</param>
        /// <param name="name">name.</param>
        /// <param name="badgeUrls">badgeUrls.</param>
        public PlayerRankingClan(string tag, string name, ClanBadgeUrls badgeUrls)
        {
            Tag = tag;
            Name = name;
            BadgeUrls = badgeUrls;
        }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets BadgeUrls
        /// </summary>
        [DataMember(Name = "badgeUrls", EmitDefaultValue = false)]
        public ClanBadgeUrls BadgeUrls { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerRankingClan {\n");
            sb.Append("  Tag: ").Append(Tag).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  BadgeUrls: ").Append(BadgeUrls).Append('\n');
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
            return Equals(input as PlayerRankingClan);
        }

        /// <summary>
        /// Returns true if PlayerRankingClan instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerRankingClan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerRankingClan? input)
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
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    BadgeUrls == input.BadgeUrls ||
                    (BadgeUrls != null &&
                    BadgeUrls.Equals(input.BadgeUrls))
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

