using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class AutoIncrementDrop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Patiëntdossiers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patiëntdossiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Behandelingen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Behandelplan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumAanmelding = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumOntslag = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiagnosOmschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiagnoseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoofdbehandelaarEmailaddress = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IntakeGedaanDoor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntakeOnderSupervisieVan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Klachten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opmerkingen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patiëntdossiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patiëntdossiers_Physiotherapist_HoofdbehandelaarEmailaddress",
                        column: x => x.HoofdbehandelaarEmailaddress,
                        principalTable: "Physiotherapist",
                        principalColumn: "Emailaddress",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Emailaddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatiëntdossierId = table.Column<int>(type: "int", nullable: true),
                    Patiëntnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Emailaddress);
                    table.ForeignKey(
                        name: "FK_Patient_Patiëntdossiers_PatiëntdossierId",
                        column: x => x.PatiëntdossierId,
                        principalTable: "Patiëntdossiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_Persons_Emailaddress",
                        column: x => x.Emailaddress,
                        principalTable: "Persons",
                        principalColumn: "Emailaddress",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PatiëntdossierId",
                table: "Patient",
                column: "PatiëntdossierId");

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossiers_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers",
                column: "HoofdbehandelaarEmailaddress");
        }
    }
}
