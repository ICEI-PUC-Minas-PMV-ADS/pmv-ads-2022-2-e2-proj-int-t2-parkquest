using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkQuest.Migrations
{
    public partial class H02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataEntrada = table.Column<DateTime>(nullable: false),
                    horarioEntrada = table.Column<string>(nullable: false),
                    dataSaida = table.Column<DateTime>(nullable: false),
                    horarioSaida = table.Column<string>(nullable: false),
                    custoDia = table.Column<string>(nullable: false),
                    custoTotal = table.Column<string>(nullable: false),
                    EstacionamentoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reserva_Estacionamento_EstacionamentoID",
                        column: x => x.EstacionamentoID,
                        principalTable: "Estacionamento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_EstacionamentoID",
                table: "Reserva",
                column: "EstacionamentoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");
        }
    }
}
