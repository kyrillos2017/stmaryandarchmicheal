﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210620200717_updatefatherandconfessions")]
    partial class updatefatherandconfessions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Core.Entities.Bishop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BishopType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MonasticDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrdinationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Bishop");
                });

            modelBuilder.Entity("Core.Entities.ConfessionCalender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ConfessionsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ConfessionsId");

                    b.ToTable("confessionCalenders");
                });

            modelBuilder.Entity("Core.Entities.Confessions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherId")
                        .HasColumnType("int");

                    b.Property<int?>("FathersId")
                        .HasColumnType("int");

                    b.Property<int?>("FathersId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FathersId");

                    b.HasIndex("FathersId1");

                    b.ToTable("Confessions");
                });

            modelBuilder.Entity("Core.Entities.Fathers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDead")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PriestlyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PriestlyRank")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fathers");
                });

            modelBuilder.Entity("Core.Entities.Live", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("VideoId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Live");
                });

            modelBuilder.Entity("Core.Entities.ConfessionCalender", b =>
                {
                    b.HasOne("Core.Entities.Confessions", null)
                        .WithMany("Calender")
                        .HasForeignKey("ConfessionsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Confessions", b =>
                {
                    b.HasOne("Core.Entities.Fathers", null)
                        .WithMany("Confessions")
                        .HasForeignKey("FathersId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Fathers", "Fathers")
                        .WithMany()
                        .HasForeignKey("FathersId1");

                    b.Navigation("Fathers");
                });

            modelBuilder.Entity("Core.Entities.Confessions", b =>
                {
                    b.Navigation("Calender");
                });

            modelBuilder.Entity("Core.Entities.Fathers", b =>
                {
                    b.Navigation("Confessions");
                });
#pragma warning restore 612, 618
        }
    }
}
