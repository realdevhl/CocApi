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
    /// Defines RecruitingType
    /// </summary>
    public enum RecruitingType
    {
        /// <summary>
        /// Enum InviteOnly for value: inviteOnly
        /// </summary>
        InviteOnly = 1,

        /// <summary>
        /// Enum Closed for value: closed
        /// </summary>
        Closed = 2,

        /// <summary>
        /// Enum Open for value: open
        /// </summary>
        Open = 3
    }

    public class RecruitingTypeConverter : JsonConverter<RecruitingType>
    {
        public static RecruitingType FromString(string value)
        {
            if (value == "inviteOnly")
                return RecruitingType.InviteOnly;

            if (value == "closed")
                return RecruitingType.Closed;

            if (value == "open")
                return RecruitingType.Open;

            throw new NotImplementedException($"Could not convert value to type RecruitingType: '{value}'");
        }

        public static RecruitingType? FromStringOrDefault(string value)
        {
            if (value == "inviteOnly")
                return RecruitingType.InviteOnly;

            if (value == "closed")
                return RecruitingType.Closed;

            if (value == "open")
                return RecruitingType.Open;

            return null;
        }

        public static string ToJsonValue(RecruitingType value)
        {
            if (value == RecruitingType.InviteOnly)
                return "inviteOnly";

            if (value == RecruitingType.Closed)
                return "closed";

            if (value == RecruitingType.Open)
                return "open";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override RecruitingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            RecruitingType? result = RecruitingTypeConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the RecruitingType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="recruitingType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, RecruitingType recruitingType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(recruitingType.ToString());
        }
    }

    public class RecruitingTypeNullableConverter : JsonConverter<RecruitingType?>
    {
        /// <summary>
        /// Returns a RecruitingType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override RecruitingType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            RecruitingType? result = RecruitingTypeConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="recruitingType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, RecruitingType? recruitingType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(recruitingType?.ToString() ?? "null");
        }
    }

}
