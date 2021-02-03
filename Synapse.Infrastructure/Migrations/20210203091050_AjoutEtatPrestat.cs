using Microsoft.EntityFrameworkCore.Migrations;

namespace Synapse.Infrastructure.Migrations
{
    public partial class AjoutEtatPrestat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrestationCommunes_Etat_Prestation_Etat_PrestationId",
                table: "PrestationCommunes");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservoirAccapPivots_Etat_Prestation_Etat_PrestationId",
                table: "ReservoirAccapPivots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etat_Prestation",
                table: "Etat_Prestation");

            migrationBuilder.RenameTable(
                name: "Etat_Prestation",
                newName: "Etat_Prestations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etat_Prestations",
                table: "Etat_Prestations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrestationCommunes_Etat_Prestations_Etat_PrestationId",
                table: "PrestationCommunes",
                column: "Etat_PrestationId",
                principalTable: "Etat_Prestations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservoirAccapPivots_Etat_Prestations_Etat_PrestationId",
                table: "ReservoirAccapPivots",
                column: "Etat_PrestationId",
                principalTable: "Etat_Prestations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrestationCommunes_Etat_Prestations_Etat_PrestationId",
                table: "PrestationCommunes");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservoirAccapPivots_Etat_Prestations_Etat_PrestationId",
                table: "ReservoirAccapPivots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etat_Prestations",
                table: "Etat_Prestations");

            migrationBuilder.RenameTable(
                name: "Etat_Prestations",
                newName: "Etat_Prestation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etat_Prestation",
                table: "Etat_Prestation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrestationCommunes_Etat_Prestation_Etat_PrestationId",
                table: "PrestationCommunes",
                column: "Etat_PrestationId",
                principalTable: "Etat_Prestation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservoirAccapPivots_Etat_Prestation_Etat_PrestationId",
                table: "ReservoirAccapPivots",
                column: "Etat_PrestationId",
                principalTable: "Etat_Prestation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
