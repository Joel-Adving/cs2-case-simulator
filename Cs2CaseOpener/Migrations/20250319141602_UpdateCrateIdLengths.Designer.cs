﻿// <auto-generated />
using System;
using Cs2CaseOpener.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cs2CaseOpener.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250319141602_UpdateCrateIdLengths")]
    partial class UpdateCrateIdLengths
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CrateSkin", b =>
                {
                    b.Property<string>("CratesId")
                        .HasColumnType("character varying(50)");

                    b.Property<string>("SkinsId")
                        .HasColumnType("character varying(50)");

                    b.HasKey("CratesId", "SkinsId");

                    b.HasIndex("SkinsId");

                    b.ToTable("CrateSkins", (string)null);
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.CounterStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Value")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("CounterStats");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Crate", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description")
                        .HasAnnotation("Relational:JsonPropertyName", "description");

                    b.Property<DateTime?>("First_Sale_Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("first_sale_date")
                        .HasAnnotation("Relational:JsonPropertyName", "first_sale_date");

                    b.Property<string>("Image")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)")
                        .HasColumnName("image")
                        .HasAnnotation("Relational:JsonPropertyName", "image");

                    b.Property<string>("Market_Hash_Name")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("market_hash_name")
                        .HasAnnotation("Relational:JsonPropertyName", "market_hash_name");

                    b.Property<string>("Model_Player")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("model_player")
                        .HasAnnotation("Relational:JsonPropertyName", "model_player");

                    b.Property<string>("Name")
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<bool?>("Rental")
                        .HasColumnType("boolean")
                        .HasColumnName("rental")
                        .HasAnnotation("Relational:JsonPropertyName", "rental");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("type")
                        .HasAnnotation("Relational:JsonPropertyName", "type");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Crates");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.CrateOpening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("client_id");

                    b.Property<string>("ClientIp")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("client_ip");

                    b.Property<string>("CrateId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("crate_id");

                    b.Property<string>("CrateName")
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)")
                        .HasColumnName("crate_name");

                    b.Property<DateTime>("OpenedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("opened_at");

                    b.Property<string>("Rarity")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("rarity");

                    b.Property<string>("SkinId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("skin_id");

                    b.Property<string>("SkinName")
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)")
                        .HasColumnName("skin_name");

                    b.Property<string>("WearCategory")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("wear_category");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CrateId");

                    b.HasIndex("OpenedAt");

                    b.HasIndex("SkinId");

                    b.HasIndex("OpenedAt", "Rarity")
                        .HasDatabaseName("IX_CrateOpenings_OpenedAt_Rarity");

                    b.ToTable("CrateOpenings");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CrateId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("crate_id")
                        .HasAnnotation("Relational:JsonPropertyName", "crate_id");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("SkinId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("skin_id")
                        .HasAnnotation("Relational:JsonPropertyName", "skin_id");

                    b.Property<double?>("Steam_Last_24h")
                        .HasColumnType("double precision")
                        .HasColumnName("steam_last_24h")
                        .HasAnnotation("Relational:JsonPropertyName", "steam_last_24h");

                    b.Property<double?>("Steam_Last_30d")
                        .HasColumnType("double precision")
                        .HasColumnName("steam_last_30d")
                        .HasAnnotation("Relational:JsonPropertyName", "steam_last_30d");

                    b.Property<double?>("Steam_Last_7d")
                        .HasColumnType("double precision")
                        .HasColumnName("steam_last_7d")
                        .HasAnnotation("Relational:JsonPropertyName", "steam_last_7d");

                    b.Property<double?>("Steam_Last_90d")
                        .HasColumnType("double precision")
                        .HasColumnName("steam_last_90d")
                        .HasAnnotation("Relational:JsonPropertyName", "steam_last_90d");

                    b.Property<double?>("Steam_Last_Ever")
                        .HasColumnType("double precision")
                        .HasColumnName("steam_last_ever")
                        .HasAnnotation("Relational:JsonPropertyName", "steam_last_ever");

                    b.Property<string>("Wear_Category")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("wear_category")
                        .HasAnnotation("Relational:JsonPropertyName", "wear_category");

                    b.HasKey("Id");

                    b.HasIndex("CrateId")
                        .IsUnique()
                        .HasFilter("crate_id IS NOT NULL");

                    b.HasIndex("Name");

                    b.HasIndex("SkinId", "Wear_Category")
                        .IsUnique()
                        .HasFilter("skin_id IS NOT NULL");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Rarity", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Color")
                        .HasMaxLength(7)
                        .HasColumnType("character varying(7)")
                        .HasColumnName("color")
                        .HasAnnotation("Relational:JsonPropertyName", "color");

                    b.Property<string>("Name")
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Rarities");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Skin", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Category")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("category")
                        .HasAnnotation("Relational:JsonPropertyName", "category");

                    b.Property<string>("Image")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)")
                        .HasColumnName("image")
                        .HasAnnotation("Relational:JsonPropertyName", "image");

                    b.Property<double?>("MaxFloat")
                        .HasColumnType("double precision")
                        .HasColumnName("max_float")
                        .HasAnnotation("Relational:JsonPropertyName", "max_float");

                    b.Property<double?>("MinFloat")
                        .HasColumnType("double precision")
                        .HasColumnName("min_float")
                        .HasAnnotation("Relational:JsonPropertyName", "min_float");

                    b.Property<string>("Name")
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("PaintIndex")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("paint_index")
                        .HasAnnotation("Relational:JsonPropertyName", "paint_index");

                    b.Property<string>("Pattern")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("pattern")
                        .HasAnnotation("Relational:JsonPropertyName", "pattern");

                    b.Property<string>("RarityId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("rarity_id")
                        .HasAnnotation("Relational:JsonPropertyName", "rarity_id");

                    b.Property<bool?>("Souvenir")
                        .HasColumnType("boolean")
                        .HasColumnName("souvenir")
                        .HasAnnotation("Relational:JsonPropertyName", "souvenir");

                    b.Property<bool?>("StatTrak")
                        .HasColumnType("boolean")
                        .HasColumnName("stat_trak")
                        .HasAnnotation("Relational:JsonPropertyName", "stattrak");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("RarityId");

                    b.ToTable("Skins");
                });

            modelBuilder.Entity("CrateSkin", b =>
                {
                    b.HasOne("Cs2CaseOpener.Models.Crate", null)
                        .WithMany()
                        .HasForeignKey("CratesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cs2CaseOpener.Models.Skin", null)
                        .WithMany()
                        .HasForeignKey("SkinsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.CrateOpening", b =>
                {
                    b.HasOne("Cs2CaseOpener.Models.Crate", "Crate")
                        .WithMany()
                        .HasForeignKey("CrateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cs2CaseOpener.Models.Skin", "Skin")
                        .WithMany()
                        .HasForeignKey("SkinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crate");

                    b.Navigation("Skin");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Price", b =>
                {
                    b.HasOne("Cs2CaseOpener.Models.Crate", "Crate")
                        .WithOne("Price")
                        .HasForeignKey("Cs2CaseOpener.Models.Price", "CrateId");

                    b.HasOne("Cs2CaseOpener.Models.Skin", "Skin")
                        .WithMany("Prices")
                        .HasForeignKey("SkinId");

                    b.Navigation("Crate");

                    b.Navigation("Skin");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Skin", b =>
                {
                    b.HasOne("Cs2CaseOpener.Models.Rarity", "Rarity")
                        .WithMany("Skins")
                        .HasForeignKey("RarityId");

                    b.Navigation("Rarity");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Crate", b =>
                {
                    b.Navigation("Price");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Rarity", b =>
                {
                    b.Navigation("Skins");
                });

            modelBuilder.Entity("Cs2CaseOpener.Models.Skin", b =>
                {
                    b.Navigation("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}
