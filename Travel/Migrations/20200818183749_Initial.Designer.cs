﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20200818183749_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Travel.Models.Travel", b =>
                {
                    b.Property<int>("TravelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Rating");

                    b.Property<string>("Review");

                    b.Property<string>("TopSpot");

                    b.HasKey("TravelId");

                    b.ToTable("Travels");
                });
#pragma warning restore 612, 618
        }
    }
}