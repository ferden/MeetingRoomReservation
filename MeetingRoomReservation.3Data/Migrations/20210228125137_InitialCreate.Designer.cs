﻿// <auto-generated />
using System;
using MeetingRoomReservation._3Data.Concrete.EntityFrameWork.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeetingRoomReservation._3Data.Migrations
{
    [DbContext(typeof(MeetingRoomReservationContext))]
    [Migration("20210228125137_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeetingRoomReservation._2Entities.Concrete.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Note")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "initial",
                            CreatedDate = new DateTime(2021, 2, 28, 15, 51, 36, 939, DateTimeKind.Local).AddTicks(7523),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Initial",
                            ModifiedDate = new DateTime(2021, 2, 28, 15, 51, 36, 939, DateTimeKind.Local).AddTicks(8439),
                            Name = "TOBB AZ Yerleşkesi",
                            Note = "Initial"
                        });
                });

            modelBuilder.Entity("MeetingRoomReservation._2Entities.Concrete.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MeetingDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeetingEndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MeetingNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeetingRoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("MeetingStartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MeetingSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeetingType")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MeetingRoomID");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("MeetingRoomReservation._2Entities.Concrete.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<bool>("Computer")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedByName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonCapacity")
                        .HasColumnType("int");

                    b.Property<int>("PlaceID")
                        .HasColumnType("int");

                    b.Property<bool>("Projection")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("WebConference")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlaceID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("MeetingRoomReservation._2Entities.Concrete.Reservation", b =>
                {
                    b.HasOne("MeetingRoomReservation._2Entities.Concrete.Room", "MeetingRoom")
                        .WithMany("Reservations")
                        .HasForeignKey("MeetingRoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeetingRoom");
                });

            modelBuilder.Entity("MeetingRoomReservation._2Entities.Concrete.Room", b =>
                {
                    b.HasOne("MeetingRoomReservation._2Entities.Concrete.Place", "Place")
                        .WithMany("Rooms")
                        .HasForeignKey("PlaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("MeetingRoomReservation._2Entities.Concrete.Place", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("MeetingRoomReservation._2Entities.Concrete.Room", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
