/* 
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * 
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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CocApi.Client.OpenAPIDateConverter;

//namespace CocApi
//{
//        /// <summary>
//        /// Defines Role
//        /// </summary>
//        [JsonConverter(typeof(StringEnumConverter))]
//        public enum RoleEnum
//        {
//            /// <summary>
//            /// Enum Member for value: member
//            /// </summary>
//            [EnumMember(Value = "member")]
//            Member = 1,

//            /// <summary>
//            /// Enum Admin for value: admin
//            /// </summary>
//            [EnumMember(Value = "admin")]
//            Admin = 2,

//            /// <summary>
//            /// Enum CoLeader for value: coLeader
//            /// </summary>
//            [EnumMember(Value = "coLeader")]
//            CoLeader = 3,

//            /// <summary>
//            /// Enum Leader for value: leader
//            /// </summary>
//            [EnumMember(Value = "leader")]
//            Leader = 4

//        }

//}



namespace CocApi.Model
{
    /// <summary>
    /// Player
    /// </summary>
    [DataContract]
    public partial class Player :  IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public Role? Role { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="clan">clan.</param>
        /// <param name="league">league.</param>
        /// <param name="role">role.</param>
        /// <param name="attackWins">attackWins.</param>
        /// <param name="defenseWins">defenseWins.</param>
        /// <param name="townHallLevel">townHallLevel.</param>
        /// <param name="townHallWeaponLevel">townHallWeaponLevel.</param>
        /// <param name="versusBattleWins">versusBattleWins.</param>
        /// <param name="legendStatistics">legendStatistics.</param>
        /// <param name="troops">troops.</param>
        /// <param name="heroes">heroes.</param>
        /// <param name="spells">spells.</param>
        /// <param name="labels">labels.</param>
        /// <param name="tag">tag.</param>
        /// <param name="name">name.</param>
        /// <param name="expLevel">expLevel.</param>
        /// <param name="trophies">trophies.</param>
        /// <param name="bestTrophies">bestTrophies.</param>
        /// <param name="donations">donations.</param>
        /// <param name="donationsReceived">donationsReceived.</param>
        /// <param name="builderHallLevel">builderHallLevel.</param>
        /// <param name="versusTrophies">versusTrophies.</param>
        /// <param name="bestVersusTrophies">bestVersusTrophies.</param>
        /// <param name="warStars">warStars.</param>
        /// <param name="achievements">achievements.</param>
        /// <param name="versusBattleWinCount">versusBattleWinCount.</param>
        public Player(PlayerClan clan = default(PlayerClan), League league = default(League), Role? role = default(Role?), int attackWins = default(int), int defenseWins = default(int), int townHallLevel = default(int), int townHallWeaponLevel = default(int), int versusBattleWins = default(int), PlayerLegendStatistics legendStatistics = default(PlayerLegendStatistics), List<PlayerItemLevel> troops = default(List<PlayerItemLevel>), List<PlayerItemLevel> heroes = default(List<PlayerItemLevel>), List<PlayerItemLevel> spells = default(List<PlayerItemLevel>), List<Label> labels = default(List<Label>), string tag = default(string), string name = default(string), int expLevel = default(int), int trophies = default(int), int bestTrophies = default(int), int donations = default(int), int donationsReceived = default(int), int builderHallLevel = default(int), int versusTrophies = default(int), int bestVersusTrophies = default(int), int warStars = default(int), List<PlayerAchievementProgress> achievements = default(List<PlayerAchievementProgress>), int versusBattleWinCount = default(int))
        {
            this.Clan = clan;
            this.League = league;
            this.Role = role;
            this.AttackWins = attackWins;
            this.DefenseWins = defenseWins;
            this.TownHallLevel = townHallLevel;
            this.TownHallWeaponLevel = townHallWeaponLevel;
            this.VersusBattleWins = versusBattleWins;
            this.LegendStatistics = legendStatistics;
            this.Troops = troops;
            this.Heroes = heroes;
            this.Spells = spells;
            this.Labels = labels;
            this.Tag = tag;
            this.Name = name;
            this.ExpLevel = expLevel;
            this.Trophies = trophies;
            this.BestTrophies = bestTrophies;
            this.Donations = donations;
            this.DonationsReceived = donationsReceived;
            this.BuilderHallLevel = builderHallLevel;
            this.VersusTrophies = versusTrophies;
            this.BestVersusTrophies = bestVersusTrophies;
            this.WarStars = warStars;
            this.Achievements = achievements;
            this.VersusBattleWinCount = versusBattleWinCount;
        }
        
        /// <summary>
        /// Gets or Sets Clan
        /// </summary>
        [DataMember(Name="clan", EmitDefaultValue=false)]
        public PlayerClan Clan { get; private set; }

        /// <summary>
        /// Gets or Sets League
        /// </summary>
        [DataMember(Name="league", EmitDefaultValue=false)]
        public League League { get; private set; }

        /// <summary>
        /// Gets or Sets AttackWins
        /// </summary>
        [DataMember(Name="attackWins", EmitDefaultValue=false)]
        public int AttackWins { get; private set; }

        /// <summary>
        /// Gets or Sets DefenseWins
        /// </summary>
        [DataMember(Name="defenseWins", EmitDefaultValue=false)]
        public int DefenseWins { get; private set; }

        /// <summary>
        /// Gets or Sets TownHallLevel
        /// </summary>
        [DataMember(Name="townHallLevel", EmitDefaultValue=false)]
        public int TownHallLevel { get; private set; }

        /// <summary>
        /// Gets or Sets TownHallWeaponLevel
        /// </summary>
        [DataMember(Name="townHallWeaponLevel", EmitDefaultValue=false)]
        public int TownHallWeaponLevel { get; private set; }

        /// <summary>
        /// Gets or Sets VersusBattleWins
        /// </summary>
        [DataMember(Name="versusBattleWins", EmitDefaultValue=false)]
        public int VersusBattleWins { get; private set; }

        /// <summary>
        /// Gets or Sets LegendStatistics
        /// </summary>
        [DataMember(Name="legendStatistics", EmitDefaultValue=false)]
        public PlayerLegendStatistics LegendStatistics { get; private set; }

        /// <summary>
        /// Gets or Sets Troops
        /// </summary>
        [DataMember(Name="troops", EmitDefaultValue=false)]
        public List<PlayerItemLevel> Troops { get; private set; }

        /// <summary>
        /// Gets or Sets Heroes
        /// </summary>
        [DataMember(Name="heroes", EmitDefaultValue=false)]
        public List<PlayerItemLevel> Heroes { get; private set; }

        /// <summary>
        /// Gets or Sets Spells
        /// </summary>
        [DataMember(Name="spells", EmitDefaultValue=false)]
        public List<PlayerItemLevel> Spells { get; private set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets ExpLevel
        /// </summary>
        [DataMember(Name="expLevel", EmitDefaultValue=false)]
        public int ExpLevel { get; private set; }

        /// <summary>
        /// Gets or Sets Trophies
        /// </summary>
        [DataMember(Name="trophies", EmitDefaultValue=false)]
        public int Trophies { get; private set; }

        /// <summary>
        /// Gets or Sets BestTrophies
        /// </summary>
        [DataMember(Name="bestTrophies", EmitDefaultValue=false)]
        public int BestTrophies { get; private set; }

        /// <summary>
        /// Gets or Sets Donations
        /// </summary>
        [DataMember(Name="donations", EmitDefaultValue=false)]
        public int Donations { get; private set; }

        /// <summary>
        /// Gets or Sets DonationsReceived
        /// </summary>
        [DataMember(Name="donationsReceived", EmitDefaultValue=false)]
        public int DonationsReceived { get; private set; }

        /// <summary>
        /// Gets or Sets BuilderHallLevel
        /// </summary>
        [DataMember(Name="builderHallLevel", EmitDefaultValue=false)]
        public int BuilderHallLevel { get; private set; }

        /// <summary>
        /// Gets or Sets VersusTrophies
        /// </summary>
        [DataMember(Name="versusTrophies", EmitDefaultValue=false)]
        public int VersusTrophies { get; private set; }

        /// <summary>
        /// Gets or Sets BestVersusTrophies
        /// </summary>
        [DataMember(Name="bestVersusTrophies", EmitDefaultValue=false)]
        public int BestVersusTrophies { get; private set; }

        /// <summary>
        /// Gets or Sets WarStars
        /// </summary>
        [DataMember(Name="warStars", EmitDefaultValue=false)]
        public int WarStars { get; private set; }

        /// <summary>
        /// Gets or Sets Achievements
        /// </summary>
        [DataMember(Name="achievements", EmitDefaultValue=false)]
        public List<PlayerAchievementProgress> Achievements { get; private set; }

        /// <summary>
        /// Gets or Sets VersusBattleWinCount
        /// </summary>
        [DataMember(Name="versusBattleWinCount", EmitDefaultValue=false)]
        public int VersusBattleWinCount { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Player {\n");
            sb.Append("  Clan: ").Append(Clan).Append("\n");
            sb.Append("  League: ").Append(League).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  AttackWins: ").Append(AttackWins).Append("\n");
            sb.Append("  DefenseWins: ").Append(DefenseWins).Append("\n");
            sb.Append("  TownHallLevel: ").Append(TownHallLevel).Append("\n");
            sb.Append("  TownHallWeaponLevel: ").Append(TownHallWeaponLevel).Append("\n");
            sb.Append("  VersusBattleWins: ").Append(VersusBattleWins).Append("\n");
            sb.Append("  LegendStatistics: ").Append(LegendStatistics).Append("\n");
            sb.Append("  Troops: ").Append(Troops).Append("\n");
            sb.Append("  Heroes: ").Append(Heroes).Append("\n");
            sb.Append("  Spells: ").Append(Spells).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExpLevel: ").Append(ExpLevel).Append("\n");
            sb.Append("  Trophies: ").Append(Trophies).Append("\n");
            sb.Append("  BestTrophies: ").Append(BestTrophies).Append("\n");
            sb.Append("  Donations: ").Append(Donations).Append("\n");
            sb.Append("  DonationsReceived: ").Append(DonationsReceived).Append("\n");
            sb.Append("  BuilderHallLevel: ").Append(BuilderHallLevel).Append("\n");
            sb.Append("  VersusTrophies: ").Append(VersusTrophies).Append("\n");
            sb.Append("  BestVersusTrophies: ").Append(BestVersusTrophies).Append("\n");
            sb.Append("  WarStars: ").Append(WarStars).Append("\n");
            sb.Append("  Achievements: ").Append(Achievements).Append("\n");
            sb.Append("  VersusBattleWinCount: ").Append(VersusBattleWinCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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