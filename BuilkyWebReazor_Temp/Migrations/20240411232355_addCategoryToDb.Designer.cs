﻿// <auto-generated />
using BuilkyWebReazor_Temp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BuilkyWebReazor_Temp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240411232355_addCategoryToDb")]
    partial class addCategoryToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BuilkyWebReazor_Temp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Programming Languages"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Databases"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "DevOps & Agile"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Mobile Development"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
