﻿// <auto-generated />
using System;
using BinaryBrainsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BinaryBrainsAPI.Migrations
{
    [DbContext(typeof(ArtechDbContext))]
    [Migration("20210802152202_ArtworkMigration")]
    partial class ArtworkMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Artworks.Artwork", b =>
                {
                    b.Property<int>("ArtworkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtworkPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ArtworkPrice")
                        .HasColumnType("float");

                    b.Property<string>("ArtworkTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtworkID");

                    b.ToTable("Artwork");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibition", b =>
                {
                    b.Property<int>("ExhibitionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExhibitionAnnouncementID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExhibitionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExhibitionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExhibitionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExhibitionTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExhibitionTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Exhibition_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganisationID")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("ExhibitionID");

                    b.HasIndex("ExhibitionAnnouncementID");

                    b.HasIndex("ExhibitionTypeID");

                    b.HasIndex("OrganisationID");

                    b.HasIndex("ScheduleID");

                    b.HasIndex("VenueID");

                    b.ToTable("Exhibition");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibitions.ExhibitionAnnouncement", b =>
                {
                    b.Property<int>("ExhibitionAnnouncementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExhibitionAnnouncementDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExhibitionAnnouncementID");

                    b.ToTable("ExhibitionAnnouncement");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibitions.ExhibitionType", b =>
                {
                    b.Property<int>("ExhibitionTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExhibitionTypeDecription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExhibitionTypeID");

                    b.ToTable("ExhibitionType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibitions.Organisation", b =>
                {
                    b.Property<int>("OrganisationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrganisationalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganisationalName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganisationID");

                    b.ToTable("Organisation");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibitions.Schedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ScheduleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScheduleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduleTypeID")
                        .HasColumnType("int");

                    b.HasKey("ScheduleID");

                    b.HasIndex("ScheduleTypeID");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibitions.ScheduleType", b =>
                {
                    b.Property<int>("ScheduleTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ScheduleTypeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScheduleTypeID");

                    b.ToTable("ScheduleType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibitions.Venue", b =>
                {
                    b.Property<int>("VenueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VenueDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VenueID");

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibition", b =>
                {
                    b.HasOne("BinaryBrainsAPI.Entities.Exhibitions.ExhibitionAnnouncement", "ExhibitionAnnouncement")
                        .WithMany()
                        .HasForeignKey("ExhibitionAnnouncementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Exhibitions.ExhibitionType", "ExhibitionType")
                        .WithMany()
                        .HasForeignKey("ExhibitionTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Exhibitions.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Exhibitions.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Exhibitions.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExhibitionAnnouncement");

                    b.Navigation("ExhibitionType");

                    b.Navigation("Organisation");

                    b.Navigation("Schedule");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Exhibitions.Schedule", b =>
                {
                    b.HasOne("BinaryBrainsAPI.Entities.Exhibitions.ScheduleType", "ScheduleType")
                        .WithMany()
                        .HasForeignKey("ScheduleTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScheduleType");
                });
#pragma warning restore 612, 618
        }
    }
}
