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
    /// ClientError
    /// </summary>
    [DataContract(Name = "ClientError")]
    public partial class ClientError : IEquatable<ClientError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientError" /> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        /// <param name="message">message.</param>
        /// <param name="type">type.</param>
        /// <param name="detail">detail.</param>
        public ClientError(string reason, string message, string type, Object detail)
        {
            Reason = reason;
            Message = message;
            Type = type;
            Detail = detail;
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; private set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public Object Detail { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientError {\n");
            sb.Append("  Reason: ").Append(Reason).Append('\n');
            sb.Append("  Message: ").Append(Message).Append('\n');
            sb.Append("  Type: ").Append(Type).Append('\n');
            sb.Append("  Detail: ").Append(Detail).Append('\n');
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
            return Equals(input as ClientError);
        }

        /// <summary>
        /// Returns true if ClientError instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientError? input)
        {
            if (input == null)
                return false;

            return 
                (
                    Reason == input.Reason ||
                    (Reason != null &&
                    Reason.Equals(input.Reason))
                ) && 
                (
                    Message == input.Message ||
                    (Message != null &&
                    Message.Equals(input.Message))
                ) && 
                (
                    Type == input.Type ||
                    (Type != null &&
                    Type.Equals(input.Type))
                ) && 
                (
                    Detail == input.Detail ||
                    (Detail != null &&
                    Detail.Equals(input.Detail))
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

