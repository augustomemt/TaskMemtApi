using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TaskMemtApi.Migrations
{
    public partial class TaskMigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Leader = table.Column<string>(nullable: true),
                    NameDepartament = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceAreas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    specialty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartamentId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    FirstPerformaceAreaId = table.Column<int>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Machine = table.Column<string>(nullable: true),
                    Privilege = table.Column<string>(nullable: true),
                    Registration = table.Column<string>(nullable: true),
                    SecondPerformaceAreaId = table.Column<int>(nullable: true),
                    ThirdPerformaceAreaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departaments_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_PerformanceAreas_FirstPerformaceAreaId",
                        column: x => x.FirstPerformaceAreaId,
                        principalTable: "PerformanceAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_PerformanceAreas_SecondPerformaceAreaId",
                        column: x => x.SecondPerformaceAreaId,
                        principalTable: "PerformanceAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_PerformanceAreas_ThirdPerformaceAreaId",
                        column: x => x.ThirdPerformaceAreaId,
                        principalTable: "PerformanceAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MyPropertyId = table.Column<int>(nullable: true),
                    PerformaceAreaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Tasks_MyPropertyId",
                        column: x => x.MyPropertyId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_PerformanceAreas_PerformaceAreaId",
                        column: x => x.PerformaceAreaId,
                        principalTable: "PerformanceAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComplationDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PerformanceAreaId = table.Column<int>(nullable: true),
                    PlannedWorkload = table.Column<TimeSpan>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Request = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    TaskId = table.Column<int>(nullable: true),
                    WorkInsturction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_PerformanceAreas_PerformanceAreaId",
                        column: x => x.PerformanceAreaId,
                        principalTable: "PerformanceAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartamentId",
                table: "Employees",
                column: "DepartamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FirstPerformaceAreaId",
                table: "Employees",
                column: "FirstPerformaceAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SecondPerformaceAreaId",
                table: "Employees",
                column: "SecondPerformaceAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ThirdPerformaceAreaId",
                table: "Employees",
                column: "ThirdPerformaceAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_PerformanceAreaId",
                table: "Schedules",
                column: "PerformanceAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TaskId",
                table: "Schedules",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_MyPropertyId",
                table: "Tasks",
                column: "MyPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PerformaceAreaId",
                table: "Tasks",
                column: "PerformaceAreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Departaments");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "PerformanceAreas");
        }
    }
}
