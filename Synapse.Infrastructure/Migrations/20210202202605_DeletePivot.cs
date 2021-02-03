using Microsoft.EntityFrameworkCore.Migrations;

namespace Synapse.Infrastructure.Migrations
{
    public partial class DeletePivot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluxFiles_Pivots_PivotId",
                table: "FluxFiles");

            migrationBuilder.DropTable(
                name: "Pivots");

            migrationBuilder.DropIndex(
                name: "IX_FluxFiles_PivotId",
                table: "FluxFiles");

            migrationBuilder.DropColumn(
                name: "PivotId",
                table: "FluxFiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PivotId",
                table: "FluxFiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pivots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomPivot = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pivots", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluxFiles_PivotId",
                table: "FluxFiles",
                column: "PivotId");

            migrationBuilder.AddForeignKey(
                name: "FK_FluxFiles_Pivots_PivotId",
                table: "FluxFiles",
                column: "PivotId",
                principalTable: "Pivots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
