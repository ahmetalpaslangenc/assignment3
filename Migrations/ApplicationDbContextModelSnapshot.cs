﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleRegistrationApp.Data;

#nullable disable

namespace VehicleRegistrationApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("VehicleRegistrationApp.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("VehicleRegistrationApp.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarPlate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GearType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Km")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("VehicleRegistrationApp.Models.Vehicle", b =>
                {
                    b.HasOne("VehicleRegistrationApp.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });
#pragma warning restore 612, 618
        }
    }
}