﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_b2256.Models;

namespace Mission06_b2256.Migrations
{
    [DbContext(typeof(EnterFilmContext))]
    partial class EnterFilmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Mission06_b2256.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

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

                    b.HasKey("FilmID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            FilmID = 1,
                            CategoryID = 4,
                            Director = "Brendan Maher, Mark Levin, Jennifer Flackett",
                            Edited = false,
                            Rating = "PG",
                            Title = "Nim's Island",
                            Year = (ushort)2006
                        },
                        new
                        {
                            FilmID = 2,
                            CategoryID = 6,
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
                            FilmID = 3,
                            CategoryID = 1,
                            Director = "Martin Campbell",
                            Edited = false,
                            Notes = "The best Bond Film",
                            Rating = "PG-13",
                            Title = "Casino Royale",
                            Year = (ushort)2006
                        });
                });

            modelBuilder.Entity("Mission06_b2256.Models.category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "miscellaneous"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission06_b2256.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission06_b2256.Models.category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
