using Microsoft.EntityFrameworkCore.Migrations;

namespace Synapse.Infrastructure.Migrations
{
    public partial class UpdatePrestationCommun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrestationCommunes_Pivots_PivotId",
                table: "PrestationCommunes");

            migrationBuilder.DropColumn(
                name: "IdCre",
                table: "PrestationCommunes");

            migrationBuilder.RenameColumn(
                name: "PivotId",
                table: "PrestationCommunes",
                newName: "CreDcsId");

            migrationBuilder.RenameIndex(
                name: "IX_PrestationCommunes_PivotId",
                table: "PrestationCommunes",
                newName: "IX_PrestationCommunes_CreDcsId");

            migrationBuilder.AddColumn<int>(
                name: "CreAdsId",
                table: "PrestationCommunes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrestationCommunes_CreAdsId",
                table: "PrestationCommunes",
                column: "CreAdsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrestationCommunes_CreAds_CreAdsId",
                table: "PrestationCommunes",
                column: "CreAdsId",
                principalTable: "CreAds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrestationCommunes_CreDcs_CreDcsId",
                table: "PrestationCommunes",
                column: "CreDcsId",
                principalTable: "CreDcs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrestationCommunes_CreAds_CreAdsId",
                table: "PrestationCommunes");

            migrationBuilder.DropForeignKey(
                name: "FK_PrestationCommunes_CreDcs_CreDcsId",
                table: "PrestationCommunes");

            migrationBuilder.DropIndex(
                name: "IX_PrestationCommunes_CreAdsId",
                table: "PrestationCommunes");

            migrationBuilder.DropColumn(
                name: "CreAdsId",
                table: "PrestationCommunes");

            migrationBuilder.RenameColumn(
                name: "CreDcsId",
                table: "PrestationCommunes",
                newName: "PivotId");

            migrationBuilder.RenameIndex(
                name: "IX_PrestationCommunes_CreDcsId",
                table: "PrestationCommunes",
                newName: "IX_PrestationCommunes_PivotId");

            migrationBuilder.AddColumn<int>(
                name: "IdCre",
                table: "PrestationCommunes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PrestationCommunes_Pivots_PivotId",
                table: "PrestationCommunes",
                column: "PivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
