using Microsoft.EntityFrameworkCore.Migrations;

namespace SitePessoal.Data.Migrations
{
    public partial class Experiencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    ExperienciaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEmpresa = table.Column<string>(nullable: true),
                    Duracao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.ExperienciaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiencia");
        }
    }
}
