using Microsoft.EntityFrameworkCore.Migrations;

namespace ShootingRange.Server.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lokalizacja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(nullable: true),
                    MapaUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokalizacja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oferta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SamochodId = table.Column<int>(nullable: false),
                    Poczatek = table.Column<float>(nullable: false),
                    GodzinyDoby = table.Column<bool>(nullable: false),
                    IloscGodzinDob = table.Column<int>(nullable: false),
                    CenaZaH = table.Column<float>(nullable: false),
                    Wykupiona = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uzytkownik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrTelefonu = table.Column<string>(nullable: true),
                    Haslo = table.Column<string>(nullable: true),
                    StanKonta = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzytkownik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samochod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UzytkownikId = table.Column<int>(nullable: false),
                    LokalizacjaId = table.Column<int>(nullable: false),
                    OfertaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samochod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samochod_Lokalizacja_LokalizacjaId",
                        column: x => x.LokalizacjaId,
                        principalTable: "Lokalizacja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Samochod_Oferta_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "Oferta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Samochod_Uzytkownik_UzytkownikId",
                        column: x => x.UzytkownikId,
                        principalTable: "Uzytkownik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samochod_LokalizacjaId",
                table: "Samochod",
                column: "LokalizacjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Samochod_OfertaId",
                table: "Samochod",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_Samochod_UzytkownikId",
                table: "Samochod",
                column: "UzytkownikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samochod");

            migrationBuilder.DropTable(
                name: "Lokalizacja");

            migrationBuilder.DropTable(
                name: "Oferta");

            migrationBuilder.DropTable(
                name: "Uzytkownik");
        }
    }
}
