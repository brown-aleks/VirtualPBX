﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VirtualPBX.DAL.DataAccess;

#nullable disable

namespace VirtualPBX.DAL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230428073219_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VirtualPBX.DAL.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.CallLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly>("CallDuration")
                        .HasColumnType("time without time zone");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IncomingCallKey")
                        .HasColumnType("integer");

                    b.Property<int>("OutgoingCallKey")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IncomingCallKey");

                    b.HasIndex("OutgoingCallKey");

                    b.ToTable("CallLogs");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("ProfileId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("PersonId")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("RateId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("RateId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<int>("EmailId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("EmailId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.CallLog", b =>
                {
                    b.HasOne("VirtualPBX.DAL.Models.Phone", "IncomingCall")
                        .WithMany("IncomingCalls")
                        .HasForeignKey("IncomingCallKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualPBX.DAL.Models.Phone", "OutgoingCall")
                        .WithMany("OutgoingCalls")
                        .HasForeignKey("OutgoingCallKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncomingCall");

                    b.Navigation("OutgoingCall");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Person", b =>
                {
                    b.HasOne("VirtualPBX.DAL.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Phone", b =>
                {
                    b.HasOne("VirtualPBX.DAL.Models.Person", null)
                        .WithMany("Phones")
                        .HasForeignKey("PersonId");

                    b.HasOne("VirtualPBX.DAL.Models.Rate", "Rate")
                        .WithMany("Phones")
                        .HasForeignKey("RateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rate");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Profile", b =>
                {
                    b.HasOne("VirtualPBX.DAL.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualPBX.DAL.Models.Email", "Email")
                        .WithMany()
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Email");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Person", b =>
                {
                    b.Navigation("Phones");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Phone", b =>
                {
                    b.Navigation("IncomingCalls");

                    b.Navigation("OutgoingCalls");
                });

            modelBuilder.Entity("VirtualPBX.DAL.Models.Rate", b =>
                {
                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
