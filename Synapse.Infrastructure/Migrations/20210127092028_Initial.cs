using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synapse.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEG = table.Column<string>(nullable: true),
                    NUM_SEG = table.Column<string>(nullable: true),
                    NUM_FICH_BRIDGE = table.Column<string>(nullable: true),
                    NOM_PIVOT = table.Column<string>(nullable: true),
                    PIVOT_TYPE = table.Column<string>(nullable: true),
                    VERSION = table.Column<string>(nullable: true),
                    DT_FAB = table.Column<string>(nullable: true),
                    NOM_FICH = table.Column<string>(nullable: true),
                    ID_MESS = table.Column<string>(nullable: true),
                    ID_DG = table.Column<string>(nullable: true),
                    NOM_DG = table.Column<string>(nullable: true),
                    ID_PR = table.Column<string>(nullable: true),
                    NOM_PR = table.Column<string>(nullable: true),
                    PER_DEB = table.Column<string>(nullable: true),
                    PER_FIN = table.Column<string>(nullable: true),
                    CONV_REF = table.Column<string>(nullable: true),
                    MNT_TOT = table.Column<string>(nullable: true),
                    REF_PR = table.Column<string>(nullable: true),
                    REF_DG = table.Column<string>(nullable: true),
                    ID_SOUS = table.Column<string>(nullable: true),
                    NOM_SOUS = table.Column<string>(nullable: true),
                    NOM_SOUS_COMP = table.Column<string>(nullable: true),
                    LIB_CNT = table.Column<string>(nullable: true),
                    ADDR_SOUS = table.Column<string>(nullable: true),
                    EXR_SURV = table.Column<string>(nullable: true),
                    ETAT_PRESTATION = table.Column<int>(nullable: false),
                    TYPE_GR_RSQ = table.Column<string>(nullable: true),
                    TYPE_RSQ = table.Column<string>(nullable: true),
                    NAT_PREST = table.Column<string>(nullable: true),
                    MNT = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistorySet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(nullable: true),
                    Update_Group = table.Column<Guid>(nullable: false),
                    KeyValues = table.Column<string>(nullable: true),
                    ColonneName = table.Column<string>(nullable: true),
                    OldValues = table.Column<string>(nullable: true),
                    NewValues = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorySet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SsaSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEG = table.Column<string>(nullable: true),
                    NUM_SEG = table.Column<string>(nullable: true),
                    NUM_FICH_BRIDGE = table.Column<string>(nullable: true),
                    NOM_PIVOT = table.Column<string>(nullable: true),
                    PIVOT_TYPE = table.Column<string>(nullable: true),
                    VERSION = table.Column<string>(nullable: true),
                    DT_FAB = table.Column<string>(nullable: true),
                    NOM_FICH = table.Column<string>(nullable: true),
                    ID_MESS = table.Column<string>(nullable: true),
                    ID_DG = table.Column<string>(nullable: true),
                    NOM_DG = table.Column<string>(nullable: true),
                    ID_PR = table.Column<string>(nullable: true),
                    NOM_PR = table.Column<string>(nullable: true),
                    PER_DEB = table.Column<string>(nullable: true),
                    PER_FIN = table.Column<string>(nullable: true),
                    CONV_REF = table.Column<string>(nullable: true),
                    MNT_TOT = table.Column<string>(nullable: true),
                    REF_PR = table.Column<string>(nullable: true),
                    REF_DG = table.Column<string>(nullable: true),
                    ID_SOUS = table.Column<string>(nullable: true),
                    NOM_SOUS = table.Column<string>(nullable: true),
                    NOM_SOUS_COMP = table.Column<string>(nullable: true),
                    LIB_CNT = table.Column<string>(nullable: true),
                    ADDR_SOUS = table.Column<string>(nullable: true),
                    EXR_SURV = table.Column<string>(nullable: true),
                    ETAT_PRESTATION = table.Column<int>(nullable: false),
                    SEG_SSA = table.Column<string>(nullable: true),
                    TYPE_GR_RSQ = table.Column<string>(nullable: true),
                    TYPE_RSQ = table.Column<string>(nullable: true),
                    NAT_PREST = table.Column<string>(nullable: true),
                    CD_RSQ = table.Column<string>(nullable: true),
                    NATEVT = table.Column<string>(nullable: true),
                    CD_EVT = table.Column<string>(nullable: true),
                    CD_DG_EVT = table.Column<string>(nullable: true),
                    COT_ASSUR = table.Column<string>(nullable: true),
                    TR_AGE = table.Column<string>(nullable: true),
                    SEX_ASSUR = table.Column<string>(nullable: true),
                    CAT_ASSUR = table.Column<string>(nullable: true),
                    MOIS_SURV = table.Column<string>(nullable: true),
                    CD_PREST = table.Column<string>(nullable: true),
                    NB_ACTE = table.Column<string>(nullable: true),
                    CD_DVS = table.Column<string>(nullable: true),
                    MT_FRA_REEL = table.Column<string>(nullable: true),
                    MT_PREST_DG = table.Column<string>(nullable: true),
                    MT_RMB_SS = table.Column<string>(nullable: true),
                    MT_AUT_RMB = table.Column<string>(nullable: true),
                    CD_SEQ = table.Column<string>(nullable: true),
                    NB_ASSUR = table.Column<string>(nullable: true),
                    MT_AKT_MAX = table.Column<string>(nullable: true),
                    TX_RMB_SCS = table.Column<string>(nullable: true),
                    BASE_RMB_SCS = table.Column<string>(nullable: true),
                    CD_DVS_REEL = table.Column<string>(nullable: true),
                    CD_DVS_RMB_SCS = table.Column<string>(nullable: true),
                    CD_DVS_RMB_AUT = table.Column<string>(nullable: true),
                    CreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SsaSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SsaSet_CreSet_CreId",
                        column: x => x.CreId,
                        principalTable: "CreSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SsaSet_CreId",
                table: "SsaSet",
                column: "CreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorySet");

            migrationBuilder.DropTable(
                name: "SsaSet");

            migrationBuilder.DropTable(
                name: "CreSet");
        }
    }
}
