﻿// <auto-generated>
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
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (reason == null)
                throw new ArgumentNullException("reason is a required property for ClientError and cannot be null.");

            if (message == null)
                throw new ArgumentNullException("message is a required property for ClientError and cannot be null.");

            if (type == null)
                throw new ArgumentNullException("type is a required property for ClientError and cannot be null.");

            if (detail == null)
                throw new ArgumentNullException("detail is a required property for ClientError and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Detail = detail;
            Message = message;
            Reason = reason;
            Type = type;
        }

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
    /// A Json converter for type ClientError
    /// </summary>
    public class ClientErrorJsonConverter : JsonConverter<ClientError>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ClientError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            Object detail = default;
            string message = default;
            string reason = default;
            string type = default;

            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName && currentDepth == reader.CurrentDepth - 1)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "detail":
                            detail = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                        case "message":
                            message = reader.GetString();
                            break;
                        case "reason":
                            reason = reader.GetString();
                            break;
                        case "type":
                            type = reader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ClientError(detail, message, reason, type);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clientError"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ClientError clientError, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("detail");
            JsonSerializer.Serialize(writer, clientError.Detail, options);
            writer.WriteString("message", clientError.Message);
            writer.WriteString("reason", clientError.Reason);
            writer.WriteString("type", clientError.Type);

            writer.WriteEndObject();
        }
    }
}
