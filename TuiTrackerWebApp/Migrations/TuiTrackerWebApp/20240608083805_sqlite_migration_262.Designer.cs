﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TuiTrackerWebApp.Data;

#nullable disable

namespace TuiTrackerWebApp.Migrations.TuiTrackerWebApp
{
    [DbContext(typeof(TuiTrackerWebAppContext))]
    [Migration("20240608083805_sqlite_migration_262")]
    partial class sqlite_migration_262
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("TuiTrackerCMS.Models.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountsContactId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSupplier")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NZBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PrimaryContactId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AccountsContactId");

                    b.HasIndex("PrimaryContactId");

                    b.ToTable("Business");
                });

            modelBuilder.Entity("TuiTrackerCMS.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BusinessId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("TuiTrackerCMS.Models.Business", b =>
                {
                    b.HasOne("TuiTrackerCMS.Models.Contact", "AccountsContact")
                        .WithMany()
                        .HasForeignKey("AccountsContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TuiTrackerCMS.Models.Contact", "PrimaryContact")
                        .WithMany()
                        .HasForeignKey("PrimaryContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountsContact");

                    b.Navigation("PrimaryContact");
                });

            modelBuilder.Entity("TuiTrackerCMS.Models.Contact", b =>
                {
                    b.HasOne("TuiTrackerCMS.Models.Business", null)
                        .WithMany("AdditionalContacts")
                        .HasForeignKey("BusinessId");
                });

            modelBuilder.Entity("TuiTrackerCMS.Models.Business", b =>
                {
                    b.Navigation("AdditionalContacts");
                });
#pragma warning restore 612, 618
        }
    }
}
