﻿// <auto-generated />
using System;
using DataService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataService.Migrations
{
    [DbContext(typeof(GothamContext))]
    [Migration("20210203063836_newdb")]
    partial class newdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DataService.Entities.Admin", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Email = "muhsina-abdulla@gmail.com",
                            Password = "muhsina-abdulla"
                        },
                        new
                        {
                            Email = "tom-hanks@gmail.com",
                            Password = "tom-hanks"
                        },
                        new
                        {
                            Email = "jonna-jinton@gmial.com",
                            Password = "jonna-jinton"
                        });
                });

            modelBuilder.Entity("DataService.Entities.Outlet", b =>
                {
                    b.Property<int>("OutletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("AvailableFoodPackets")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("FoodType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Landmark")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.Property<int>("RequiredVolunteers")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OutletId");

                    b.ToTable("Outlets");
                });

            modelBuilder.Entity("DataService.Entities.Volunteers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("OutletId")
                        .HasColumnType("integer");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OutletId");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("DataService.Entities.Volunteers", b =>
                {
                    b.HasOne("DataService.Entities.Outlet", "Outlet")
                        .WithMany()
                        .HasForeignKey("OutletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Outlet");
                });
#pragma warning restore 612, 618
        }
    }
}
