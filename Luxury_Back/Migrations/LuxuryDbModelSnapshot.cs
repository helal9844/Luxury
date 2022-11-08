﻿// <auto-generated />
using System;
using Luxury_Back.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Luxury_Back.Migrations
{
    [DbContext(typeof(LuxuryDb))]
    partial class LuxuryDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IAttributeIBooking", b =>
                {
                    b.Property<int>("iAttributesId")
                        .HasColumnType("int");

                    b.Property<int>("iBookingsId")
                        .HasColumnType("int");

                    b.HasKey("iAttributesId", "iBookingsId");

                    b.HasIndex("iBookingsId");

                    b.ToTable("IAttributeIBooking");
                });

            modelBuilder.Entity("Luxury_Back.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<int?>("IBookingId")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("lat")
                        .HasColumnType("float");

                    b.Property<double?>("lng")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("GovernorateId");

                    b.HasIndex("IBookingId")
                        .IsUnique()
                        .HasFilter("[IBookingId] IS NOT NULL");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("Luxury_Back.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_ar")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("name_ar")
                        .IsUnique()
                        .HasFilter("[name_ar] IS NOT NULL");

                    b.HasIndex("name_en")
                        .IsUnique()
                        .HasFilter("[name_en] IS NOT NULL");

                    b.ToTable("brands", (string)null);
                });

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

                    b.Property<string>("img_category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_ar")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("name_ar")
                        .IsUnique();

                    b.HasIndex("name_en")
                        .IsUnique();

                    b.ToTable("categories");
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

            modelBuilder.Entity("Luxury_Back.Models.IAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("name_ar")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("name_ar")
                        .IsUnique()
                        .HasFilter("[name_ar] IS NOT NULL");

                    b.HasIndex("name_en")
                        .IsUnique()
                        .HasFilter("[name_en] IS NOT NULL");

                    b.ToTable("iAttributes", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.IBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("Category_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("description_ar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description_en")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_ar")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("Category_Id");

                    b.HasIndex("name_ar")
                        .IsUnique()
                        .HasFilter("[name_ar] IS NOT NULL");

                    b.HasIndex("name_en")
                        .IsUnique()
                        .HasFilter("[name_en] IS NOT NULL");

                    b.ToTable("iBookings", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.IBookingAttribute", b =>
                {
                    b.Property<int?>("IBookingId")
                        .HasColumnType("int");

                    b.Property<int?>("IAttributeId")
                        .HasColumnType("int");

                    b.Property<string>("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IBookingId", "IAttributeId");

                    b.HasIndex("IAttributeId");

                    b.ToTable("iBookingAttributes", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.IBookingImg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IBookingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IBookingId");

                    b.ToTable("iBookingImg");
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

                    b.Property<bool?>("IsEmailVerify")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("IAttributeIBooking", b =>
                {
                    b.HasOne("Luxury_Back.Models.IAttribute", null)
                        .WithMany()
                        .HasForeignKey("iAttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Luxury_Back.Models.IBooking", null)
                        .WithMany()
                        .HasForeignKey("iBookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Luxury_Back.Models.Address", b =>
                {
                    b.HasOne("Luxury_Back.Models.City", "City")
                        .WithMany("Adresses")
                        .HasForeignKey("CityId");

                    b.HasOne("Luxury_Back.Models.Governorate", "Governorate")
                        .WithMany("Addresses")
                        .HasForeignKey("GovernorateId");

                    b.HasOne("Luxury_Back.Models.IBooking", "IBooking")
                        .WithOne("Address")
                        .HasForeignKey("Luxury_Back.Models.Address", "IBookingId");

                    b.Navigation("City");

                    b.Navigation("Governorate");

                    b.Navigation("IBooking");
                });

            modelBuilder.Entity("Luxury_Back.Models.Brand", b =>
                {
                    b.HasOne("Luxury_Back.Models.Category", "category")
                        .WithMany("brands")
                        .HasForeignKey("CategoryId");

                    b.Navigation("category");
                });

            modelBuilder.Entity("Luxury_Back.Models.Category", b =>
                {
                    b.HasOne("Luxury_Back.Models.Category", "parent")
                        .WithMany("childs")
                        .HasForeignKey("CategoryId");

                    b.Navigation("parent");
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

            modelBuilder.Entity("Luxury_Back.Models.IBooking", b =>
                {
                    b.HasOne("Luxury_Back.Models.Brand", "Brand")
                        .WithMany("iBookings")
                        .HasForeignKey("BrandId");

                    b.HasOne("Luxury_Back.Models.Category", "Category")
                        .WithMany("iBookings")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Luxury_Back.Models.IBookingAttribute", b =>
                {
                    b.HasOne("Luxury_Back.Models.IAttribute", "IAttribute")
                        .WithMany("iBookingAttributes")
                        .HasForeignKey("IAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Luxury_Back.Models.IBooking", "IBooking")
                        .WithMany("iBookingAttributes")
                        .HasForeignKey("IBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IAttribute");

                    b.Navigation("IBooking");
                });

            modelBuilder.Entity("Luxury_Back.Models.IBookingImg", b =>
                {
                    b.HasOne("Luxury_Back.Models.IBooking", "booking")
                        .WithMany("images")
                        .HasForeignKey("IBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking");
                });

            modelBuilder.Entity("Luxury_Back.Models.Brand", b =>
                {
                    b.Navigation("iBookings");
                });

            modelBuilder.Entity("Luxury_Back.Models.Category", b =>
                {
                    b.Navigation("brands");

                    b.Navigation("childs");

                    b.Navigation("iBookings");
                });

            modelBuilder.Entity("Luxury_Back.Models.City", b =>
                {
                    b.Navigation("Adresses");
                });

            modelBuilder.Entity("Luxury_Back.Models.Governorate", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Luxury_Back.Models.IAttribute", b =>
                {
                    b.Navigation("iBookingAttributes");
                });

            modelBuilder.Entity("Luxury_Back.Models.IBooking", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("iBookingAttributes");

                    b.Navigation("images");
                });
#pragma warning restore 612, 618
        }
    }
}
