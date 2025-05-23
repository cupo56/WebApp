﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iScent.Data;

#nullable disable

namespace iScent.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("iScent.Models.Parfum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Basisnote")
                        .HasColumnType("TEXT");

                    b.Property<string>("Beschreibung")
                        .HasColumnType("TEXT");

                    b.Property<string>("BildUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Herznote")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kopfnote")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marke")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Parfums");
                });
#pragma warning restore 612, 618
        }
    }
}
