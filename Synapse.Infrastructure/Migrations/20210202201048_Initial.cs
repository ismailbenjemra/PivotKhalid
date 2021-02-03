using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synapse.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateGroup = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KeyValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColonneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "ReservoirAccapPivots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSaisie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Matricule_Apporteur_Gest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Ordre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Bordereau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservoirAccapPivots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FluxFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PivotId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluxFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FluxFiles_Pivots_PivotId",
                        column: x => x.PivotId,
                        principalTable: "Pivots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrestationCommunes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REF_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXR_SURV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MT_PREST_DG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MOIS_SURV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PER_DEB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PER_FIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCre = table.Column<int>(type: "int", nullable: false),
                    PivotId = table.Column<int>(type: "int", nullable: true),
                    ReservoirAccapPivotId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestationCommunes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrestationCommunes_Pivots_PivotId",
                        column: x => x.PivotId,
                        principalTable: "Pivots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrestationCommunes_ReservoirAccapPivots_ReservoirAccapPivotId",
                        column: x => x.ReservoirAccapPivotId,
                        principalTable: "ReservoirAccapPivots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE_GR_RSQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TYPE_RSQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAT_PREST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MNT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FluxFileId = table.Column<int>(type: "int", nullable: true),
                    SEG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUM_SEG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUM_FICH_BRIDGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_PIVOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PIVOT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_FAB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_FICH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_MESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_DG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_DG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PER_DEB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PER_FIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONV_REF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MNT_TOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REF_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REF_DG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_SOUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_SOUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_SOUS_COMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LIB_CNT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADDR_SOUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXR_SURV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETAT_PRESTATION = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreAds_FluxFiles_FluxFileId",
                        column: x => x.FluxFileId,
                        principalTable: "FluxFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreDcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LIGNE_SEG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIRET_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MT_TOT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CONT_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONT_DG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIRET_SOUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIS_SOC_A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAIS_SOC_B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REF_DES_C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADRESSE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MT_DEMAND = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FluxFileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreDcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreDcs_FluxFiles_FluxFileId",
                        column: x => x.FluxFileId,
                        principalTable: "FluxFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SsaAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEG_SSA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TYPE_GR_RSQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TYPE_RSQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAT_PREST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_RSQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NATEVT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_EVT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DG_EVT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COT_ASSUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TR_AGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEX_ASSUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAT_ASSUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOIS_SURV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_PREST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NB_ACTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MT_FRA_REEL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MT_PREST_DG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MT_RMB_SS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MT_AUT_RMB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CD_SEQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NB_ASSUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MT_AKT_MAX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TX_RMB_SCS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASE_RMB_SCS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DVS_REEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DVS_RMB_SCS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DVS_RMB_AUT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreId = table.Column<int>(type: "int", nullable: true),
                    SEG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUM_SEG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUM_FICH_BRIDGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_PIVOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PIVOT_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_FAB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_FICH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_MESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_DG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_DG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PER_DEB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PER_FIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONV_REF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MNT_TOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REF_PR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REF_DG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_SOUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_SOUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOM_SOUS_COMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LIB_CNT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADDR_SOUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXR_SURV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETAT_PRESTATION = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SsaAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SsaAds_CreAds_CreId",
                        column: x => x.CreId,
                        principalTable: "CreAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreAds_FluxFileId",
                table: "CreAds",
                column: "FluxFileId");

            migrationBuilder.CreateIndex(
                name: "IX_CreDcs_FluxFileId",
                table: "CreDcs",
                column: "FluxFileId");

            migrationBuilder.CreateIndex(
                name: "IX_FluxFiles_PivotId",
                table: "FluxFiles",
                column: "PivotId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestationCommunes_PivotId",
                table: "PrestationCommunes",
                column: "PivotId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestationCommunes_ReservoirAccapPivotId",
                table: "PrestationCommunes",
                column: "ReservoirAccapPivotId");

            migrationBuilder.CreateIndex(
                name: "IX_SsaAds_CreId",
                table: "SsaAds",
                column: "CreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreDcs");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "PrestationCommunes");

            migrationBuilder.DropTable(
                name: "SsaAds");

            migrationBuilder.DropTable(
                name: "ReservoirAccapPivots");

            migrationBuilder.DropTable(
                name: "CreAds");

            migrationBuilder.DropTable(
                name: "FluxFiles");

            migrationBuilder.DropTable(
                name: "Pivots");
        }
    }
}
