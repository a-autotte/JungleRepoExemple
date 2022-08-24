﻿// <auto-generated />
using System;
using Jungle.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jungle.Migrations
{
    [DbContext(typeof(JungleDbContext))]
    partial class JungleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Jungle_Models.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Jungle_Models.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("TravelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TravelId");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("Jungle_Models.Models.Guide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TravelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TravelId");

                    b.ToTable("Guide");
                });

            modelBuilder.Entity("Jungle_Models.Models.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Travel");
                });

            modelBuilder.Entity("Jungle_Models.Models.TravelRecommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Attribut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DangerLevel")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TravelId");

                    b.ToTable("TravelRecommendation");
                });

            modelBuilder.Entity("Jungle_Models.Models.Country", b =>
                {
                    b.HasOne("Jungle_Models.Models.Destination", null)
                        .WithMany("Countries")
                        .HasForeignKey("DestinationId");
                });

            modelBuilder.Entity("Jungle_Models.Models.Destination", b =>
                {
                    b.HasOne("Jungle_Models.Models.Travel", null)
                        .WithMany("Destinations")
                        .HasForeignKey("TravelId");
                });

            modelBuilder.Entity("Jungle_Models.Models.Guide", b =>
                {
                    b.HasOne("Jungle_Models.Models.Travel", null)
                        .WithMany("Guides")
                        .HasForeignKey("TravelId");
                });

            modelBuilder.Entity("Jungle_Models.Models.TravelRecommendation", b =>
                {
                    b.HasOne("Jungle_Models.Models.Travel", "Travel")
                        .WithMany()
                        .HasForeignKey("TravelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Travel");
                });

            modelBuilder.Entity("Jungle_Models.Models.Destination", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Jungle_Models.Models.Travel", b =>
                {
                    b.Navigation("Destinations");

                    b.Navigation("Guides");
                });
#pragma warning restore 612, 618
        }
    }
}
