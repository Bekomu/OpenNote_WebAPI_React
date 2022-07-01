﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenNoteAPI.Data;

#nullable disable

namespace OpenNoteAPI.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220701130916_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OpenNoteAPI.Data.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem 1...",
                            CreatedDate = new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2913),
                            ModifiedTime = new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2924),
                            Title = "Samle Note 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Lorem 2...",
                            CreatedDate = new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2929),
                            ModifiedTime = new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2930),
                            Title = "Samle Note 2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Lorem 3...",
                            CreatedDate = new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2932),
                            ModifiedTime = new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2933),
                            Title = "Samle Note 3"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Lorem 4...",
                            CreatedDate = new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2934),
                            ModifiedTime = new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2935),
                            Title = "Samle Note 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
