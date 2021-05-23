﻿// <auto-generated />
using System;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExaminationSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210519132524_courseTable")]
    partial class courseTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExaminationSystem.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cDuration");

                    b.Property<int>("cId");

                    b.Property<string>("cName");

                    b.Property<string>("cType");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            cDuration = "4 years",
                            cId = 1,
                            cName = "Btech",
                            cType = "Regular"
                        });
                });

            modelBuilder.Entity("ExaminationSystem.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("sAddress");

                    b.Property<int?>("sBloodGroup");

                    b.Property<DateTime>("sDOB");

                    b.Property<string>("sEmailId");

                    b.Property<string>("sFatherName");

                    b.Property<int?>("sGender");

                    b.Property<int>("sId");

                    b.Property<long>("sMobileNumber");

                    b.Property<string>("sMotherName");

                    b.Property<string>("sName");

                    b.Property<long>("sRollNumber");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            sAddress = "Shankar Nagar",
                            sBloodGroup = 1,
                            sDOB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sEmailId = "amangn12@gmail.com",
                            sFatherName = "Avinash Gupta",
                            sGender = 0,
                            sId = 1,
                            sMobileNumber = 7289868901L,
                            sMotherName = "Manisha Gupta",
                            sName = "Aman",
                            sRollNumber = 1900L
                        });
                });

            modelBuilder.Entity("ExaminationSystem.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tAddress");

                    b.Property<int?>("tBloodGroup");

                    b.Property<string>("tEmailId");

                    b.Property<int?>("tGender");

                    b.Property<int>("tId");

                    b.Property<long>("tMobileNumber");

                    b.Property<string>("tName");

                    b.Property<string>("tQualification");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            tAddress = "Noida",
                            tBloodGroup = 4,
                            tEmailId = "dhruv.cs@gmail.com",
                            tGender = 0,
                            tId = 1,
                            tMobileNumber = 987654321L,
                            tName = "Dhruv",
                            tQualification = "PHD"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}