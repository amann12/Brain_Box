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
    [Migration("20210519122337_studentTable")]
    partial class studentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                });
#pragma warning restore 612, 618
        }
    }
}