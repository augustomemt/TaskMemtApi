using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TaskMemtApi.Migrations
{
    public partial class TaskMigration04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkInsturction",
                table: "Schedules",
                newName: "WorkInstruction");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkInstruction",
                table: "Schedules",
                newName: "WorkInsturction");
        }
    }
}
