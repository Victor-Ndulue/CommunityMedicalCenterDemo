﻿// <auto-generated />
using System;
using CMCDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMCDemo.Persistence.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230608220724_update5")]
    partial class update5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CMCDemo.Domain.Entities.Community_Medical_Centers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalCenterAddress_Id")
                        .HasColumnType("int");

                    b.Property<string>("MedicalCenterManager")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Community_Medical_Centers");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DepartmentChief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MedicalCenterId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalCenter_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicalCenterId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.MedicalCenterAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Landmark")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("PostCode")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("MedicalCenterAddress");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.ProfessionalStaff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateBirthed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateJoinedCenter")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLeftCenter")
                        .HasColumnType("datetime2");

                    b.Property<int>("Department_Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int?>("MedicalCenterId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalCenter_Id")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffAddress_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Department_Id");

                    b.HasIndex("MedicalCenterId");

                    b.HasIndex("StaffAddress_Id");

                    b.ToTable("ProfessionalStaffs");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.Ref_Disciplines", b =>
                {
                    b.Property<int>("Ref_DisciplinesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ref_DisciplinesId"));

                    b.Property<DateTime?>("DateObtained")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("DisciplinesDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisciplinesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessionalStaff_Id")
                        .HasColumnType("int");

                    b.HasKey("Ref_DisciplinesId");

                    b.HasIndex("ProfessionalStaff_Id");

                    b.ToTable("Ref_Disciplines");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.StaffAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Landmark")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("PostCode")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("StaffAddresses");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.Community_Medical_Centers", b =>
                {
                    b.HasOne("CMCDemo.Domain.Entities.MedicalCenterAddress", "Address")
                        .WithMany("MedicalCenters")
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.Department", b =>
                {
                    b.HasOne("CMCDemo.Domain.Entities.Community_Medical_Centers", "MedicalCenter")
                        .WithMany("Departments")
                        .HasForeignKey("MedicalCenterId");

                    b.Navigation("MedicalCenter");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.ProfessionalStaff", b =>
                {
                    b.HasOne("CMCDemo.Domain.Entities.Department", "Department")
                        .WithMany("ProfessionalStaff")
                        .HasForeignKey("Department_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CMCDemo.Domain.Entities.Community_Medical_Centers", "MedicalCenter")
                        .WithMany("Staffs")
                        .HasForeignKey("MedicalCenterId");

                    b.HasOne("CMCDemo.Domain.Entities.StaffAddress", "StaffAddress")
                        .WithMany("ProfessionalStaff")
                        .HasForeignKey("StaffAddress_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("MedicalCenter");

                    b.Navigation("StaffAddress");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.Ref_Disciplines", b =>
                {
                    b.HasOne("CMCDemo.Domain.Entities.ProfessionalStaff", "ProfessionalStaff")
                        .WithMany("Ref_Disciplines")
                        .HasForeignKey("ProfessionalStaff_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfessionalStaff");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.Community_Medical_Centers", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.Department", b =>
                {
                    b.Navigation("ProfessionalStaff");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.MedicalCenterAddress", b =>
                {
                    b.Navigation("MedicalCenters");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.ProfessionalStaff", b =>
                {
                    b.Navigation("Ref_Disciplines");
                });

            modelBuilder.Entity("CMCDemo.Domain.Entities.StaffAddress", b =>
                {
                    b.Navigation("ProfessionalStaff");
                });
#pragma warning restore 612, 618
        }
    }
}
