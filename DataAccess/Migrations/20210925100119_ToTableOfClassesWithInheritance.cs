using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class ToTableOfClassesWithInheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Persons_FysiotherapeutEmailadres",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Persons_HoofdbehandelaarEmailadres",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Persons_PatientEmailadres",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Persons_StudentEmailadres",
                table: "Patiëntdossiers");

            migrationBuilder.DropColumn(
                name: "BIGNummer",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Patiëntnummer",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Personeelsnummer",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Studentnummer",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "Docent",
                columns: table => new
                {
                    Emailadres = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Personeelsnummer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docent", x => x.Emailadres);
                    table.ForeignKey(
                        name: "FK_Docent_Persons_Emailadres",
                        column: x => x.Emailadres,
                        principalTable: "Persons",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Emailadres = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Patiëntnummer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Emailadres);
                    table.ForeignKey(
                        name: "FK_Patient_Persons_Emailadres",
                        column: x => x.Emailadres,
                        principalTable: "Persons",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Emailadres = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Studentnummer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Emailadres);
                    table.ForeignKey(
                        name: "FK_Student_Persons_Emailadres",
                        column: x => x.Emailadres,
                        principalTable: "Persons",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fysiotherapeut",
                columns: table => new
                {
                    Emailadres = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BIGNummer = table.Column<int>(type: "int", nullable: false),
                    studentEmailadres = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    docentEmailadres = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fysiotherapeut", x => x.Emailadres);
                    table.ForeignKey(
                        name: "FK_Fysiotherapeut_Docent_docentEmailadres",
                        column: x => x.docentEmailadres,
                        principalTable: "Docent",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fysiotherapeut_Persons_Emailadres",
                        column: x => x.Emailadres,
                        principalTable: "Persons",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fysiotherapeut_Student_studentEmailadres",
                        column: x => x.studentEmailadres,
                        principalTable: "Student",
                        principalColumn: "Emailadres",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fysiotherapeut_docentEmailadres",
                table: "Fysiotherapeut",
                column: "docentEmailadres");

            migrationBuilder.CreateIndex(
                name: "IX_Fysiotherapeut_studentEmailadres",
                table: "Fysiotherapeut",
                column: "studentEmailadres");

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Fysiotherapeut_FysiotherapeutEmailadres",
                table: "Patiëntdossiers",
                column: "FysiotherapeutEmailadres",
                principalTable: "Fysiotherapeut",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Fysiotherapeut_HoofdbehandelaarEmailadres",
                table: "Patiëntdossiers",
                column: "HoofdbehandelaarEmailadres",
                principalTable: "Fysiotherapeut",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Patient_PatientEmailadres",
                table: "Patiëntdossiers",
                column: "PatientEmailadres",
                principalTable: "Patient",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Student_StudentEmailadres",
                table: "Patiëntdossiers",
                column: "StudentEmailadres",
                principalTable: "Student",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Fysiotherapeut_FysiotherapeutEmailadres",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Fysiotherapeut_HoofdbehandelaarEmailadres",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Patient_PatientEmailadres",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Student_StudentEmailadres",
                table: "Patiëntdossiers");

            migrationBuilder.DropTable(
                name: "Fysiotherapeut");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Docent");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.AddColumn<int>(
                name: "BIGNummer",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Patiëntnummer",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Personeelsnummer",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Studentnummer",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Persons_FysiotherapeutEmailadres",
                table: "Patiëntdossiers",
                column: "FysiotherapeutEmailadres",
                principalTable: "Persons",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Persons_HoofdbehandelaarEmailadres",
                table: "Patiëntdossiers",
                column: "HoofdbehandelaarEmailadres",
                principalTable: "Persons",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Persons_PatientEmailadres",
                table: "Patiëntdossiers",
                column: "PatientEmailadres",
                principalTable: "Persons",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Persons_StudentEmailadres",
                table: "Patiëntdossiers",
                column: "StudentEmailadres",
                principalTable: "Persons",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
