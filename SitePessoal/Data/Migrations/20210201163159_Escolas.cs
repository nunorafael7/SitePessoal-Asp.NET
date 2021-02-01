using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SitePessoal.Data.Migrations
{
    public partial class Escolas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Escola");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.CreateTable(
                name: "Escolas",
                columns: table => new
                {
                    EscolasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Escola = table.Column<string>(nullable: true),
                    Curso = table.Column<string>(nullable: true),
                    Nota = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolas", x => x.EscolasId);
                });

            migrationBuilder.CreateTable(
                name: "ExperienciaProfissional",
                columns: table => new
                {
                    ExperienciaProfissionalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trabalho = table.Column<string>(nullable: true),
                    Duracao = table.Column<string>(nullable: true),
                    Funcao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienciaProfissional", x => x.ExperienciaProfissionalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Escolas");

            migrationBuilder.DropTable(
                name: "ExperienciaProfissional");

            migrationBuilder.CreateTable(
                name: "Escola",
                columns: table => new
                {
                    EscolaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeEscola = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escola", x => x.EscolaId);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    ExperienciaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.ExperienciaID);
                });
        }
    }
}
