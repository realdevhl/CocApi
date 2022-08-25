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
    /// Defines Role
    /// </summary>
    public enum Role
    {
        /// <summary>
        /// Enum Member for value: member
        /// </summary>
        Member = 0,

        /// <summary>
        /// Enum Admin for value: admin
        /// </summary>
        Elder = 10,

        /// <summary>
        /// Enum CoLeader for value: coLeader
        /// </summary>
        CoLeader = 20,

        /// <summary>
        /// Enum Leader for value: leader
        /// </summary>
        Leader = 30
    }

    public class RoleConverter : JsonConverter<Role>
    {
        public static Role FromString(string value)
        {
            if (value == "member")
                return Role.Member;

            if (value == "admin")
                return Role.Elder;

            if (value == "coLeader")
                return Role.CoLeader;

            if (value == "leader")
                return Role.Leader;

            throw new NotImplementedException($"Could not convert value to type Role: '{value}'");
        }

        public static Role? FromStringOrDefault(string value)
        {
            if (value == "member")
                return Role.Member;

            if (value == "admin")
                return Role.Elder;

            if (value == "coLeader")
                return Role.CoLeader;

            if (value == "leader")
                return Role.Leader;

            return null;
        }

        public static string ToJsonValue(Role value)
        {
            if (value == Role.Member)
                return "member";

            if (value == Role.Elder)
                return "admin";

            if (value == Role.CoLeader)
                return "coLeader";

            if (value == Role.Leader)
                return "leader";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override Role Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            Role? result = RoleConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the Role to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="role"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, Role role, JsonSerializerOptions options)
        {
            writer.WriteStringValue(role.ToString());
        }
    }

    public class RoleNullableConverter : JsonConverter<Role?>
    {
        /// <summary>
        /// Returns a Role from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override Role? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            Role? result = RoleConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="role"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, Role? role, JsonSerializerOptions options)
        {
            writer.WriteStringValue(role?.ToString() ?? "null");
        }
    }

}
