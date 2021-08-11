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
    [Migration("20210803175522_ArtworkDimensionMigration")]
    partial class ArtworkDimensionMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.ArtClass", b =>
                {
                    b.Property<int>("ArtClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtClassAnnouncementID")
                        .HasColumnType("int");

                    b.Property<string>("ArtClassDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ArtClassEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArtClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ArtClassStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ArtClassTypeID")
                        .HasColumnType("int");

                    b.Property<int>("ClassLimit")
                        .HasColumnType("int");

                    b.Property<double>("ClassPrice")
                        .HasColumnType("float");

                    b.Property<int>("ClassTeacherID")
                        .HasColumnType("int");

                    b.Property<int>("OrganisationID")
                        .HasColumnType("int");

                    b.Property<int>("RefundDayLimit")
                        .HasColumnType("int");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("ArtClassID");

                    b.HasIndex("ArtClassAnnouncementID");

                    b.HasIndex("ArtClassTypeID");

                    b.HasIndex("ClassTeacherID");

                    b.HasIndex("OrganisationID");

                    b.HasIndex("VenueID");

                    b.ToTable("ArtClasse");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.ArtClassAnnouncement", b =>
                {
                    b.Property<int>("ArtClassAnnouncementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtClassAnnouncementDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtClassAnnouncementID");

                    b.ToTable("ArtClassAnnouncement");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.ArtClassType", b =>
                {
                    b.Property<int>("ArtClassTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtClassTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtClassTypeID");

                    b.ToTable("ArtClassType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.ClassTeacher", b =>
                {
                    b.Property<int>("ClassTeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherPhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("TeacherSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherTypeID")
                        .HasColumnType("int");

                    b.HasKey("ClassTeacherID");

                    b.HasIndex("TeacherTypeID");

                    b.ToTable("ClassTeacher");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.Feedback", b =>
                {
                    b.Property<int>("FeedbackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtClassID")
                        .HasColumnType("int");

                    b.Property<double>("DifficultyRating")
                        .HasColumnType("float");

                    b.Property<string>("FeedbackComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OverallRating")
                        .HasColumnType("float");

                    b.Property<double>("TeacherRating")
                        .HasColumnType("float");

                    b.HasKey("FeedbackID");

                    b.HasIndex("ArtClassID");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.TeacherType", b =>
                {
                    b.Property<int>("TeacherTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherTypeID");

                    b.ToTable("TeacherType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Artworks.Artwork", b =>
                {
                    b.Property<int>("ArtworkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtworkDimensionID")
                        .HasColumnType("int");

                    b.Property<string>("ArtworkPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ArtworkPrice")
                        .HasColumnType("float");

                    b.Property<int>("ArtworkStatusID")
                        .HasColumnType("int");

                    b.Property<string>("ArtworkTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MediumTypeID")
                        .HasColumnType("int");

                    b.Property<int>("SurfaceTypeID")
                        .HasColumnType("int");

                    b.HasKey("ArtworkID");

                    b.HasIndex("ArtworkDimensionID");

                    b.HasIndex("ArtworkStatusID");

                    b.HasIndex("MediumTypeID");

                    b.HasIndex("SurfaceTypeID");

                    b.ToTable("Artwork");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Artworks.ArtworkDimension", b =>
                {
                    b.Property<int>("ArtworkDimensionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtworkDimensionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtworkDimensionID");

                    b.ToTable("ArtworkDimension");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Artworks.ArtworkStatus", b =>
                {
                    b.Property<int>("ArtworkStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtworkStatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtworkStatusID");

                    b.ToTable("ArtworkStatus");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Artworks.MediumType", b =>
                {
                    b.Property<int>("MediumTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MediumTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediumTypeID");

                    b.ToTable("MediumType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Artworks.SurfaceType", b =>
                {
                    b.Property<int>("SurfaceTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SurfaceTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SurfaceTypeID");

                    b.ToTable("SurfaceType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Bookings.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BookingNotificationID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("BookingNotificationID");

                    b.HasIndex("PaymentID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Bookings.BookingNotification", b =>
                {
                    b.Property<int>("BookingNotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookNotificationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingNotificationID");

                    b.ToTable("BookingNotification");
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

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Payments.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("PaymentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentStatusID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentTypeID")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("PaymentStatusID");

                    b.HasIndex("PaymentTypeID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Payments.PaymentStatus", b =>
                {
                    b.Property<int>("PaymentStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PaymentStatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentStatusID");

                    b.ToTable("PaymentStatus");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Payments.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PaymentTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeID");

                    b.ToTable("PaymentType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.ArtClass", b =>
                {
                    b.HasOne("BinaryBrainsAPI.Entities.ArtClasses.ArtClassAnnouncement", "ArtClassAnnouncement")
                        .WithMany()
                        .HasForeignKey("ArtClassAnnouncementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.ArtClasses.ArtClassType", "ArtClassType")
                        .WithMany()
                        .HasForeignKey("ArtClassTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.ArtClasses.ClassTeacher", "ClassTeacher")
                        .WithMany()
                        .HasForeignKey("ClassTeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Exhibitions.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Exhibitions.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArtClassAnnouncement");

                    b.Navigation("ArtClassType");

                    b.Navigation("ClassTeacher");

                    b.Navigation("Organisation");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.ClassTeacher", b =>
                {
                    b.HasOne("BinaryBrainsAPI.Entities.ArtClasses.TeacherType", "TeacherType")
                        .WithMany()
                        .HasForeignKey("TeacherTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.ArtClasses.Feedback", b =>
                {
                    b.HasOne("BinaryBrainsAPI.Entities.ArtClasses.ArtClass", "ArtClass")
                        .WithMany()
                        .HasForeignKey("ArtClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArtClass");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Artworks.Artwork", b =>
                {
                    b.HasOne("BinaryBrainsAPI.Entities.Artworks.ArtworkDimension", "ArtworkDimension")
                        .WithMany()
                        .HasForeignKey("ArtworkDimensionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Artworks.ArtworkStatus", "ArtworkStatus")
                        .WithMany()
                        .HasForeignKey("ArtworkStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Artworks.MediumType", "MediumType")
                        .WithMany()
                        .HasForeignKey("MediumTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Artworks.SurfaceType", "SurfaceType")
                        .WithMany()
                        .HasForeignKey("SurfaceTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArtworkDimension");

                    b.Navigation("ArtworkStatus");

                    b.Navigation("MediumType");

                    b.Navigation("SurfaceType");
                });

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Bookings.Booking", b =>
                {
                    b.HasOne("BinaryBrainsAPI.Entities.Bookings.BookingNotification", "BookingNotification")
                        .WithMany()
                        .HasForeignKey("BookingNotificationID");

                    b.HasOne("BinaryBrainsAPI.Entities.Payments.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingNotification");

                    b.Navigation("Payment");
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

            modelBuilder.Entity("BinaryBrainsAPI.Entities.Payments.Payment", b =>
                {
                    b.HasOne("BinaryBrainsAPI.Entities.Payments.PaymentStatus", "PaymentStatus")
                        .WithMany()
                        .HasForeignKey("PaymentStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BinaryBrainsAPI.Entities.Payments.PaymentType", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentStatus");

                    b.Navigation("PaymentType");
                });
#pragma warning restore 612, 618
        }
    }
}
