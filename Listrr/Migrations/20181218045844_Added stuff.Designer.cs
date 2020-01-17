﻿// <auto-generated />
using System;
using Listrr.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Listrr.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181218045844_Added stuff")]
    partial class Addedstuff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Listrr.Data.CountryCode", b =>
                {
                    b.Property<string>("Name");

                    b.Property<string>("Code");

                    b.HasKey("Name", "Code");

                    b.HasIndex("Code");

                    b.ToTable("CountryCodes");
                });

            modelBuilder.Entity("Listrr.Data.LanguageCode", b =>
                {
                    b.Property<string>("Name");

                    b.Property<string>("Code");

                    b.HasKey("Name", "Code");

                    b.HasIndex("Code");

                    b.ToTable("LanguageCodes");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktList", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Filter_Certifications_Movie");

                    b.Property<string>("Filter_Certifications_Show");

                    b.Property<string>("Filter_Countries");

                    b.Property<string>("Filter_Genres");

                    b.Property<string>("Filter_Languages");

                    b.Property<string>("Filter_Networks");

                    b.Property<string>("Filter_Ratings");

                    b.Property<string>("Filter_Runtimes");

                    b.Property<string>("Filter_SearchField");

                    b.Property<string>("Filter_Status");

                    b.Property<string>("Filter_Translations");

                    b.Property<string>("Filter_Years");

                    b.Property<int>("Items");

                    b.Property<DateTime>("LastProcessed");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.Property<bool>("Process");

                    b.Property<string>("Query");

                    b.Property<string>("Slug");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("Slug", "Name")
                        .IsUnique()
                        .HasFilter("[Slug] IS NOT NULL AND [Name] IS NOT NULL");

                    b.ToTable("TraktLists");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktMovieCertification", b =>
                {
                    b.Property<string>("Slug")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Slug");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("TraktMovieCertifications");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktMovieGenre", b =>
                {
                    b.Property<string>("Slug")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Slug");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("TraktMovieGenres");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktShowCertification", b =>
                {
                    b.Property<string>("Slug")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Slug");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("TraktShowCertifications");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktShowGenre", b =>
                {
                    b.Property<string>("Slug")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Slug");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("TraktShowGenres");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktShowNetwork", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TraktShowNetworks");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktShowStatus", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TraktShowStatuses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Listrr.Data.Trakt.TraktList", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
