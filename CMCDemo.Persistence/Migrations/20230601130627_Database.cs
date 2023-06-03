using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMCDemo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalStaff_Community_Medical_Centers_MedicalCenterId",
                table: "ProfessionalStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalStaff_Departments_Department_Id",
                table: "ProfessionalStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalStaff_StaffAddress_StaffAddress_Id",
                table: "ProfessionalStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_Ref_Disciplines_ProfessionalStaff_ProfessionalStaff_Id",
                table: "Ref_Disciplines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffAddress",
                table: "StaffAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionalStaff",
                table: "ProfessionalStaff");

            migrationBuilder.RenameTable(
                name: "StaffAddress",
                newName: "StaffAddresses");

            migrationBuilder.RenameTable(
                name: "ProfessionalStaff",
                newName: "ProfessionalStaffs");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionalStaff_StaffAddress_Id",
                table: "ProfessionalStaffs",
                newName: "IX_ProfessionalStaffs_StaffAddress_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionalStaff_MedicalCenterId",
                table: "ProfessionalStaffs",
                newName: "IX_ProfessionalStaffs_MedicalCenterId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionalStaff_Department_Id",
                table: "ProfessionalStaffs",
                newName: "IX_ProfessionalStaffs_Department_Id");

            migrationBuilder.AddColumn<string>(
                name: "BuildingNumber",
                table: "StaffAddresses",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "StaffAddresses",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "StaffAddresses",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Landmark",
                table: "StaffAddresses",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Locality",
                table: "StaffAddresses",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PostCode",
                table: "StaffAddresses",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "StaffAddresses",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "StaffAddresses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffAddresses",
                table: "StaffAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionalStaffs",
                table: "ProfessionalStaffs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppointmentCategory",
                columns: table => new
                {
                    Appointments_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location_Code = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Patient_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentCategory", x => x.Appointments_ID);
                });

            migrationBuilder.CreateTable(
                name: "Appt_Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationDesciption = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appt_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Patient_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medical_Center_ID = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Middle_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentWith = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Other_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Landmark = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    City = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PostCode = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    State = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Patient_ID);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientsPatient_ID = table.Column<int>(type: "int", nullable: true),
                    Ref_Appt_LocationsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Appt_Locations_Ref_Appt_LocationsId",
                        column: x => x.Ref_Appt_LocationsId,
                        principalTable: "Appt_Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientsPatient_ID",
                        column: x => x.PatientsPatient_ID,
                        principalTable: "Patients",
                        principalColumn: "Patient_ID");
                });

            migrationBuilder.CreateTable(
                name: "AppointmentCategoryAppointments",
                columns: table => new
                {
                    AppointmentCategoryAppointments_ID = table.Column<int>(type: "int", nullable: false),
                    AppointmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentCategoryAppointments", x => new { x.AppointmentCategoryAppointments_ID, x.AppointmentsId });
                    table.ForeignKey(
                        name: "FK_AppointmentCategoryAppointments_AppointmentCategory_AppointmentCategoryAppointments_ID",
                        column: x => x.AppointmentCategoryAppointments_ID,
                        principalTable: "AppointmentCategory",
                        principalColumn: "Appointments_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentCategoryAppointments_Appointments_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "staff_In_Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Appointment_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Staff_ID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staff_In_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_staff_In_Appointments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_staff_In_Appointments_ProfessionalStaffs_Staff_ID",
                        column: x => x.Staff_ID,
                        principalTable: "ProfessionalStaffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentCategoryAppointments_AppointmentsId",
                table: "AppointmentCategoryAppointments",
                column: "AppointmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientsPatient_ID",
                table: "Appointments",
                column: "PatientsPatient_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Ref_Appt_LocationsId",
                table: "Appointments",
                column: "Ref_Appt_LocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_staff_In_Appointments_AppointmentId",
                table: "staff_In_Appointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_staff_In_Appointments_Staff_ID",
                table: "staff_In_Appointments",
                column: "Staff_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalStaffs_Community_Medical_Centers_MedicalCenterId",
                table: "ProfessionalStaffs",
                column: "MedicalCenterId",
                principalTable: "Community_Medical_Centers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalStaffs_Departments_Department_Id",
                table: "ProfessionalStaffs",
                column: "Department_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalStaffs_StaffAddresses_StaffAddress_Id",
                table: "ProfessionalStaffs",
                column: "StaffAddress_Id",
                principalTable: "StaffAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ref_Disciplines_ProfessionalStaffs_ProfessionalStaff_Id",
                table: "Ref_Disciplines",
                column: "ProfessionalStaff_Id",
                principalTable: "ProfessionalStaffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalStaffs_Community_Medical_Centers_MedicalCenterId",
                table: "ProfessionalStaffs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalStaffs_Departments_Department_Id",
                table: "ProfessionalStaffs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessionalStaffs_StaffAddresses_StaffAddress_Id",
                table: "ProfessionalStaffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Ref_Disciplines_ProfessionalStaffs_ProfessionalStaff_Id",
                table: "Ref_Disciplines");

            migrationBuilder.DropTable(
                name: "AppointmentCategoryAppointments");

            migrationBuilder.DropTable(
                name: "staff_In_Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentCategory");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Appt_Locations");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffAddresses",
                table: "StaffAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessionalStaffs",
                table: "ProfessionalStaffs");

            migrationBuilder.DropColumn(
                name: "BuildingNumber",
                table: "StaffAddresses");

            migrationBuilder.DropColumn(
                name: "City",
                table: "StaffAddresses");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "StaffAddresses");

            migrationBuilder.DropColumn(
                name: "Landmark",
                table: "StaffAddresses");

            migrationBuilder.DropColumn(
                name: "Locality",
                table: "StaffAddresses");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "StaffAddresses");

            migrationBuilder.DropColumn(
                name: "State",
                table: "StaffAddresses");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "StaffAddresses");

            migrationBuilder.RenameTable(
                name: "StaffAddresses",
                newName: "StaffAddress");

            migrationBuilder.RenameTable(
                name: "ProfessionalStaffs",
                newName: "ProfessionalStaff");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionalStaffs_StaffAddress_Id",
                table: "ProfessionalStaff",
                newName: "IX_ProfessionalStaff_StaffAddress_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionalStaffs_MedicalCenterId",
                table: "ProfessionalStaff",
                newName: "IX_ProfessionalStaff_MedicalCenterId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessionalStaffs_Department_Id",
                table: "ProfessionalStaff",
                newName: "IX_ProfessionalStaff_Department_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffAddress",
                table: "StaffAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessionalStaff",
                table: "ProfessionalStaff",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalStaff_Community_Medical_Centers_MedicalCenterId",
                table: "ProfessionalStaff",
                column: "MedicalCenterId",
                principalTable: "Community_Medical_Centers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalStaff_Departments_Department_Id",
                table: "ProfessionalStaff",
                column: "Department_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessionalStaff_StaffAddress_StaffAddress_Id",
                table: "ProfessionalStaff",
                column: "StaffAddress_Id",
                principalTable: "StaffAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ref_Disciplines_ProfessionalStaff_ProfessionalStaff_Id",
                table: "Ref_Disciplines",
                column: "ProfessionalStaff_Id",
                principalTable: "ProfessionalStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
