﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PayrollPersonnelManagement.context;

namespace PayrollPersonnelManagement.Infasrtucture.Migrations
{
    [DbContext(typeof(PayrollPersonnelManagementContext))]
    [Migration("20230414132447_AddIsDelete")]
    partial class AddIsDelete
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("PayrollPersonnelManagement.Common.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PhisicalFaceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubdivisionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PhisicalFaceId");

                    b.HasIndex("PostId");

                    b.HasIndex("SubdivisionId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("PayrollPersonnelManagement.Common.OneAccrual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("HoursMonth")
                        .HasColumnName("HoursMonth")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InDate")
                        .HasColumnName("InDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Sum")
                        .HasColumnName("Sum")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("OneAccrual");
                });

            modelBuilder.Entity("PayrollPersonnelManagement.Common.PhisicalFace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnName("DateBirth")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Patronymic")
                        .HasColumnName("Patronymic")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnName("Surname")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("PhisicalFace");
                });

            modelBuilder.Entity("PayrollPersonnelManagement.Common.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<decimal>("Salary")
                        .HasColumnName("Salary")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("PayrollPersonnelManagement.Common.Subdivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Allowance")
                        .HasColumnName("Allowance")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Subdivision");
                });

            modelBuilder.Entity("PayrollPersonnelManagement.Common.Employee", b =>
                {
                    b.HasOne("PayrollPersonnelManagement.Common.PhisicalFace", "PhisicalFace")
                        .WithMany("Employee")
                        .HasForeignKey("PhisicalFaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollPersonnelManagement.Common.Post", "Post")
                        .WithMany("Employee")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollPersonnelManagement.Common.Subdivision", "Subdivision")
                        .WithMany("Employee")
                        .HasForeignKey("SubdivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollPersonnelManagement.Common.OneAccrual", b =>
                {
                    b.HasOne("PayrollPersonnelManagement.Common.Employee", "Employee")
                        .WithMany("OneAccrual")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
