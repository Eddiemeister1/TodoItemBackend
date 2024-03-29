﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningAPI.Migrations
{
    public partial class Tweaks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TodoItems",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "Description", "IsRemoved", "WhenAdded" },
                values: new object[] { 1, "Fix Angular App", false, new DateTime(2021, 8, 4, 10, 49, 58, 65, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "Description", "IsRemoved", "WhenAdded" },
                values: new object[] { 2, "Add a POST to the API", false, new DateTime(2021, 8, 4, 10, 49, 58, 68, DateTimeKind.Local).AddTicks(640) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
