using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synapse.Infrastructure.Migrations
{
    public partial class RenameReservoirAccapulco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrestationCommunes_ReservoirAccapPivots_ReservoirAccapPivotId",
                table: "PrestationCommunes");

            migrationBuilder.DropTable(
                name: "ReservoirAccapPivots");

            migrationBuilder.CreateTable(
                name: "ReservoirAccapulco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSaisie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Matricule_Apporteur_Gest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Ordre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Bordereau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etat_PrestationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservoirAccapulco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservoirAccapulco_Etat_Prestations_Etat_PrestationId",
                        column: x => x.Etat_PrestationId,
                        principalTable: "Etat_Prestations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservoirAccapulco_Etat_PrestationId",
                table: "ReservoirAccapulco",
                column: "Etat_PrestationId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrestationCommunes_ReservoirAccapulco_ReservoirAccapPivotId",
                table: "PrestationCommunes",
                column: "ReservoirAccapPivotId",
                principalTable: "ReservoirAccapulco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrestationCommunes_ReservoirAccapulco_ReservoirAccapPivotId",
                table: "PrestationCommunes");

            migrationBuilder.DropTable(
                name: "ReservoirAccapulco");

            migrationBuilder.CreateTable(
                name: "ReservoirAccapPivots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSaisie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Etat_PrestationId = table.Column<int>(type: "int", nullable: true),
                    Matricule_Apporteur_Gest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Bordereau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Ordre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservoirAccapPivots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservoirAccapPivots_Etat_Prestations_Etat_PrestationId",
                        column: x => x.Etat_PrestationId,
                        principalTable: "Etat_Prestations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservoirAccapPivots_Etat_PrestationId",
                table: "ReservoirAccapPivots",
                column: "Etat_PrestationId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrestationCommunes_ReservoirAccapPivots_ReservoirAccapPivotId",
                table: "PrestationCommunes",
                column: "ReservoirAccapPivotId",
                principalTable: "ReservoirAccapPivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
