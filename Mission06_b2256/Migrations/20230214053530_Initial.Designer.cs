﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_b2256.Models;

namespace Mission06_b2256.Migrations
{
    [DbContext(typeof(EnterFilmContext))]
    [Migration("20230214053530_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Mission06_b2256.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            Category = "Family",
                            Director = "Brendan Maher, Mark Levin, Jennifer Flackett",
                            Edited = false,
                            Rating = "PG",
                            Title = "Nim's Island",
                            Year = (ushort)2006
                        },
                        new
                        {
                            ApplicationID = 2,
                            Category = "Miscellaneous",
                            Director = "Bruyn Decker, Luke Maas, Spencer Lyman",
                            Edited = false,
                            LentTo = "Bruyn's Parents",
                            Notes = "A silly homemade film I [Bruyn] made with my cousins at a family reunion",
                            Rating = "NR",
                            Title = "Star Wars: Rise of the Assassins",
                            Year = (ushort)2014
                        },
                        new
                        {
                            ApplicationID = 3,
                            Category = "Action/Adventure",
                            Director = "Martin Campbell",
                            Edited = false,
                            Notes = "The best Bond Film",
                            Rating = "PG-13",
                            Title = "Casino Royale",
                            Year = (ushort)2006
                        });
                });
#pragma warning restore 612, 618
        }
    }
}