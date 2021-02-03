using Microsoft.EntityFrameworkCore.Migrations;

namespace Synapse.Infrastructure.Migrations
{
    public partial class AjoutEtatPrestations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Etat_PrestationId",
                table: "ReservoirAccapPivots",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Etat_PrestationId",
                table: "PrestationCommunes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Etat_Prestation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle_Etat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etat_Prestation", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservoirAccapPivots_Etat_PrestationId",
                table: "ReservoirAccapPivots",
                column: "Etat_PrestationId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestationCommunes_Etat_PrestationId",
                table: "PrestationCommunes",
                column: "Etat_PrestationId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrestationCommunes_Etat_Prestation_Etat_PrestationId",
                table: "PrestationCommunes");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservoirAccapPivots_Etat_Prestation_Etat_PrestationId",
                table: "ReservoirAccapPivots");

            migrationBuilder.DropTable(
                name: "Etat_Prestation");

            migrationBuilder.DropIndex(
                name: "IX_ReservoirAccapPivots_Etat_PrestationId",
                table: "ReservoirAccapPivots");

            migrationBuilder.DropIndex(
                name: "IX_PrestationCommunes_Etat_PrestationId",
                table: "PrestationCommunes");

            migrationBuilder.DropColumn(
                name: "Etat_PrestationId",
                table: "ReservoirAccapPivots");

            migrationBuilder.DropColumn(
                name: "Etat_PrestationId",
                table: "PrestationCommunes");
        }
    }
}
