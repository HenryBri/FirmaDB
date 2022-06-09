using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peakontor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistriNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaNimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LühiNimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KontaktTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peakontor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Harukontor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistriNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lühinimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefoniNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeakontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harukontor_Peakontor_PeakontorId",
                        column: x => x.PeakontorId,
                        principalTable: "Peakontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vihjed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sisu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Põhjus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeakontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihjed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vihjed_Peakontor_PeakontorId",
                        column: x => x.PeakontorId,
                        principalTable: "Peakontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Töötaja",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isikukood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöölAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöölKuni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kandevõime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HarukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötaja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Töötaja_Harukontor_HarukontorId",
                        column: x => x.HarukontorId,
                        principalTable: "Harukontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ametinimetus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kvalifikatsioonid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tööülesanded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ametinimetus_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Haiguslehed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Põhjus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haiguslehed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haiguslehed_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Laenutus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EsemeNimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsemeKood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laenutus_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lapsed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lapsed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lapsed_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääsuload",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kasutajatunnus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViimaneKülastus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HarukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääsuload", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ligipääsuload_Harukontor_HarukontorId",
                        column: x => x.HarukontorId,
                        principalTable: "Harukontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ligipääsuload_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Palved",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sisu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Põhjus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ettepanek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeakontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palved", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Palved_Peakontor_PeakontorId",
                        column: x => x.PeakontorId,
                        principalTable: "Peakontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Palved_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Puhkused",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkused", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkused_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontroll",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KontrolliAeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Asutus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tulemus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontroll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tervisekontroll_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ametinimetus_TöötajaId",
                table: "Ametinimetus",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Haiguslehed_TöötajaId",
                table: "Haiguslehed",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Harukontor_PeakontorId",
                table: "Harukontor",
                column: "PeakontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_TöötajaId",
                table: "Laenutus",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lapsed_TöötajaId",
                table: "Lapsed",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääsuload_HarukontorId",
                table: "Ligipääsuload",
                column: "HarukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääsuload_TöötajaId",
                table: "Ligipääsuload",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Palved_PeakontorId",
                table: "Palved",
                column: "PeakontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Palved_TöötajaId",
                table: "Palved",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkused_TöötajaId",
                table: "Puhkused",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontroll_TöötajaId",
                table: "Tervisekontroll",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_HarukontorId",
                table: "Töötaja",
                column: "HarukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vihjed_PeakontorId",
                table: "Vihjed",
                column: "PeakontorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ametinimetus");

            migrationBuilder.DropTable(
                name: "Haiguslehed");

            migrationBuilder.DropTable(
                name: "Laenutus");

            migrationBuilder.DropTable(
                name: "Lapsed");

            migrationBuilder.DropTable(
                name: "Ligipääsuload");

            migrationBuilder.DropTable(
                name: "Palved");

            migrationBuilder.DropTable(
                name: "Puhkused");

            migrationBuilder.DropTable(
                name: "Tervisekontroll");

            migrationBuilder.DropTable(
                name: "Vihjed");

            migrationBuilder.DropTable(
                name: "Töötaja");

            migrationBuilder.DropTable(
                name: "Harukontor");

            migrationBuilder.DropTable(
                name: "Peakontor");
        }
    }
}
