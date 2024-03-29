﻿// <auto-generated />
using System;
using CSVData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSVData.Migrations
{
    [DbContext(typeof(CSVDataContext))]
    partial class CSVDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSVData.Models.Car", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<double>("Price");

                    b.Property<DateTime>("SellDate");

                    b.Property<int>("Year");

                    b.HasKey("ID");

                    b.ToTable("Car");
                });
#pragma warning restore 612, 618
        }
    }
}
