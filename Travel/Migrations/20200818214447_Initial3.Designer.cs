﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20200818214447_Initial3")]
    partial class Initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Travel.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Rating");

                    b.Property<string>("Review");

                    b.Property<string>("Topspot");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Toyko",
                            Country = "Japan",
                            Rating = 5,
                            Review = "Cherry Blossoms Galore!",
                            Topspot = "Toyko Tower"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "Portland",
                            Country = "USA",
                            Rating = 4,
                            Review = "Beer & Coffee Lovers Paradise",
                            Topspot = "Voodoo Doughnuts"
                        },
                        new
                        {
                            DestinationId = 3,
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