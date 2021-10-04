using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Emailadres = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefoonnummer = table.Column<int>(type: "int", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Geslacht = table.Column<int>(type: "int", nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BIGNummer = table.Column<int>(type: "int", nullable: true),
                    Patiëntnummer = table.Column<int>(type: "int", nullable: true),
                    Studentnummer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Emailadres);
                });

            migrationBuilder.CreateTable(
                name: "Patiëntdossiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientEmailadres = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Klachten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnoseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnosOmschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentEmailadres = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FysiotherapeutEmailadres = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IntakeGedaanDoor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntakeOnderSupervisieVan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoofdbehandelaarEmailadres = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DatumAanmelding = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumOntslag = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Opmerkingen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Behandelplan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Behandelingen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patiëntdossiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patiëntdossiers_Persons_FysiotherapeutEmailadres",
                        column: x => x.FysiotherapeutEmailadres,
                        principalTable: "Persons",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patiëntdossiers_Persons_HoofdbehandelaarEmailadres",
                        column: x => x.HoofdbehandelaarEmailadres,
                        principalTable: "Persons",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patiëntdossiers_Persons_PatientEmailadres",
                        column: x => x.PatientEmailadres,
                        principalTable: "Persons",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patiëntdossiers_Persons_StudentEmailadres",
                        column: x => x.StudentEmailadres,
                        principalTable: "Persons",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossiers_FysiotherapeutEmailadres",
                table: "Patiëntdossiers",
                column: "FysiotherapeutEmailadres");

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossiers_HoofdbehandelaarEmailadres",
                table: "Patiëntdossiers",
                column: "HoofdbehandelaarEmailadres");

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossiers_PatientEmailadres",
                table: "Patiëntdossiers",
                column: "PatientEmailadres");

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossiers_StudentEmailadres",
                table: "Patiëntdossiers",
                column: "StudentEmailadres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patiëntdossiers");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
