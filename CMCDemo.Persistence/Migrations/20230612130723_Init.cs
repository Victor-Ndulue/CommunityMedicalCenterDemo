using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMCDemo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    PostCode = table.Column<int>(type: "int", nullable: false),
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
                    PostCode = table.Column<int>(type: "int", nullable: false),
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
                    MedicalCenterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MedicalCenterManager = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    MedicalCenterAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community_Medical_Centers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Community_Medical_Centers_MedicalCenterAddress_MedicalCenterAddressId",
                        column: x => x.MedicalCenterAddressId,
                        principalTable: "MedicalCenterAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentChief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Community_Medical_CentersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Community_Medical_Centers_Community_Medical_CentersId",
                        column: x => x.Community_Medical_CentersId,
                        principalTable: "Community_Medical_Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    DateBirthed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateJoinedCenter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLeftCenter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffAddressId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Community_Medical_CentersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalStaffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalStaffs_StaffAddresses_StaffAddressId",
                        column: x => x.StaffAddressId,
                        principalTable: "StaffAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalStaffs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalStaffs_Community_Medical_Centers_Community_Medical_CentersId",
                        column: x => x.Community_Medical_CentersId,
                        principalTable: "Community_Medical_Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Disciplines",
                columns: table => new
                {
                    Ref_DisciplinesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplinesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisciplinesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateObtained = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfessionalStaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Disciplines", x => x.Ref_DisciplinesId);
                    table.ForeignKey(
                        name: "FK_Ref_Disciplines_ProfessionalStaffs_ProfessionalStaffId",
                        column: x => x.ProfessionalStaffId,
                        principalTable: "ProfessionalStaffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Community_Medical_Centers_MedicalCenterAddressId",
                table: "Community_Medical_Centers",
                column: "MedicalCenterAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Community_Medical_CentersId",
                table: "Departments",
                column: "Community_Medical_CentersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalStaffs_Community_Medical_CentersId",
                table: "ProfessionalStaffs",
                column: "Community_Medical_CentersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalStaffs_DepartmentId",
                table: "ProfessionalStaffs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalStaffs_StaffAddressId",
                table: "ProfessionalStaffs",
                column: "StaffAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Ref_Disciplines_ProfessionalStaffId",
                table: "Ref_Disciplines",
                column: "ProfessionalStaffId");
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
