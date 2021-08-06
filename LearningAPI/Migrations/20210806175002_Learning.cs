using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningAPI.Migrations
{
    public partial class Learning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LearningItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Competency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LearningItems",
                columns: new[] { "Id", "Competency", "Notes", "Topic" },
                values: new object[,]
                {
                    { 1, "Conscious Incompetence", null, "Learn Protobuf" },
                    { 2, "Conscious Competence", "Watched some good videos. Tried it out. It's cool", "Learn Terraform" }
                });

            migrationBuilder.UpdateData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "WhenAdded",
                value: new DateTime(2021, 8, 6, 13, 50, 2, 93, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "WhenAdded",
                value: new DateTime(2021, 8, 6, 13, 50, 2, 96, DateTimeKind.Local).AddTicks(6878));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LearningItems");

            migrationBuilder.UpdateData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "WhenAdded",
                value: new DateTime(2021, 8, 4, 10, 49, 58, 65, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "WhenAdded",
                value: new DateTime(2021, 8, 4, 10, 49, 58, 68, DateTimeKind.Local).AddTicks(640));
        }
    }
}
