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
    [Migration("20180528140120_Initial")]
    partial class Initial
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

            modelBuilder.Entity("HondenAsiel.Data.Models.Ras", b =>
                {
                    b.Property<int>("RasId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Beschrijving");

                    b.Property<string>("Rasnaam");

                    b.HasKey("RasId");

                    b.ToTable("ras");
                });

            modelBuilder.Entity("HondenAsiel.Data.Models.Honden", b =>
                {
                    b.HasOne("HondenAsiel.Data.Models.Ras", "Ras")
                        .WithMany("honden")
                        .HasForeignKey("RasId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
