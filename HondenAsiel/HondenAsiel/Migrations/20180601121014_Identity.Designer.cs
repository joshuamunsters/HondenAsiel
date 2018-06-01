﻿// <auto-generated />
using HondenAsiel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HondenAsiel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180601121014_Identity")]
    partial class Identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HondenAsiel.Data.Models.Honden", b =>
                {
                    b.Property<int>("HondId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aantalbeschikbaar");

                    b.Property<bool>("Gewild");

                    b.Property<int>("Kbeschrijving");

                    b.Property<int>("Lbeschrijving");

                    b.Property<string>("Naam");

                    b.Property<string>("PicURL");

                    b.Property<decimal>("Prijs");

                    b.Property<int>("RasId");

                    b.Property<string>("Thumbnail");

                    b.HasKey("HondId");

                    b.HasIndex("RasId");

                    b.ToTable("honden");
                });

            modelBuilder.Entity("HondenAsiel.Data.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<int>("Adress");

                    b.Property<string>("Adress2");

                    b.Property<string>("Email");

                    b.Property<string>("Land");

                    b.Property<decimal>("OrderTotaal");

                    b.Property<DateTime>("Ordergeplaatst");

                    b.Property<string>("Postcode");

                    b.Property<string>("TelefoonNummer");

                    b.Property<string>("Voornaam")
                        .IsRequired();

                    b.HasKey("OrderId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("HondenAsiel.Data.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Hoeveelheid");

                    b.Property<int>("HondenId");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Prijs");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("HondenId");

                    b.HasIndex("OrderId");

                    b.ToTable("orderdetails");
                });

            modelBuilder.Entity("HondenAsiel.Data.Models.Ras", b =>
                {
                    b.Property<int>("RasId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Beschrijving");

                    b.Property<string>("Rasnaam");

                    b.HasKey("RasId");

                    b.ToTable("ras");
                });

            modelBuilder.Entity("HondenAsiel.Data.Models.WinkelWagenItem", b =>
                {
                    b.Property<int>("WinkelWagenItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Hoeveelheid");

                    b.Property<int?>("HondenHondId");

                    b.Property<string>("WinkelWagenId");

                    b.HasKey("WinkelWagenItemId");

                    b.HasIndex("HondenHondId");

                    b.ToTable("WinkelWagenItems");
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
                        .ValueGeneratedOnAdd();

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
                        .ValueGeneratedOnAdd();

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HondenAsiel.Data.Models.Honden", b =>
                {
                    b.HasOne("HondenAsiel.Data.Models.Ras", "Ras")
                        .WithMany("honden")
                        .HasForeignKey("RasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HondenAsiel.Data.Models.OrderDetails", b =>
                {
                    b.HasOne("HondenAsiel.Data.Models.Honden", "Honden")
                        .WithMany()
                        .HasForeignKey("HondenId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HondenAsiel.Data.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HondenAsiel.Data.Models.WinkelWagenItem", b =>
                {
                    b.HasOne("HondenAsiel.Data.Models.Honden", "Honden")
                        .WithMany()
                        .HasForeignKey("HondenHondId");
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