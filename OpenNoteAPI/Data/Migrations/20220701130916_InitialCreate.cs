using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenNoteAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreatedDate", "ModifiedTime", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem 1...", new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2913), new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2924), "Samle Note 1" },
                    { 2, "Lorem 2...", new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2929), new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2930), "Samle Note 2" },
                    { 3, "Lorem 3...", new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2932), new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2933), "Samle Note 3" },
                    { 4, "Lorem 4...", new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2934), new DateTime(2022, 7, 1, 16, 9, 15, 826, DateTimeKind.Local).AddTicks(2935), "Samle Note 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
