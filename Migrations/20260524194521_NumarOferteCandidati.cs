using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licitatii.Migrations
{
    /// <inheritdoc />
    public partial class NumarOferteCandidati : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidati",
                columns: table => new
                {
                    CandidatId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(type: "TEXT", nullable: false),
                    Varsta = table.Column<int>(type: "INTEGER", nullable: false),
                    Adresa = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidati", x => x.CandidatId);
                });

            migrationBuilder.CreateTable(
                name: "Licitatii",
                columns: table => new
                {
                    LicitatieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(type: "TEXT", nullable: false),
                    ValoareStart = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValoareFinala = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataInceput = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EsteFinalizata = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licitatii", x => x.LicitatieId);
                });

            migrationBuilder.CreateTable(
                name: "CandidatLicitatie",
                columns: table => new
                {
                    CandidatId = table.Column<int>(type: "INTEGER", nullable: false),
                    LicitatiiLicitatieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatLicitatie", x => new { x.CandidatId, x.LicitatiiLicitatieId });
                    table.ForeignKey(
                        name: "FK_CandidatLicitatie_Candidati_CandidatId",
                        column: x => x.CandidatId,
                        principalTable: "Candidati",
                        principalColumn: "CandidatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatLicitatie_Licitatii_LicitatiiLicitatieId",
                        column: x => x.LicitatiiLicitatieId,
                        principalTable: "Licitatii",
                        principalColumn: "LicitatieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oferte",
                columns: table => new
                {
                    OfertaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CandidatId = table.Column<int>(type: "INTEGER", nullable: false),
                    LicitatieId = table.Column<int>(type: "INTEGER", nullable: false),
                    SumaOferita = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataOferta = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferte", x => x.OfertaId);
                    table.ForeignKey(
                        name: "FK_Oferte_Candidati_CandidatId",
                        column: x => x.CandidatId,
                        principalTable: "Candidati",
                        principalColumn: "CandidatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oferte_Licitatii_LicitatieId",
                        column: x => x.LicitatieId,
                        principalTable: "Licitatii",
                        principalColumn: "LicitatieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatLicitatie_LicitatiiLicitatieId",
                table: "CandidatLicitatie",
                column: "LicitatiiLicitatieId");

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_CandidatId",
                table: "Oferte",
                column: "CandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_LicitatieId",
                table: "Oferte",
                column: "LicitatieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatLicitatie");

            migrationBuilder.DropTable(
                name: "Oferte");

            migrationBuilder.DropTable(
                name: "Candidati");

            migrationBuilder.DropTable(
                name: "Licitatii");
        }
    }
}
