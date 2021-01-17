﻿// <auto-generated />
using BuisnessServices.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BuisnessServices.Migrations
{
    [DbContext(typeof(GothamContext))]
    [Migration("20210117150600_SecondDB")]
    partial class SecondDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BuisnessServices.Entities.Admin", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Email = "abcd@gmail.com",
                            Password = "abcd"
                        },
                        new
                        {
                            Email = "efgh@gmail.com",
                            Password = "efgh"
                        },
                        new
                        {
                            Email = "ijkl@gmail.com",
                            Password = "ijkl"
                        });
                });

            modelBuilder.Entity("BuisnessServices.Entities.Outlet", b =>
                {
                    b.Property<int>("OutletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<int>("FoodPackets")
                        .HasColumnType("integer");

                    b.Property<string>("FoodType")
                        .HasColumnType("text");

                    b.Property<string>("Landmark")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("RequiredVolunteers")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.HasKey("OutletId");

                    b.ToTable("Outlets");

                    b.HasData(
                        new
                        {
                            OutletId = 1,
                            Date = "19/01/2021",
                            FoodPackets = 78,
                            FoodType = "Non Veg",
                            Landmark = "ABC Store",
                            Name = "Rose",
                            RequiredVolunteers = 7,
                            Street = "ABC"
                        },
                        new
                        {
                            OutletId = 2,
                            Date = "18/01/2021",
                            FoodPackets = 100,
                            FoodType = "Veg",
                            Landmark = "DEF Store",
                            Name = "Lily",
                            RequiredVolunteers = 10,
                            Street = "DEF"
                        },
                        new
                        {
                            OutletId = 3,
                            Date = "18/01/2021",
                            FoodPackets = 110,
                            FoodType = "Both",
                            Landmark = "GHI Store",
                            Name = "Jasmine",
                            RequiredVolunteers = 11,
                            Street = "GHI"
                        },
                        new
                        {
                            OutletId = 4,
                            Date = "17/01/2021",
                            FoodPackets = 200,
                            FoodType = "Veg",
                            Landmark = "JKL Store",
                            Name = "Lavender",
                            RequiredVolunteers = 20,
                            Street = "JKL"
                        },
                        new
                        {
                            OutletId = 5,
                            Date = "17/01/2021",
                            FoodPackets = 400,
                            FoodType = "Veg",
                            Landmark = "MNO Store",
                            Name = "Orchid",
                            RequiredVolunteers = 40,
                            Street = "MNO"
                        });
                });

            modelBuilder.Entity("BuisnessServices.Entities.Volunteers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("OutletId")
                        .HasColumnType("integer");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Volunteers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = "15/01/2021",
                            Name = "Muhsina",
                            OutletId = 1,
                            Phone = 86066244485L,
                            email = "muhsinabinthabdulla@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            Date = "16/01/2021",
                            Name = "Hepzibha",
                            OutletId = 1,
                            Phone = 98204928902L,
                            email = "Hepzibha@gmail.com"
                        },
                        new
                        {
                            Id = 3,
                            Date = "17/01/2021",
                            Name = "Priya",
                            OutletId = 1,
                            Phone = 5864564025L,
                            email = "Prya@gmail.com"
                        },
                        new
                        {
                            Id = 4,
                            Date = "15/01/2021",
                            Name = "Megha",
                            OutletId = 2,
                            Phone = 89208374890L,
                            email = "Megha@gmail.com"
                        },
                        new
                        {
                            Id = 5,
                            Date = "17/01/2021",
                            Name = "Navneeth",
                            OutletId = 5,
                            Phone = 9820328902L,
                            email = "FantomPhreak@gmail.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
