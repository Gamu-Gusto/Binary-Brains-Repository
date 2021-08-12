﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BinaryBrainsAPI.Migrations
{
    public partial class FullMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
                columns: table => new
                {
                    ApplicationStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationStatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatus", x => x.ApplicationStatusID);
                });

            migrationBuilder.CreateTable(
                name: "ArtClassAnnouncement",
                columns: table => new
                {
                    ArtClassAnnouncementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtClassAnnouncementDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtClassAnnouncement", x => x.ArtClassAnnouncementID);
                });

            migrationBuilder.CreateTable(
                name: "ArtClassType",
                columns: table => new
                {
                    ArtClassTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtClassTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtClassType", x => x.ArtClassTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ArtworkDimension",
                columns: table => new
                {
                    ArtworkDimensionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtworkDimensionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkDimension", x => x.ArtworkDimensionID);
                });

            migrationBuilder.CreateTable(
                name: "ArtworkStatus",
                columns: table => new
                {
                    ArtworkStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtworkStatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkStatus", x => x.ArtworkStatusID);
                });

            migrationBuilder.CreateTable(
                name: "BookingNotification",
                columns: table => new
                {
                    BookingNotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookNotificationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingNotification", x => x.BookingNotificationID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "ExhibitionAnnouncement",
                columns: table => new
                {
                    ExhibitionAnnouncementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExhibitionAnnouncementDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExhibitionAnnouncement", x => x.ExhibitionAnnouncementID);
                });

            migrationBuilder.CreateTable(
                name: "ExhibitionType",
                columns: table => new
                {
                    ExhibitionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExhibitionTypeDecription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExhibitionType", x => x.ExhibitionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "FrameColour",
                columns: table => new
                {
                    FrameColourID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrameColourDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameColour", x => x.FrameColourID);
                });

            migrationBuilder.CreateTable(
                name: "InvitationStatus",
                columns: table => new
                {
                    InvitationStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvitationStatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvitationStatus", x => x.InvitationStatusID);
                });

            migrationBuilder.CreateTable(
                name: "MediumType",
                columns: table => new
                {
                    MediumTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediumTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediumType", x => x.MediumTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Organisation",
                columns: table => new
                {
                    OrganisationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganisationalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganisationalName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisation", x => x.OrganisationID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    PaymentStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentStatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.PaymentStatusID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    PaymentTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.PaymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Privileges",
                columns: table => new
                {
                    PrivilegesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Privilege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivilegeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.PrivilegesID);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleType",
                columns: table => new
                {
                    ScheduleTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleType", x => x.ScheduleTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ShowcaseArtwork",
                columns: table => new
                {
                    ShowcaseArtworkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowCaseTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowCaseImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowcaseArtwork", x => x.ShowcaseArtworkID);
                });

            migrationBuilder.CreateTable(
                name: "SurfaceType",
                columns: table => new
                {
                    SurfaceTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurfaceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurfaceType", x => x.SurfaceTypeID);
                });

            migrationBuilder.CreateTable(
                name: "TeacherType",
                columns: table => new
                {
                    TeacherTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherType", x => x.TeacherTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    VenueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.VenueID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                    table.ForeignKey(
                        name: "FK_Province_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    PaymentDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentTypeID = table.Column<int>(type: "int", nullable: false),
                    PaymentStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentStatus_PaymentStatusID",
                        column: x => x.PaymentStatusID,
                        principalTable: "PaymentStatus",
                        principalColumn: "PaymentStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentType_PaymentTypeID",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentType",
                        principalColumn: "PaymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    UserTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivilegesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.UserTypeID);
                    table.ForeignKey(
                        name: "FK_UserType_Privileges_PrivilegesID",
                        column: x => x.PrivilegesID,
                        principalTable: "Privileges",
                        principalColumn: "PrivilegesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_Schedule_ScheduleType_ScheduleTypeID",
                        column: x => x.ScheduleTypeID,
                        principalTable: "ScheduleType",
                        principalColumn: "ScheduleTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artwork",
                columns: table => new
                {
                    ArtworkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtworkTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtworkPrice = table.Column<double>(type: "float", nullable: false),
                    ArtworkPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfaceTypeID = table.Column<int>(type: "int", nullable: false),
                    MediumTypeID = table.Column<int>(type: "int", nullable: false),
                    ArtworkStatusID = table.Column<int>(type: "int", nullable: false),
                    ArtworkDimensionID = table.Column<int>(type: "int", nullable: false),
                    FrameColourID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artwork", x => x.ArtworkID);
                    table.ForeignKey(
                        name: "FK_Artwork_ArtworkDimension_ArtworkDimensionID",
                        column: x => x.ArtworkDimensionID,
                        principalTable: "ArtworkDimension",
                        principalColumn: "ArtworkDimensionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artwork_ArtworkStatus_ArtworkStatusID",
                        column: x => x.ArtworkStatusID,
                        principalTable: "ArtworkStatus",
                        principalColumn: "ArtworkStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artwork_FrameColour_FrameColourID",
                        column: x => x.FrameColourID,
                        principalTable: "FrameColour",
                        principalColumn: "FrameColourID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artwork_MediumType_MediumTypeID",
                        column: x => x.MediumTypeID,
                        principalTable: "MediumType",
                        principalColumn: "MediumTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artwork_SurfaceType_SurfaceTypeID",
                        column: x => x.SurfaceTypeID,
                        principalTable: "SurfaceType",
                        principalColumn: "SurfaceTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassTeacher",
                columns: table => new
                {
                    ClassTeacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    TeacherTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTeacher", x => x.ClassTeacherID);
                    table.ForeignKey(
                        name: "FK_ClassTeacher_TeacherType_TeacherTypeID",
                        column: x => x.TeacherTypeID,
                        principalTable: "TeacherType",
                        principalColumn: "TeacherTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ProvinceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exhibition",
                columns: table => new
                {
                    ExhibitionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExhibitionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExhibitionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exhibition_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionTypeID = table.Column<int>(type: "int", nullable: false),
                    ScheduleID = table.Column<int>(type: "int", nullable: false),
                    OrganisationID = table.Column<int>(type: "int", nullable: false),
                    ExhibitionAnnouncementID = table.Column<int>(type: "int", nullable: false),
                    VenueID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibition", x => x.ExhibitionID);
                    table.ForeignKey(
                        name: "FK_Exhibition_ExhibitionAnnouncement_ExhibitionAnnouncementID",
                        column: x => x.ExhibitionAnnouncementID,
                        principalTable: "ExhibitionAnnouncement",
                        principalColumn: "ExhibitionAnnouncementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exhibition_ExhibitionType_ExhibitionTypeID",
                        column: x => x.ExhibitionTypeID,
                        principalTable: "ExhibitionType",
                        principalColumn: "ExhibitionTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exhibition_Organisation_OrganisationID",
                        column: x => x.OrganisationID,
                        principalTable: "Organisation",
                        principalColumn: "OrganisationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exhibition_Schedule_ScheduleID",
                        column: x => x.ScheduleID,
                        principalTable: "Schedule",
                        principalColumn: "ScheduleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exhibition_Venue_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venue",
                        principalColumn: "VenueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtClasse",
                columns: table => new
                {
                    ArtClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtClassDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtClassStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArtClassEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassLimit = table.Column<int>(type: "int", nullable: false),
                    RefundDayLimit = table.Column<int>(type: "int", nullable: false),
                    ArtClassTypeID = table.Column<int>(type: "int", nullable: false),
                    VenueID = table.Column<int>(type: "int", nullable: false),
                    ClassPrice = table.Column<double>(type: "float", nullable: false),
                    ClassTeacherID = table.Column<int>(type: "int", nullable: false),
                    ArtClassAnnouncementID = table.Column<int>(type: "int", nullable: false),
                    OrganisationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtClasse", x => x.ArtClassID);
                    table.ForeignKey(
                        name: "FK_ArtClasse_ArtClassAnnouncement_ArtClassAnnouncementID",
                        column: x => x.ArtClassAnnouncementID,
                        principalTable: "ArtClassAnnouncement",
                        principalColumn: "ArtClassAnnouncementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtClasse_ArtClassType_ArtClassTypeID",
                        column: x => x.ArtClassTypeID,
                        principalTable: "ArtClassType",
                        principalColumn: "ArtClassTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtClasse_ClassTeacher_ClassTeacherID",
                        column: x => x.ClassTeacherID,
                        principalTable: "ClassTeacher",
                        principalColumn: "ClassTeacherID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtClasse_Organisation_OrganisationID",
                        column: x => x.OrganisationID,
                        principalTable: "Organisation",
                        principalColumn: "OrganisationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtClasse_Venue_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venue",
                        principalColumn: "VenueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suburb",
                columns: table => new
                {
                    SuburbID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuburbDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suburb", x => x.SuburbID);
                    table.ForeignKey(
                        name: "FK_Suburb_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExhibitionApplication",
                columns: table => new
                {
                    ExhibitionApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExhibitionPicture1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExhibitionPicture2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExhibitionPicture3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExhibitionID = table.Column<int>(type: "int", nullable: false),
                    ApplicationStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExhibitionApplication", x => x.ExhibitionApplicationID);
                    table.ForeignKey(
                        name: "FK_ExhibitionApplication_ApplicationStatus_ApplicationStatusID",
                        column: x => x.ApplicationStatusID,
                        principalTable: "ApplicationStatus",
                        principalColumn: "ApplicationStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExhibitionApplication_Exhibition_ExhibitionID",
                        column: x => x.ExhibitionID,
                        principalTable: "Exhibition",
                        principalColumn: "ExhibitionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invitation",
                columns: table => new
                {
                    InvitationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvitationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvitationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExhibitionID = table.Column<int>(type: "int", nullable: false),
                    InvitationStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitation", x => x.InvitationID);
                    table.ForeignKey(
                        name: "FK_Invitation_Exhibition_ExhibitionID",
                        column: x => x.ExhibitionID,
                        principalTable: "Exhibition",
                        principalColumn: "ExhibitionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invitation_InvitationStatus_InvitationStatusID",
                        column: x => x.InvitationStatusID,
                        principalTable: "InvitationStatus",
                        principalColumn: "InvitationStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherRating = table.Column<double>(type: "float", nullable: false),
                    DifficultyRating = table.Column<double>(type: "float", nullable: false),
                    OverallRating = table.Column<double>(type: "float", nullable: false),
                    ArtClassID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackID);
                    table.ForeignKey(
                        name: "FK_Feedback_ArtClasse_ArtClassID",
                        column: x => x.ArtClassID,
                        principalTable: "ArtClasse",
                        principalColumn: "ArtClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPostalCode = table.Column<int>(type: "int", nullable: false),
                    UserProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTypeID = table.Column<int>(type: "int", nullable: false),
                    SuburbID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Suburb_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburb",
                        principalColumn: "SuburbID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserType",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingNotificationID = table.Column<int>(type: "int", nullable: true),
                    PaymentID = table.Column<int>(type: "int", nullable: false),
                    ArtClassID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Booking_ArtClasse_ArtClassID",
                        column: x => x.ArtClassID,
                        principalTable: "ArtClasse",
                        principalColumn: "ArtClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_BookingNotification_BookingNotificationID",
                        column: x => x.BookingNotificationID,
                        principalTable: "BookingNotification",
                        principalColumn: "BookingNotificationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Payment_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payment",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtClasse_ArtClassAnnouncementID",
                table: "ArtClasse",
                column: "ArtClassAnnouncementID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtClasse_ArtClassTypeID",
                table: "ArtClasse",
                column: "ArtClassTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtClasse_ClassTeacherID",
                table: "ArtClasse",
                column: "ClassTeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtClasse_OrganisationID",
                table: "ArtClasse",
                column: "OrganisationID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtClasse_VenueID",
                table: "ArtClasse",
                column: "VenueID");

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_ArtworkDimensionID",
                table: "Artwork",
                column: "ArtworkDimensionID");

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_ArtworkStatusID",
                table: "Artwork",
                column: "ArtworkStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_FrameColourID",
                table: "Artwork",
                column: "FrameColourID");

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_MediumTypeID",
                table: "Artwork",
                column: "MediumTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_SurfaceTypeID",
                table: "Artwork",
                column: "SurfaceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ArtClassID",
                table: "Booking",
                column: "ArtClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BookingNotificationID",
                table: "Booking",
                column: "BookingNotificationID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_PaymentID",
                table: "Booking",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserID",
                table: "Booking",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceID",
                table: "City",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassTeacher_TeacherTypeID",
                table: "ClassTeacher",
                column: "TeacherTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Exhibition_ExhibitionAnnouncementID",
                table: "Exhibition",
                column: "ExhibitionAnnouncementID");

            migrationBuilder.CreateIndex(
                name: "IX_Exhibition_ExhibitionTypeID",
                table: "Exhibition",
                column: "ExhibitionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Exhibition_OrganisationID",
                table: "Exhibition",
                column: "OrganisationID");

            migrationBuilder.CreateIndex(
                name: "IX_Exhibition_ScheduleID",
                table: "Exhibition",
                column: "ScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_Exhibition_VenueID",
                table: "Exhibition",
                column: "VenueID");

            migrationBuilder.CreateIndex(
                name: "IX_ExhibitionApplication_ApplicationStatusID",
                table: "ExhibitionApplication",
                column: "ApplicationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ExhibitionApplication_ExhibitionID",
                table: "ExhibitionApplication",
                column: "ExhibitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_ArtClassID",
                table: "Feedback",
                column: "ArtClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_ExhibitionID",
                table: "Invitation",
                column: "ExhibitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_InvitationStatusID",
                table: "Invitation",
                column: "InvitationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentStatusID",
                table: "Payment",
                column: "PaymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentTypeID",
                table: "Payment",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Province_CountryID",
                table: "Province",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_ScheduleTypeID",
                table: "Schedule",
                column: "ScheduleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Suburb_CityID",
                table: "Suburb",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_User_SuburbID",
                table: "User",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeID",
                table: "User",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserType_PrivilegesID",
                table: "UserType",
                column: "PrivilegesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artwork");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "ExhibitionApplication");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Invitation");

            migrationBuilder.DropTable(
                name: "ShowcaseArtwork");

            migrationBuilder.DropTable(
                name: "ArtworkDimension");

            migrationBuilder.DropTable(
                name: "ArtworkStatus");

            migrationBuilder.DropTable(
                name: "FrameColour");

            migrationBuilder.DropTable(
                name: "MediumType");

            migrationBuilder.DropTable(
                name: "SurfaceType");

            migrationBuilder.DropTable(
                name: "BookingNotification");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ApplicationStatus");

            migrationBuilder.DropTable(
                name: "ArtClasse");

            migrationBuilder.DropTable(
                name: "Exhibition");

            migrationBuilder.DropTable(
                name: "InvitationStatus");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "Suburb");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "ArtClassAnnouncement");

            migrationBuilder.DropTable(
                name: "ArtClassType");

            migrationBuilder.DropTable(
                name: "ClassTeacher");

            migrationBuilder.DropTable(
                name: "ExhibitionAnnouncement");

            migrationBuilder.DropTable(
                name: "ExhibitionType");

            migrationBuilder.DropTable(
                name: "Organisation");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Venue");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.DropTable(
                name: "TeacherType");

            migrationBuilder.DropTable(
                name: "ScheduleType");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
