using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMCDemo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CMCDemoDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalCenterAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_MedicalCenterAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_StaffAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Community_Medical_Centers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalCenterAddress_Id = table.Column<int>(type: "int", nullable: false),
                    MedicalCenterManager = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community_Medical_Centers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Community_Medical_Centers_MedicalCenterAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "MedicalCenterAddress",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalCenter_Id = table.Column<int>(type: "int", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentChief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalCenterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Community_Medical_Centers_MedicalCenterId",
                        column: x => x.MedicalCenterId,
                        principalTable: "Community_Medical_Centers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalCenter_Id = table.Column<int>(type: "int", nullable: false),
                    StaffAddress_Id = table.Column<int>(type: "int", nullable: false),
                    Department_Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    DateBirthed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateJoinedCenter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLeftCenter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalCenterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalStaffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalStaffs_Community_Medical_Centers_MedicalCenterId",
                        column: x => x.MedicalCenterId,
                        principalTable: "Community_Medical_Centers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProfessionalStaffs_Departments_Department_Id",
                        column: x => x.Department_Id,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalStaffs_StaffAddresses_StaffAddress_Id",
                        column: x => x.StaffAddress_Id,
                        principalTable: "StaffAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Disciplines",
                columns: table => new
                {
                    Ref_DisciplinesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionalStaff_Id = table.Column<int>(type: "int", nullable: false),
                    DisciplinesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisciplinesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateObtained = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Disciplines", x => x.Ref_DisciplinesId);
                    table.ForeignKey(
                        name: "FK_Ref_Disciplines_ProfessionalStaffs_ProfessionalStaff_Id",
                        column: x => x.ProfessionalStaff_Id,
                        principalTable: "ProfessionalStaffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Community_Medical_Centers_AddressId",
                table: "Community_Medical_Centers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MedicalCenterId",
                table: "Departments",
                column: "MedicalCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalStaffs_Department_Id",
                table: "ProfessionalStaffs",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalStaffs_MedicalCenterId",
                table: "ProfessionalStaffs",
                column: "MedicalCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalStaffs_StaffAddress_Id",
                table: "ProfessionalStaffs",
                column: "StaffAddress_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Disciplines_ProfessionalStaff_Id",
                table: "Ref_Disciplines",
                column: "ProfessionalStaff_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ref_Disciplines");

            migrationBuilder.DropTable(
                name: "ProfessionalStaffs");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "StaffAddresses");

            migrationBuilder.DropTable(
                name: "Community_Medical_Centers");

            migrationBuilder.DropTable(
                name: "MedicalCenterAddress");
        }
    }
}
