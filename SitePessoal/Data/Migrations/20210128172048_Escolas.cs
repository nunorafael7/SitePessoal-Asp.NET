using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SitePessoal.Data.Migrations
{
    public partial class Escolas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Escola",
                columns: table => new
                {
                    EscolaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEscola = table.Column<string>(nullable: true),
                    DataFim = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escola", x => x.EscolaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Escola");
        }
    }
}
