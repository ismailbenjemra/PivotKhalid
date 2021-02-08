using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace Synapse.Infrastructure.Migrations
{
    public partial class OracleInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etat_Prestations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    Libelle_Etat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etat_Prestations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FluxFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    File = table.Column<byte[]>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    ProcessedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluxFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    TableName = table.Column<string>(nullable: true),
                    UpdateGroup = table.Column<Guid>(nullable: false),
                    KeyValues = table.Column<string>(nullable: true),
                    ColonneName = table.Column<string>(nullable: true),
                    OldValues = table.Column<string>(nullable: true),
                    NewValues = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservoirAccapulco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    DateSaisie = table.Column<DateTime>(nullable: false),
                    Matricule_Apporteur_Gest = table.Column<string>(nullable: true),
                    Numero_Ordre = table.Column<string>(nullable: true),
                    Numero_Bordereau = table.Column<string>(nullable: true),
                    Etat_PrestationId = table.Column<int>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "CreAds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
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
                    MNT_TOT = table.Column<decimal>(nullable: false),
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
                    MNT = table.Column<decimal>(nullable: false),
                    FluxFileId = table.Column<int>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    LIGNE_SEG = table.Column<string>(nullable: true),
                    SIRET_PR = table.Column<string>(nullable: true),
                    MT_TOT = table.Column<decimal>(nullable: false),
                    CONT_PR = table.Column<string>(nullable: true),
                    CONT_DG = table.Column<string>(nullable: true),
                    SIRET_SOUS = table.Column<string>(nullable: true),
                    RAIS_SOC_A = table.Column<string>(nullable: true),
                    RAIS_SOC_B = table.Column<string>(nullable: true),
                    REF_DES_C = table.Column<string>(nullable: true),
                    ADRESSE = table.Column<string>(nullable: true),
                    MT_DEMAND = table.Column<decimal>(nullable: false),
                    FluxFileId = table.Column<int>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
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
                    MNT_TOT = table.Column<decimal>(nullable: false),
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
                    MT_FRA_REEL = table.Column<decimal>(nullable: false),
                    MT_PREST_DG = table.Column<decimal>(nullable: false),
                    MT_RMB_SS = table.Column<decimal>(nullable: false),
                    MT_AUT_RMB = table.Column<decimal>(nullable: false),
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
                    table.PrimaryKey("PK_SsaAds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SsaAds_CreAds_CreId",
                        column: x => x.CreId,
                        principalTable: "CreAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrestationCommunes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    REF_PR = table.Column<string>(nullable: true),
                    EXR_SURV = table.Column<string>(nullable: true),
                    MT_PREST_DG = table.Column<decimal>(nullable: false),
                    MOIS_SURV = table.Column<string>(nullable: true),
                    PER_DEB = table.Column<string>(nullable: true),
                    PER_FIN = table.Column<string>(nullable: true),
                    CreAdsId = table.Column<int>(nullable: true),
                    CreDcsId = table.Column<int>(nullable: true),
                    ReservoirAccapPivotId = table.Column<int>(nullable: true),
                    Etat_PrestationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestationCommunes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrestationCommunes_CreAds_CreAdsId",
                        column: x => x.CreAdsId,
                        principalTable: "CreAds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrestationCommunes_CreDcs_CreDcsId",
                        column: x => x.CreDcsId,
                        principalTable: "CreDcs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrestationCommunes_Etat_Prestations_Etat_PrestationId",
                        column: x => x.Etat_PrestationId,
                        principalTable: "Etat_Prestations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrestationCommunes_ReservoirAccapulco_ReservoirAccapPivotId",
                        column: x => x.ReservoirAccapPivotId,
                        principalTable: "ReservoirAccapulco",
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
                name: "IX_PrestationCommunes_CreAdsId",
                table: "PrestationCommunes",
                column: "CreAdsId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestationCommunes_CreDcsId",
                table: "PrestationCommunes",
                column: "CreDcsId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestationCommunes_Etat_PrestationId",
                table: "PrestationCommunes",
                column: "Etat_PrestationId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestationCommunes_ReservoirAccapPivotId",
                table: "PrestationCommunes",
                column: "ReservoirAccapPivotId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservoirAccapulco_Etat_PrestationId",
                table: "ReservoirAccapulco",
                column: "Etat_PrestationId");

            migrationBuilder.CreateIndex(
                name: "IX_SsaAds_CreId",
                table: "SsaAds",
                column: "CreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "PrestationCommunes");

            migrationBuilder.DropTable(
                name: "SsaAds");

            migrationBuilder.DropTable(
                name: "CreDcs");

            migrationBuilder.DropTable(
                name: "ReservoirAccapulco");

            migrationBuilder.DropTable(
                name: "CreAds");

            migrationBuilder.DropTable(
                name: "Etat_Prestations");

            migrationBuilder.DropTable(
                name: "FluxFiles");
        }
    }
}
