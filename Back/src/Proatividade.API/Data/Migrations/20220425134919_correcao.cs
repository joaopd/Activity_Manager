using Microsoft.EntityFrameworkCore.Migrations;

namespace Proatividade.API.Data.Migrations
{
    public partial class correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Priroridade",
                table: "Atividades",
                newName: "Prioridade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prioridade",
                table: "Atividades",
                newName: "Priroridade");
        }
    }
}
