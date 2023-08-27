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
    /// ClientError
    /// </summary>
    public partial class ClientError : IEquatable<ClientError?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientError" /> class.
        /// </summary>
        /// <param name="detail">detail</param>
        /// <param name="message">message</param>
        /// <param name="reason">reason</param>
        /// <param name="type">type</param>
        [JsonConstructor]
        internal ClientError(Object detail, string message, string reason, string type)
        {
            Detail = detail;
            Message = message;
            Reason = reason;
            Type = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [JsonPropertyName("detail")]
        public Object Detail { get; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientError {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ClientError);
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
                    Detail == input.Detail ||
                    (Detail != null &&
                    Detail.Equals(input.Detail))
                ) && 
                (
                    Message == input.Message ||
                    (Message != null &&
                    Message.Equals(input.Message))
                ) && 
                (
                    Reason == input.Reason ||
                    (Reason != null &&
                    Reason.Equals(input.Reason))
                ) && 
                (
                    Type == input.Type ||
                    (Type != null &&
                    Type.Equals(input.Type))
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
                hashCode = (hashCode * 59) + Detail.GetHashCode();
                hashCode = (hashCode * 59) + Message.GetHashCode();
                hashCode = (hashCode * 59) + Reason.GetHashCode();
                hashCode = (hashCode * 59) + Type.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ClientError" />
    /// </summary>
    public class ClientErrorJsonConverter : JsonConverter<ClientError>
    {
        /// <summary>
        /// Deserializes json to <see cref="ClientError" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClientError Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Object? detail = default;
            string? message = default;
            string? reason = default;
            string? type = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "detail":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                detail = JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "message":
                            message = utf8JsonReader.GetString();
                            break;
                        case "reason":
                            reason = utf8JsonReader.GetString();
                            break;
                        case "type":
                            type = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (detail == null)
                throw new ArgumentNullException(nameof(detail), "Property is required for class ClientError.");

            if (message == null)
                throw new ArgumentNullException(nameof(message), "Property is required for class ClientError.");

            if (reason == null)
                throw new ArgumentNullException(nameof(reason), "Property is required for class ClientError.");

            if (type == null)
                throw new ArgumentNullException(nameof(type), "Property is required for class ClientError.");

            return new ClientError(detail, message, reason, type);
        }

        /// <summary>
        /// Serializes a <see cref="ClientError" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientError"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClientError clientError, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, clientError, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ClientError" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientError"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ClientError clientError, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WritePropertyName("detail");
            JsonSerializer.Serialize(writer, clientError.Detail, jsonSerializerOptions);
            writer.WriteString("message", clientError.Message);
            writer.WriteString("reason", clientError.Reason);
            writer.WriteString("type", clientError.Type);
        }
    }
}
