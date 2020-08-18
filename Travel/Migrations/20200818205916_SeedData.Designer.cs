﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20200818205916_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Travel.Models.Travel", b =>
                {
                    b.Property<int>("TravelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Rating");

                    b.Property<string>("Review");

                    b.Property<string>("Topspot");

                    b.HasKey("TravelId");

                    b.ToTable("Travels");

                    b.HasData(
                        new
                        {
                            TravelId = 1,
                            City = "Toyko",
                            Country = "Japan",
                            Rating = 5,
                            Review = "Cherry Blossoms Galore!",
                            Topspot = "Toyko Tower"
                        },
                        new
                        {
                            TravelId = 2,
                            City = "Portland",
                            Country = "USA",
                            Rating = 4,
                            Review = "Beer & Coffee Lovers Paradise",
                            Topspot = "Voodoo Doughnuts"
                        },
                        new
                        {
                            TravelId = 3,
                            City = "Medellin",
                            Country = "Colombia",
                            Rating = 4,
                            Review = "Bachata music",
                            Topspot = "Botero Plaza"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}