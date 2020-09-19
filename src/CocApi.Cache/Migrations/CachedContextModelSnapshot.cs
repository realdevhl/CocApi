﻿// <auto-generated />
using System;
using CocApi.Cache;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CocApi.Cache.Migrations
{
    [DbContext(typeof(CachedContext))]
    partial class CachedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("CocApi.Cache.Models.CachedClan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Download")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DownloadCurrentWar")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DownloadCwl")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DownloadMembers")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Downloaded")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsWarLogPublic")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LocalExpiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("RawContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ServerExpiration")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Tag")
                        .IsUnique();

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("CocApi.Cache.Models.CachedClanWar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Downloaded")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LocalExpiration")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PreparationStartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("RawContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ServerExpiration")
                        .HasColumnType("TEXT");

                    b.Property<int?>("State")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Tag")
                        .IsUnique();

                    b.HasIndex("Tag", "PreparationStartTime")
                        .IsUnique();

                    b.ToTable("ClanWars");
                });

            modelBuilder.Entity("CocApi.Cache.Models.CachedClanWarLeagueGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Downloaded")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LocalExpiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("RawContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Season")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ServerExpiration")
                        .HasColumnType("TEXT");

                    b.Property<int?>("State")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Tag")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("CocApi.Cache.Models.CachedClanWarLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Downloaded")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LocalExpiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("RawContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ServerExpiration")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Tag")
                        .IsUnique();

                    b.ToTable("WarLogs");
                });

            modelBuilder.Entity("CocApi.Cache.Models.CachedPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Download")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Downloaded")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LocalExpiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("RawContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ServerExpiration")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Tag")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CocApi.Cache.Models.CachedWar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Announcements")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClanTag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Downloaded")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFinal")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LocalExpiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("OpponentTag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PreparationStartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("RawContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Season")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ServerExpiration")
                        .HasColumnType("TEXT");

                    b.Property<int?>("State")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WarTag")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClanTag");

                    b.HasIndex("OpponentTag");

                    b.HasIndex("WarTag");

                    b.HasIndex("PreparationStartTime", "ClanTag")
                        .IsUnique();

                    b.HasIndex("PreparationStartTime", "OpponentTag")
                        .IsUnique();

                    b.ToTable("Wars");
                });
#pragma warning restore 612, 618
        }
    }
}
