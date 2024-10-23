﻿// <auto-generated />
using System;
using K8S.DriverAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace K8S.DriverAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241023071956_Initial-Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("K8S.DriverAPI.Models.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverNumber")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c74073d8-e3e4-472e-a57d-83127fbf8474"),
                            AddedDate = new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9315),
                            DateOfBirth = new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 44,
                            FirstName = "Lewis",
                            LastName = "Hamilton",
                            Status = 1,
                            UpdatedDate = new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9315)
                        },
                        new
                        {
                            Id = new Guid("1e200a4b-5fae-46b7-b78f-2caa5b1fc133"),
                            AddedDate = new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9322),
                            DateOfBirth = new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 33,
                            FirstName = "Max",
                            LastName = "Verstappen",
                            Status = 1,
                            UpdatedDate = new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9322)
                        },
                        new
                        {
                            Id = new Guid("ebd19528-5541-4e20-b277-ee502f1e35bf"),
                            AddedDate = new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9324),
                            DateOfBirth = new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverNumber = 16,
                            FirstName = "Charles",
                            LastName = "Leclerc",
                            Status = 1,
                            UpdatedDate = new DateTime(2024, 10, 23, 7, 19, 56, 133, DateTimeKind.Utc).AddTicks(9324)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}