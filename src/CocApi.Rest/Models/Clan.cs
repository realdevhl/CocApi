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
    /// Clan
    /// </summary>
    public partial class Clan : IEquatable<Clan?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clan" /> class.
        /// </summary>
        /// <param name="badgeUrls">badgeUrls</param>
        /// <param name="clanLevel">clanLevel</param>
        /// <param name="clanPoints">clanPoints</param>
        /// <param name="clanVersusPoints">clanVersusPoints</param>
        /// <param name="description">description</param>
        /// <param name="isWarLogPublic">isWarLogPublic</param>
        /// <param name="labels">labels</param>
        /// <param name="memberList">memberList</param>
        /// <param name="members">members</param>
        /// <param name="name">name</param>
        /// <param name="requiredTrophies">requiredTrophies</param>
        /// <param name="tag">tag</param>
        /// <param name="warLeague">warLeague</param>
        /// <param name="warWinStreak">warWinStreak</param>
        /// <param name="warWins">warWins</param>
        /// <param name="chatLanguage">chatLanguage</param>
        /// <param name="location">location</param>
        /// <param name="type">type</param>
        /// <param name="warFrequency">warFrequency</param>
        /// <param name="warLosses">warLosses</param>
        /// <param name="warTies">warTies</param>
        [JsonConstructor]
        internal Clan(BadgeUrls badgeUrls, int clanLevel, int clanPoints, int clanVersusPoints, string description, bool isWarLogPublic, List<Label> labels, List<ClanMember> memberList, int string name, int requiredTrophies, string tag, WarLeague warLeague, int warWinStreak, int warWins, Language? chatLanguage = default, Location? location = default, RecruitingType? type = default, WarFrequency? warFrequency = default, int? warLosses = default, int? warTies = default)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (warLeague == null)
                throw new ArgumentNullException("warLeague is a required property for Clan and cannot be null.");

            if (memberList == null)
                throw new ArgumentNullException("memberList is a required property for Clan and cannot be null.");

            if (requiredTrophies == null)
                throw new ArgumentNullException("requiredTrophies is a required property for Clan and cannot be null.");

            if (clanVersusPoints == null)
                throw new ArgumentNullException("clanVersusPoints is a required property for Clan and cannot be null.");

            if (tag == null)
                throw new ArgumentNullException("tag is a required property for Clan and cannot be null.");

            if (isWarLogPublic == null)
                throw new ArgumentNullException("isWarLogPublic is a required property for Clan and cannot be null.");

            if (clanLevel == null)
                throw new ArgumentNullException("clanLevel is a required property for Clan and cannot be null.");

            if (warWinStreak == null)
                throw new ArgumentNullException("warWinStreak is a required property for Clan and cannot be null.");

            if (warWins == null)
                throw new ArgumentNullException("warWins is a required property for Clan and cannot be null.");

            if (clanPoints == null)
                throw new ArgumentNullException("clanPoints is a required property for Clan and cannot be null.");

            if (labels == null)
                throw new ArgumentNullException("labels is a required property for Clan and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for Clan and cannot be null.");

            if (members == null)
                throw new ArgumentNullException("members is a required property for Clan and cannot be null.");

            if (description == null)
                throw new ArgumentNullException("description is a required property for Clan and cannot be null.");

            if (badgeUrls == null)
                throw new ArgumentNullException("badgeUrls is a required property for Clan and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            BadgeUrls = badgeUrls;
            ClanLevel = clanLevel;
            ClanPoints = clanPoints;
            ClanVersusPoints = clanVersusPoints;
            Description = description;
            IsWarLogPublic = isWarLogPublic;
            Labels = labels;
            MemberList = memberList;
            Members = members;
            Name = name;
            RequiredTrophies = requiredTrophies;
            Tag = tag;
            WarLeague = warLeague;
            WarWinStreak = warWinStreak;
            WarWins = warWins;
            ChatLanguage = chatLanguage;
            Location = location;
            Type = type;
            WarFrequency = warFrequency;
            WarLosses = warLosses;
            WarTies = warTies;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public RecruitingType? Type { get; }

        /// <summary>
        /// Gets or Sets WarFrequency
        /// </summary>
        [JsonPropertyName("warFrequency")]
        public WarFrequency? WarFrequency { get; }

        /// <summary>
        /// Gets or Sets BadgeUrls
        /// </summary>
        [JsonPropertyName("badgeUrls")]
        public BadgeUrls BadgeUrls { get; }

        /// <summary>
        /// Gets or Sets ClanLevel
        /// </summary>
        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; }

        /// <summary>
        /// Gets or Sets ClanPoints
        /// </summary>
        [JsonPropertyName("clanPoints")]
        public int ClanPoints { get; }

        /// <summary>
        /// Gets or Sets ClanVersusPoints
        /// </summary>
        [JsonPropertyName("clanVersusPoints")]
        public int ClanVersusPoints { get; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// Gets or Sets IsWarLogPublic
        /// </summary>
        [JsonPropertyName("isWarLogPublic")]
        public bool IsWarLogPublic { get; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [JsonPropertyName("labels")]
        public List<Label> Labels { get; }

        /// <summary>
        /// Gets or Sets MemberList
        /// </summary>
        [JsonPropertyName("memberList")]
        public List<ClanMember> MemberList { get; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [JsonPropertyName("members")]
        public int Members { get; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// Gets or Sets RequiredTrophies
        /// </summary>
        [JsonPropertyName("requiredTrophies")]
        public int RequiredTrophies { get; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; }

        /// <summary>
        /// Gets or Sets WarLeague
        /// </summary>
        [JsonPropertyName("warLeague")]
        public WarLeague WarLeague { get; }

        /// <summary>
        /// Gets or Sets WarWinStreak
        /// </summary>
        [JsonPropertyName("warWinStreak")]
        public int WarWinStreak { get; }

        /// <summary>
        /// Gets or Sets WarWins
        /// </summary>
        [JsonPropertyName("warWins")]
        public int WarWins { get; }

        /// <summary>
        /// Gets or Sets ChatLanguage
        /// </summary>
        [JsonPropertyName("chatLanguage")]
        public Language? ChatLanguage { get; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public Location? Location { get; }

        /// <summary>
        /// Gets or Sets WarLosses
        /// </summary>
        [JsonPropertyName("warLosses")]
        public int? WarLosses { get; }

        /// <summary>
        /// Gets or Sets WarTies
        /// </summary>
        [JsonPropertyName("warTies")]
        public int? WarTies { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Clan {\n");
            sb.Append("  BadgeUrls: ").Append(BadgeUrls).Append("\n");
            sb.Append("  ClanLevel: ").Append(ClanLevel).Append("\n");
            sb.Append("  ClanPoints: ").Append(ClanPoints).Append("\n");
            sb.Append("  ClanVersusPoints: ").Append(ClanVersusPoints).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsWarLogPublic: ").Append(IsWarLogPublic).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  MemberList: ").Append(MemberList).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequiredTrophies: ").Append(RequiredTrophies).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  WarLeague: ").Append(WarLeague).Append("\n");
            sb.Append("  WarWinStreak: ").Append(WarWinStreak).Append("\n");
            sb.Append("  WarWins: ").Append(WarWins).Append("\n");
            sb.Append("  ChatLanguage: ").Append(ChatLanguage).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WarFrequency: ").Append(WarFrequency).Append("\n");
            sb.Append("  WarLosses: ").Append(WarLosses).Append("\n");
            sb.Append("  WarTies: ").Append(WarTies).Append("\n");
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
            return this.Equals(input as Clan);
        }

        /// <summary>
        /// Returns true if Clan instances are equal
        /// </summary>
        /// <param name="input">Instance of Clan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Clan? input)
        {
            if (input == null)
                return false;

            return 
                (
                    BadgeUrls == input.BadgeUrls ||
                    (BadgeUrls != null &&
                    BadgeUrls.Equals(input.BadgeUrls))
                ) && 
                (
                    ClanLevel == input.ClanLevel ||
                    (ClanLevel != null &&
                    ClanLevel.Equals(input.ClanLevel))
                ) && 
                (
                    ClanPoints == input.ClanPoints ||
                    (ClanPoints != null &&
                    ClanPoints.Equals(input.ClanPoints))
                ) && 
                (
                    ClanVersusPoints == input.ClanVersusPoints ||
                    (ClanVersusPoints != null &&
                    ClanVersusPoints.Equals(input.ClanVersusPoints))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    IsWarLogPublic == input.IsWarLogPublic ||
                    (IsWarLogPublic != null &&
                    IsWarLogPublic.Equals(input.IsWarLogPublic))
                ) && 
                (
                    Labels == input.Labels ||
                    Labels != null &&
                    input.Labels != null &&
                    Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    MemberList == input.MemberList ||
                    MemberList != null &&
                    input.MemberList != null &&
                    MemberList.SequenceEqual(input.MemberList)
                ) && 
                (
                    Members == input.Members ||
                    (Members != null &&
                    Members.Equals(input.Members))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    RequiredTrophies == input.RequiredTrophies ||
                    (RequiredTrophies != null &&
                    RequiredTrophies.Equals(input.RequiredTrophies))
                ) && 
                (
                    Tag == input.Tag ||
                    (Tag != null &&
                    Tag.Equals(input.Tag))
                ) && 
                (
                    WarLeague == input.WarLeague ||
                    (WarLeague != null &&
                    WarLeague.Equals(input.WarLeague))
                ) && 
                (
                    WarWinStreak == input.WarWinStreak ||
                    (WarWinStreak != null &&
                    WarWinStreak.Equals(input.WarWinStreak))
                ) && 
                (
                    WarWins == input.WarWins ||
                    (WarWins != null &&
                    WarWins.Equals(input.WarWins))
                ) && 
                (
                    ChatLanguage == input.ChatLanguage ||
                    (ChatLanguage != null &&
                    ChatLanguage.Equals(input.ChatLanguage))
                ) && 
                (
                    Location == input.Location ||
                    (Location != null &&
                    Location.Equals(input.Location))
                ) && 
                (
                    Type == input.Type ||
                    (Type != null &&
                    Type.Equals(input.Type))
                ) && 
                (
                    WarFrequency == input.WarFrequency ||
                    (WarFrequency != null &&
                    WarFrequency.Equals(input.WarFrequency))
                ) && 
                (
                    WarLosses == input.WarLosses ||
                    (WarLosses != null &&
                    WarLosses.Equals(input.WarLosses))
                ) && 
                (
                    WarTies == input.WarTies ||
                    (WarTies != null &&
                    WarTies.Equals(input.WarTies))
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
                hashCode = (hashCode * 59) + BadgeUrls.GetHashCode();
                hashCode = (hashCode * 59) + ClanLevel.GetHashCode();
                hashCode = (hashCode * 59) + ClanPoints.GetHashCode();
                hashCode = (hashCode * 59) + ClanVersusPoints.GetHashCode();
                hashCode = (hashCode * 59) + Description.GetHashCode();
                hashCode = (hashCode * 59) + IsWarLogPublic.GetHashCode();
                hashCode = (hashCode * 59) + Labels.GetHashCode();
                hashCode = (hashCode * 59) + MemberList.GetHashCode();
                hashCode = (hashCode * 59) + Members.GetHashCode();
                hashCode = (hashCode * 59) + Name.GetHashCode();
                hashCode = (hashCode * 59) + RequiredTrophies.GetHashCode();
                hashCode = (hashCode * 59) + Tag.GetHashCode();
                hashCode = (hashCode * 59) + WarLeague.GetHashCode();
                hashCode = (hashCode * 59) + WarWinStreak.GetHashCode();
                hashCode = (hashCode * 59) + WarWins.GetHashCode();

                if (ChatLanguage != null)
                    hashCode = (hashCode * 59) + ChatLanguage.GetHashCode();

                if (Location != null)
                    hashCode = (hashCode * 59) + Location.GetHashCode();

                if (Type != null)
                    hashCode = (hashCode * 59) + Type.GetHashCode();

                if (WarFrequency != null)
                    hashCode = (hashCode * 59) + WarFrequency.GetHashCode();

                if (WarLosses != null)
                    hashCode = (hashCode * 59) + WarLosses.GetHashCode();

                if (WarTies != null)
                    hashCode = (hashCode * 59) + WarTies.GetHashCode();

                return hashCode;
            }
        }
    }

    /// <summary>
    /// A Json converter for type Clan
    /// </summary>
    public class ClanJsonConverter : JsonConverter<Clan>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Clan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            BadgeUrls badgeUrls = default;
            int clanLevel = default;
            int clanPoints = default;
            int clanVersusPoints = default;
            string description = default;
            bool isWarLogPublic = default;
            List<Label> labels = default;
            List<ClanMember> memberList = default;
            int members = default;
            string name = default;
            int requiredTrophies = default;
            string tag = default;
            WarLeague warLeague = default;
            int warWinStreak = default;
            int warWins = default;
            Language chatLanguage = default;
            Location location = default;
            RecruitingType? type = default;
            WarFrequency? warFrequency = default;
            int? warLosses = default;
            int? warTies = default;

            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "badgeUrls":
                            Utf8JsonReader badgeUrlsReader = reader;
                            badgeUrls = JsonSerializer.Deserialize<BadgeUrls>(ref reader, options);
                            break;
                        case "clanLevel":
                            clanLevel = reader.GetInt32();
                            break;
                        case "clanPoints":
                            clanPoints = reader.GetInt32();
                            break;
                        case "clanVersusPoints":
                            clanVersusPoints = reader.GetInt32();
                            break;
                        case "description":
                            description = reader.GetString();
                            break;
                        case "isWarLogPublic":
                            isWarLogPublic = reader.GetBoolean();
                            break;
                        case "labels":
                            Utf8JsonReader labelsReader = reader;
                            labels = JsonSerializer.Deserialize<List<Label>>(ref reader, options);
                            break;
                        case "memberList":
                            Utf8JsonReader memberListReader = reader;
                            memberList = JsonSerializer.Deserialize<List<ClanMember>>(ref reader, options);
                            break;
                        case "members":
                            members = reader.GetInt32();
                            break;
                        case "name":
                            name = reader.GetString();
                            break;
                        case "requiredTrophies":
                            requiredTrophies = reader.GetInt32();
                            break;
                        case "tag":
                            tag = reader.GetString();
                            break;
                        case "warLeague":
                            Utf8JsonReader warLeagueReader = reader;
                            warLeague = JsonSerializer.Deserialize<WarLeague>(ref reader, options);
                            break;
                        case "warWinStreak":
                            warWinStreak = reader.GetInt32();
                            break;
                        case "warWins":
                            warWins = reader.GetInt32();
                            break;
                        case "chatLanguage":
                            Utf8JsonReader chatLanguageReader = reader;
                            chatLanguage = JsonSerializer.Deserialize<Language>(ref reader, options);
                            break;
                        case "location":
                            Utf8JsonReader locationReader = reader;
                            location = JsonSerializer.Deserialize<Location>(ref reader, options);
                            break;
                        case "type":
                            string typeRawValue = reader.GetString();
                            type = RecruitingTypeConverter.FromString(typeRawValue);
                            break;
                        case "warFrequency":
                            string warFrequencyRawValue = reader.GetString();
                            warFrequency = WarFrequencyConverter.FromString(warFrequencyRawValue);
                            break;
                        case "warLosses":
                            if (reader.TokenType != JsonTokenType.Null)
                                warLosses = reader.GetInt32();
                            break;
                        case "warTies":
                            if (reader.TokenType != JsonTokenType.Null)
                                warTies = reader.GetInt32();
                            break;
                    }
                }
            }

            return new Clan(badgeUrls, clanLevel, clanPoints, clanVersusPoints, description, isWarLogPublic, labels, memberList, name, requiredTrophies, tag, warLeague, warLosses, warTies, warWinStreak, warWins, chatLanguage, location, type, warFrequency);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="clan"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Clan clan, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("badgeUrls");
            JsonSerializer.Serialize(writer, clan.BadgeUrls, options);
            writer.WriteNumber("clanLevel", (int)clan.ClanLevel);
            writer.WriteNumber("clanPoints", (int)clan.ClanPoints);
            writer.WriteNumber("clanVersusPoints", (int)clan.ClanVersusPoints);
            writer.WriteString("description", clan.Description);
            writer.WriteBoolean("isWarLogPublic", clan.IsWarLogPublic);
            writer.WritePropertyName("labels");
            JsonSerializer.Serialize(writer, clan.Labels, options);
            writer.WritePropertyName("memberList");
            JsonSerializer.Serialize(writer, clan.Members, options);
            writer.WriteNumber("members", (int)clan.Members);
            writer.WriteString("name", clan.Name);
            writer.WriteNumber("requiredTrophies", (int)clan.RequiredTrophies);
            writer.WriteString("tag", clan.Tag);
            writer.WritePropertyName("warLeague");
            JsonSerializer.Serialize(writer, clan.WarLeague, options);
            writer.WriteNumber("warWinStreak", (int)clan.WarWinStreak);
            writer.WriteNumber("warWins", (int)clan.WarWins);
            writer.WritePropertyName("chatLanguage");
            JsonSerializer.Serialize(writer, clan.ChatLanguage, options);
            writer.WritePropertyName("location");
            JsonSerializer.Serialize(writer, clan.Location, options);
            if (clan.Type == null)
                writer.WriteNull("type");
            var typeRawValue = RecruitingTypeConverter.ToJsonValue(clan.Type.Value);
            if (typeRawValue != null)
                writer.WriteString("type", typeRawValue);
            else
                writer.WriteNull("type");
            if (clan.WarFrequency == null)
                writer.WriteNull("warFrequency");
            var warFrequencyRawValue = WarFrequencyConverter.ToJsonValue(clan.WarFrequency.Value);
            if (warFrequencyRawValue != null)
                writer.WriteString("warFrequency", warFrequencyRawValue);
            else
                writer.WriteNull("warFrequency");
            if (clan.WarLosses != null)
                writer.WriteNumber("warLosses", (int)clan.WarLosses.Value);
            else
                writer.WriteNull("warLosses");
            if (clan.WarTies != null)
                writer.WriteNumber("warTies", (int)clan.WarTies.Value);
            else
                writer.WriteNull("warTies");

            writer.WriteEndObject();
        }
    }
}

