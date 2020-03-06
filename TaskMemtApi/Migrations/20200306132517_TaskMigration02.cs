using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TaskMemtApi.Migrations
{
    public partial class TaskMigration02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Tasks_MyPropertyId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "MyPropertyId",
                table: "Tasks",
                newName: "NameTaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_MyPropertyId",
                table: "Tasks",
                newName: "IX_Tasks_NameTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Tasks_NameTaskId",
                table: "Tasks",
                column: "NameTaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Tasks_NameTaskId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "NameTaskId",
                table: "Tasks",
                newName: "MyPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_NameTaskId",
                table: "Tasks",
                newName: "IX_Tasks_MyPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Tasks_MyPropertyId",
                table: "Tasks",
                column: "MyPropertyId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
