﻿// <auto-generated />
using System;
using DentalClinic.DB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DentalClinic.DB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221117202925_add_ForeignKeyDoctorScheduleShortName")]
    partial class add_ForeignKeyDoctorScheduleShortName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DentalService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ServiceDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Who");

                    b.ToTable("DentalServices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce4ee6d1-4107-40e5-8c37-b7b5cde90b57"),
                            ServiceDescription = "",
                            ServiceName = "Surgical operations",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1381),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("787c210c-a80e-4f72-9a27-110afc64cb50"),
                            ServiceDescription = "",
                            ServiceName = "Dental implants",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1387),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("07837fb0-ac4a-48a4-bb1b-857e390b30bd"),
                            ServiceDescription = "",
                            ServiceName = "Complete changeover",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1390),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("7fa78735-5b9b-4dc9-a63e-ba7f97a3eb75"),
                            ServiceDescription = "",
                            ServiceName = "Aesthetic fillings",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1393),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("37160c96-7047-4bba-bd61-4fc189770d7f"),
                            ServiceDescription = "",
                            ServiceName = "Veneers",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1409),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("bf298c31-8da2-4f41-84cc-84f51e73d659"),
                            ServiceDescription = "",
                            ServiceName = "Ceramic inlays",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1416),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("3e88462c-97c6-4723-bbdb-96c85bece989"),
                            ServiceDescription = "",
                            ServiceName = "Crowns and bridges",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1419),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("2a5a54b7-8d97-402a-809d-cfae854217fd"),
                            ServiceDescription = "",
                            ServiceName = "Tooth extraction",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1421),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("7389048f-1a85-44dc-ae12-a3b32fad6f2e"),
                            ServiceDescription = "",
                            ServiceName = "Prosthesis",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1424),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("633a5ae3-c7bb-4ced-972e-00d6fe247174"),
                            ServiceDescription = "",
                            ServiceName = "Orthodontic treatment/braces and splints",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1428),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("f2ba2d00-619a-437c-a349-40c4d45b797a"),
                            ServiceDescription = "",
                            ServiceName = "Teeth whitening",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1430),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("06f4fe0a-c6e0-4649-9826-db2e81257b3f"),
                            ServiceDescription = "",
                            ServiceName = "Glass supports",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1433),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        });
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("IsActive")
                        .HasColumnType("tinyint");

                    b.Property<string>("MoreInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Who");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3a0b7851-e0c3-434d-997f-cb89532fc815"),
                            IsActive = (byte)1,
                            MoreInfo = "Doctor Radeva has 5 years of experience as a dentist.",
                            Name = "Dr. Radeva",
                            Qualification = "Dentist",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1224),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        },
                        new
                        {
                            Id = new Guid("19cb11d5-b3ba-45a7-9759-0267acb5dacc"),
                            IsActive = (byte)1,
                            MoreInfo = "Doctor Valeva has 3 years of experience as a оrthodontist.",
                            Name = "Dr. Valeva",
                            Qualification = "Оrthodontist",
                            When = new DateTime(2022, 11, 17, 22, 29, 25, 610, DateTimeKind.Local).AddTicks(1260),
                            Who = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa"
                        });
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DoctorCustomer", b =>
                {
                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId", "CustomerId", "DateTime");

                    b.HasIndex("UserId");

                    b.ToTable("DoctorsCustomers");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DoctorSchedule", b =>
                {
                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ScheduleDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsBusy")
                        .HasColumnType("bit");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DoctorId", "ScheduleDateTime");

                    b.HasIndex("Who");

                    b.ToTable("DoctorsSchedules");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DentalService", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.Doctor", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DoctorCustomer", b =>
                {
                    b.HasOne("DentalClinic.DB.Data.Models.Doctor", "Doctors")
                        .WithMany("DoctorCustomers")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DoctorCustomers_Doctors");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Doctors");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.DoctorSchedule", b =>
                {
                    b.HasOne("DentalClinic.DB.Data.Models.Doctor", "Doctors")
                        .WithMany("DoctorSchedules")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DoctorSchedules_Doctors");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctors");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DentalClinic.DB.Data.Models.Doctor", b =>
                {
                    b.Navigation("DoctorCustomers");

                    b.Navigation("DoctorSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}