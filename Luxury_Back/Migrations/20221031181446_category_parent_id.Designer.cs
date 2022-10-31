﻿// <auto-generated />
using System;
using Luxury_Back.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Luxury_Back.Migrations
{
    [DbContext(typeof(LuxuryDb))]
    [Migration("20221031181446_category_parent_id")]
    partial class category_parent_id
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Luxury_Back.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Luxury_Back.Models.CategoryTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("locale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("categoriesTranslation");
                });

            modelBuilder.Entity("Luxury_Back.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("gov_id")
                        .HasColumnType("int");

                    b.Property<string>("name_ar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_en")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("gov_id");

                    b.ToTable("cities", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.Governorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("name_ar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_en")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("governorates", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("is_admin")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updated_at")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("username")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.Category", b =>
                {
                    b.HasOne("Luxury_Back.Models.Category", null)
                        .WithMany("childs")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Luxury_Back.Models.CategoryTranslation", b =>
                {
                    b.HasOne("Luxury_Back.Models.Category", null)
                        .WithMany("translations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Luxury_Back.Models.City", b =>
                {
                    b.HasOne("Luxury_Back.Models.Governorate", "Governorate")
                        .WithMany("Cities")
                        .HasForeignKey("gov_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");
                });

            modelBuilder.Entity("Luxury_Back.Models.Category", b =>
                {
                    b.Navigation("childs");

                    b.Navigation("translations");
                });

            modelBuilder.Entity("Luxury_Back.Models.Governorate", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
