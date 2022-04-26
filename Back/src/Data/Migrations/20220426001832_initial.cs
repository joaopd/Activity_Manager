using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace _4.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Number = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "varchar(100)", nullable: true),
                    Description = table.Column<string>(type: "varchar(250)", nullable: true),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CompleteDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Number);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Id",
                table: "Activities",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
