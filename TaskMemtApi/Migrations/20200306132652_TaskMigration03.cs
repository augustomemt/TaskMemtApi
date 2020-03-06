using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TaskMemtApi.Migrations
{
    public partial class TaskMigration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Tasks_NameTaskId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_NameTaskId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "NameTaskId",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "NameTask",
                table: "Tasks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameTask",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "NameTaskId",
                table: "Tasks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_NameTaskId",
                table: "Tasks",
                column: "NameTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Tasks_NameTaskId",
                table: "Tasks",
                column: "NameTaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
