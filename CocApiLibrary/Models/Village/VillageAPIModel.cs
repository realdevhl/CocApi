﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using CocApiLibrary.Converters;
using CocApiLibrary.Models;
using Microsoft.Extensions.Logging;
using static CocApiLibrary.Enums;

namespace CocApiLibrary
{
    public class VillageAPIModel : CommonMethods, IVillageAPIModel, IDownloadable
    {
        
        private string _tag = string.Empty;
        
        public string Tag
        {
            get
            {
                return _tag;
            }
        
            set
            {
                _tag = value.ToUpper();
            }
        }

        public string Name { get; set; } = string.Empty;

        public int TownHallLevel { get; set; }

        public int TownHallWeaponLevel { get; set; }

        public int ExpLevel { get; set; }

        public int Trophies { get; set; }

        public int BestTrophies { get; set; }

        public int WarStars { get; set; }

        public int AttackWins { get; set; }

        public int DefenseWins { get; set; }

        public LegendLeagueStatisticsAPIModel? LegendStatistics { get; set; }

        public int BuilderHallLevel { get; set; }

        public int VersusTrophies { get; set; }

        public int BestVersusTrophies { get; set; }

        public int VersusBattleWins { get; set; }

        [JsonConverter(typeof(RoleConverter))]
        public Role Role { get; set; } = Role.Unknown;

        public int Donations { get; set; }

        public int DonationsReceived { get; set; }

        public SimpleClanAPIModel? Clan { get; set; }

        public LeagueAPIModel? League { get; set; }

        public IEnumerable<AchievementAPIModel>? Achievements { get; set; }

        public int VersusBattleWinCount { get; set; }

        public IEnumerable<TroopAPIModel>? Troops { get; set; }

        public IEnumerable<TroopAPIModel>? Heroes { get; set; }

        public IEnumerable<LabelAPIModel>? Labels { get; set; }

        public IEnumerable<SpellAPIModel>? Spells { get; set; }

        public DateTime DateTimeUTC { get; internal set; } = DateTime.UtcNow;

        public DateTime Expires { get; internal set; }

        public string EncodedUrl { get; internal set; } = string.Empty;

        public bool IsExpired()
        {
            if (DateTime.UtcNow > Expires)
            {
                return true;
            }
            return false;
        }




        private readonly object _updateLock = new object();

        internal void Update(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            lock (_updateLock)
            {
                Logger = cocApi.Logger;

                Swallow(() => UpdateVillage(cocApi, downloadedVillage), nameof(UpdateVillage));

                Swallow(() => UpdateLabels(cocApi, downloadedVillage), nameof(UpdateLabels));

                Swallow(() => UpdateVillageDefenseWins(cocApi, downloadedVillage), nameof(UpdateVillageDefenseWins));

                //UpdateVillageDonations(cocApi, downloadedVillage);

                //UpdateVillageDonationsReceived(cocApi, downloadedVillage);

                Swallow(() => UpdateVillageExpLevel(cocApi, downloadedVillage), nameof(UpdateVillageExpLevel));

                Swallow(() => UpdateVillageTrophies(cocApi, downloadedVillage), nameof(UpdateVillageTrophies));

                Swallow(() => UpdateVillageVersusBattleWinCount(cocApi, downloadedVillage), nameof(UpdateVillageVersusBattleWinCount));

                Swallow(() => UpdateVillageVersusBattleWins(cocApi, downloadedVillage), nameof(UpdateVillageVersusBattleWins));

                Swallow(() => UpdateVillageVersusTrophies(cocApi, downloadedVillage), nameof(UpdateVillageVersusTrophies));

                //UpdateVillageLeague(cocApi, downloadedVillage);

                Swallow(() => UpdateVillageAchievements(cocApi, downloadedVillage), nameof(UpdateVillageAchievements));

                Swallow(() => UpdateVillageTroops(cocApi, downloadedVillage), nameof(UpdateVillageTroops));

                Swallow(() => UpdateVillageHeroes(cocApi, downloadedVillage), nameof(UpdateVillageHeroes));

                Swallow(() => UpdateVillageSpells(cocApi, downloadedVillage), nameof(UpdateVillageSpells));

                Swallow(() => UpdateLegendLeagueStatistics(cocApi, downloadedVillage), nameof(UpdateLegendLeagueStatistics));

                DateTimeUTC = downloadedVillage.DateTimeUTC;

                Expires = downloadedVillage.Expires;
            }
        }

        private void UpdateLegendLeagueStatistics(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (LegendStatistics == null && downloadedVillage.LegendStatistics == null) return;

            if (LegendStatistics == null && downloadedVillage.LegendStatistics != null)
            {
                cocApi.VillageReachedLegendsLeagueEvent(downloadedVillage);
            }

            LegendStatistics = downloadedVillage.LegendStatistics;
        }

        private void UpdateLabels(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (Labels == null && downloadedVillage.Labels == null) return;

            if (Labels != null && Labels.Count() > 0 && (downloadedVillage.Labels == null || downloadedVillage.Labels.Count() == 0))
            {
                cocApi.VillageLabelsRemovedEvent(downloadedVillage, Labels);

                Labels = downloadedVillage.Labels;
            }
            else if ((Labels == null || Labels.Count() == 0) && downloadedVillage.Labels != null && downloadedVillage.Labels.Count() > 0)
            {
                cocApi.VillageLabelsAddedEvent(downloadedVillage, downloadedVillage.Labels);

                Labels = downloadedVillage.Labels;
            }
            else
            {
                List<LabelAPIModel> added = new List<LabelAPIModel>();

                List<LabelAPIModel> removed = new List<LabelAPIModel>();

                foreach (LabelAPIModel labelAPIModel in Labels.EmptyIfNull())
                {
                    if (!downloadedVillage.Labels.Any(l => l.Id == labelAPIModel.Id))
                    {
                        removed.Add(labelAPIModel);
                    }
                }

                foreach (LabelAPIModel labelAPIModel in downloadedVillage.Labels.EmptyIfNull())
                {
                    if (!Labels.Any(l => l.Id == labelAPIModel.Id))
                    {
                        added.Add(labelAPIModel);
                    }
                }

                cocApi.VillageLabelsRemovedEvent(downloadedVillage, removed);

                cocApi.VillageLabelsAddedEvent(downloadedVillage, added);

                Labels = downloadedVillage.Labels;
            }
        }

        private void UpdateVillageSpells(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            List<SpellAPIModel> newSpells = new List<SpellAPIModel>();

            foreach(SpellAPIModel spell in downloadedVillage.Spells.EmptyIfNull())
            {
                SpellAPIModel? oldSpell = Spells.FirstOrDefault(s => s.Name == spell.Name);

                if (oldSpell == null || oldSpell.Level < spell.Level)
                {
                    newSpells.Add(spell);
                }
            }

            if (newSpells.Count() > 0)
            {
                cocApi.VillageSpellsChangedEvent(this, newSpells);

                Spells = downloadedVillage.Spells;
            }
        }

        private void UpdateVillageHeroes(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            List<TroopAPIModel> newTroops = new List<TroopAPIModel>();

            foreach (TroopAPIModel troop in downloadedVillage.Heroes.EmptyIfNull())
            {
                TroopAPIModel? oldTroop = Heroes.FirstOrDefault(t => t.Name == troop.Name);

                if (oldTroop == null || oldTroop.Level < troop.Level)
                {
                    newTroops.Add(troop);
                }

            }

            if (newTroops.Count() > 0)
            {
                cocApi.VillageHeroesChangedEvent(this, newTroops);

                Heroes = downloadedVillage.Heroes;
            }
        }

        private void UpdateVillageTroops(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            List<TroopAPIModel> newTroops = new List<TroopAPIModel>();
            
            foreach(TroopAPIModel troop in downloadedVillage.Troops.EmptyIfNull())
            {
                TroopAPIModel? oldTroop = Troops.FirstOrDefault(t => t.Name == troop.Name);

                if (oldTroop == null || oldTroop.Level < troop.Level)
                {
                    newTroops.Add(troop);
                }

            }

            if (newTroops.Count() > 0)
            {
                cocApi.VillageTroopsChangedEvent(this, newTroops);

                Troops = downloadedVillage.Troops;
            }
        }

        private void UpdateVillageAchievements(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            List<AchievementAPIModel> newAchievements = new List<AchievementAPIModel>();

            foreach(AchievementAPIModel achievement in downloadedVillage.Achievements.EmptyIfNull())
            {
                if (achievement.Value > achievement.Target)
                {
                    AchievementAPIModel oldAchievement = Achievements.FirstOrDefault(a => a.Name == achievement.Name);

                    if (oldAchievement == null || oldAchievement.Value < oldAchievement.Target)
                    {
                        newAchievements.Add(achievement);
                    }
                }
            }

            if (newAchievements.Count() > 0)
            {
                cocApi.VillageAchievementsChangedEvent(this, newAchievements);

                Achievements = downloadedVillage.Achievements;
            }            
        }

        //private void UpdateVillageLeague(CocApi cocApi, VillageAPIModel downloadedVillage)
        //{
        //    if (League == null && downloadedVillage.League != null ||
        //        League?.Id != downloadedVillage.League?.Id)
        //    {
        //        cocApi.VillageLeagueChangedEvent(this, downloadedVillage.League);

        //        League = downloadedVillage.League;
        //    }
        //}

        private void UpdateVillage(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (downloadedVillage.AttackWins != AttackWins ||
                downloadedVillage.BestTrophies != BestTrophies ||
                downloadedVillage.BestVersusTrophies != BestVersusTrophies ||
                downloadedVillage.BuilderHallLevel != BuilderHallLevel ||
                //downloadedVillage.DefenseWins != DefenseWins ||
                //downloadedVillage.Donations != Donations ||
                //downloadedVillage.DonationsReceived != DonationsReceived ||
                //downloadedVillage.ExpLevel != ExpLevel ||
                //downloadedVillage.Name != Name ||
                //downloadedVillage.Role != Role ||
                downloadedVillage.TownHallLevel != TownHallLevel ||
                downloadedVillage.TownHallWeaponLevel != TownHallWeaponLevel ||
                //downloadedVillage.Trophies != Trophies ||
                //downloadedVillage.VersusBattleWinCount != VersusBattleWinCount ||
                //downloadedVillage.VersusBattleWins != VersusBattleWins ||
                //downloadedVillage.VersusTrophies != VersusTrophies ||
                downloadedVillage.WarStars != WarStars
                )
            {
                cocApi.VillageChangedEvent(this, downloadedVillage);

                AttackWins = downloadedVillage.AttackWins;
                BestTrophies = downloadedVillage.BestTrophies;
                BestVersusTrophies = downloadedVillage.BestVersusTrophies;
                BuilderHallLevel = downloadedVillage.BuilderHallLevel;
                //Name = downloadedVillage.Name;
                //Role = downloadedVillage.Role;
                TownHallLevel = downloadedVillage.TownHallLevel;
                TownHallWeaponLevel = downloadedVillage.TownHallWeaponLevel;
                WarStars = downloadedVillage.WarStars;
            }
        }

        private void UpdateVillageDefenseWins(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (downloadedVillage.DefenseWins != DefenseWins)
            {
                cocApi.VillageDefenseWinsChangedEvent(this, downloadedVillage.DefenseWins);

                DefenseWins = downloadedVillage.DefenseWins;
            }
        }

        //private void UpdateVillageDonations(CocApi cocApi, VillageAPIModel downloadedVillage)
        //{
        //    if (
        //        downloadedVillage.Donations != Donations
        //        )
        //    {
        //        cocApi.VillageDonationsChangedEvent(this, downloadedVillage.Donations);

        //        Donations = downloadedVillage.Donations;
        //    }
        //}

        //private void UpdateVillageDonationsReceived(CocApi cocApi, VillageAPIModel downloadedVillage)
        //{
        //    if (
        //        downloadedVillage.DonationsReceived != DonationsReceived
        //        )
        //    {
        //        cocApi.VillageDonationsReceivedChangedEvent(this, downloadedVillage.DonationsReceived);

        //        DonationsReceived = downloadedVillage.DonationsReceived;
        //    }
        //}

        private void UpdateVillageExpLevel(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (downloadedVillage.ExpLevel != ExpLevel)
            {
                cocApi.VillageExpLevelChangedEvent(this, downloadedVillage.ExpLevel);

                ExpLevel = downloadedVillage.ExpLevel;
            }
        }

        private void UpdateVillageTrophies(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (downloadedVillage.Trophies != Trophies)
            {
                cocApi.VillageTrophiesChangedEvent(this, downloadedVillage.Trophies);

                Trophies = downloadedVillage.Trophies;
            }
        }

        private void UpdateVillageVersusBattleWinCount(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (downloadedVillage.VersusBattleWinCount != VersusBattleWinCount)
            {
                cocApi.VillageVersusBattleWinCountChangedEvent(this, downloadedVillage.VersusBattleWinCount);

                VersusBattleWinCount = downloadedVillage.VersusBattleWinCount;
            }
        }

        private void UpdateVillageVersusBattleWins(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (downloadedVillage.VersusBattleWins != VersusBattleWins)
            {
                cocApi.VillageVersusBattleWinsChangedEvent(this, downloadedVillage.VersusBattleWins);

                VersusBattleWins = downloadedVillage.VersusBattleWins;
            }
        }

        private void UpdateVillageVersusTrophies(CocApi cocApi, VillageAPIModel downloadedVillage)
        {
            if (downloadedVillage.VersusTrophies != VersusTrophies)
            {
                cocApi.VillageVersusTrophiesChangedEvent(this, downloadedVillage.VersusTrophies);

                VersusTrophies = downloadedVillage.VersusTrophies;
            }
        }








    }
}
