﻿// <auto-generated />
using System;
using BookFast.Booking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookFast.Booking.Data.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20191105145603_BookingService_001")]
    partial class BookingService_001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookFast.Booking.Data.Models.BookingRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccommodationId");

                    b.Property<string>("AccommodationName")
                        .IsRequired()
                        .HasMaxLength(320);

                    b.Property<DateTimeOffset?>("CanceledOn");

                    b.Property<DateTimeOffset?>("CheckedInOn");

                    b.Property<int>("FacilityId");

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasMaxLength(320);

                    b.Property<DateTimeOffset>("FromDate");

                    b.Property<string>("StreetAddress");

                    b.Property<DateTimeOffset>("ToDate");

                    b.Property<string>("User")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BookingRecords","booking");
                });

            modelBuilder.Entity("BookFast.ReliableEvents.ReliableEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset>("OccurredAt");

                    b.Property<string>("Payload")
                        .IsRequired();

                    b.Property<string>("Tenant")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Events","booking");
                });
#pragma warning restore 612, 618
        }
    }
}
