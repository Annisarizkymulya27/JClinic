using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JClinic.Migrations
{
    public partial class tryonketiga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Department",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    depName = table.Column<string>(type: "text", nullable: true),
                    depDescription = table.Column<string>(type: "text", nullable: true),
                    depStatus = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Patient",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    birthdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    regisdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    height = table.Column<int>(type: "int", nullable: false),
                    weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Doctor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    doctorName = table.Column<string>(type: "text", nullable: true),
                    noHp = table.Column<string>(type: "text", nullable: true),
                    fkDepartmentId = table.Column<string>(type: "varchar(767)", nullable: true),
                    password = table.Column<string>(type: "text", nullable: true),
                    docAddress = table.Column<string>(type: "text", nullable: true),
                    doctorEdu = table.Column<string>(type: "text", nullable: true),
                    consulCharge = table.Column<int>(type: "int", nullable: false),
                    docStatus = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Doctor_Tb_Department_fkDepartmentId",
                        column: x => x.fkDepartmentId,
                        principalTable: "Tb_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_User",
                columns: table => new
                {
                    Username = table.Column<string>(type: "varchar(767)", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    RolesId = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_User", x => x.Username);
                    table.ForeignKey(
                        name: "FK_Tb_User_Tb_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Tb_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Appointment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    appointDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    details = table.Column<string>(type: "text", nullable: true),
                    appointStatus = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PatientId = table.Column<string>(type: "varchar(767)", nullable: true),
                    DoctorId = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Appointment_Tb_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Tb_Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Appointment_Tb_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Tb_Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Appointment_DoctorId",
                table: "Tb_Appointment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Appointment_PatientId",
                table: "Tb_Appointment",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Doctor_fkDepartmentId",
                table: "Tb_Doctor",
                column: "fkDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_RolesId",
                table: "Tb_User",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Appointment");

            migrationBuilder.DropTable(
                name: "Tb_User");

            migrationBuilder.DropTable(
                name: "Tb_Doctor");

            migrationBuilder.DropTable(
                name: "Tb_Patient");

            migrationBuilder.DropTable(
                name: "Tb_Roles");

            migrationBuilder.DropTable(
                name: "Tb_Department");
        }
    }
}
