using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkQuest.Migrations
{
    public partial class M01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Estacionamento",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: false),
                    endereco = table.Column<string>(nullable: false),
                    vagas = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    cnpj = table.Column<string>(nullable: false),
                    cidade = table.Column<string>(nullable: false),
                    valor = table.Column<string>(nullable: false),
                    senha = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estacionamento", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estacionamento");

                }
        }
    }

