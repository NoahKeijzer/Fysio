using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class ChangedNameOfTablesFromNLtoEN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Persons_Emailadres",
                table: "Patient");

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

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Persons_Emailadres",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Fysiotherapeut");

            migrationBuilder.DropTable(
                name: "Docent");

            migrationBuilder.RenameColumn(
                name: "Studentnummer",
                table: "Student",
                newName: "Studentnumber");

            migrationBuilder.RenameColumn(
                name: "Emailadres",
                table: "Student",
                newName: "Emailaddress");

            migrationBuilder.RenameColumn(
                name: "Wachtwoord",
                table: "Persons",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Telefoonnummer",
                table: "Persons",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Geslacht",
                table: "Persons",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Geboortedatum",
                table: "Persons",
                newName: "DayOfBirth");

            migrationBuilder.RenameColumn(
                name: "Emailadres",
                table: "Persons",
                newName: "Emailaddress");

            migrationBuilder.RenameColumn(
                name: "StudentEmailadres",
                table: "Patiëntdossiers",
                newName: "StudentEmailaddress");

            migrationBuilder.RenameColumn(
                name: "PatientEmailadres",
                table: "Patiëntdossiers",
                newName: "PhysiotherapistEmailaddress");

            migrationBuilder.RenameColumn(
                name: "HoofdbehandelaarEmailadres",
                table: "Patiëntdossiers",
                newName: "PatientEmailaddress");

            migrationBuilder.RenameColumn(
                name: "FysiotherapeutEmailadres",
                table: "Patiëntdossiers",
                newName: "HoofdbehandelaarEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_StudentEmailadres",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_StudentEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_PatientEmailadres",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_PhysiotherapistEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_HoofdbehandelaarEmailadres",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_PatientEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_FysiotherapeutEmailadres",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_HoofdbehandelaarEmailaddress");

            migrationBuilder.RenameColumn(
                name: "Patiëntnummer",
                table: "Patient",
                newName: "Patiëntnumber");

            migrationBuilder.RenameColumn(
                name: "Emailadres",
                table: "Patient",
                newName: "Emailaddress");

            migrationBuilder.CreateTable(
                name: "Physiotherapist",
                columns: table => new
                {
                    Emailaddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BIGNummer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physiotherapist", x => x.Emailaddress);
                    table.ForeignKey(
                        name: "FK_Physiotherapist_Persons_Emailaddress",
                        column: x => x.Emailaddress,
                        principalTable: "Persons",
                        principalColumn: "Emailaddress",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Emailaddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Emailaddress);
                    table.ForeignKey(
                        name: "FK_Teacher_Persons_Emailaddress",
                        column: x => x.Emailaddress,
                        principalTable: "Persons",
                        principalColumn: "Emailaddress",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Persons_Emailaddress",
                table: "Patient",
                column: "Emailaddress",
                principalTable: "Persons",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Patient_PatientEmailaddress",
                table: "Patiëntdossiers",
                column: "PatientEmailaddress",
                principalTable: "Patient",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers",
                column: "HoofdbehandelaarEmailaddress",
                principalTable: "Physiotherapist",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_PhysiotherapistEmailaddress",
                table: "Patiëntdossiers",
                column: "PhysiotherapistEmailaddress",
                principalTable: "Physiotherapist",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Student_StudentEmailaddress",
                table: "Patiëntdossiers",
                column: "StudentEmailaddress",
                principalTable: "Student",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Persons_Emailaddress",
                table: "Student",
                column: "Emailaddress",
                principalTable: "Persons",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Persons_Emailaddress",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Patient_PatientEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_PhysiotherapistEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Student_StudentEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Persons_Emailaddress",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Physiotherapist");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.RenameColumn(
                name: "Studentnumber",
                table: "Student",
                newName: "Studentnummer");

            migrationBuilder.RenameColumn(
                name: "Emailaddress",
                table: "Student",
                newName: "Emailadres");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Persons",
                newName: "Telefoonnummer");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Persons",
                newName: "Wachtwoord");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Persons",
                newName: "Geslacht");

            migrationBuilder.RenameColumn(
                name: "DayOfBirth",
                table: "Persons",
                newName: "Geboortedatum");

            migrationBuilder.RenameColumn(
                name: "Emailaddress",
                table: "Persons",
                newName: "Emailadres");

            migrationBuilder.RenameColumn(
                name: "StudentEmailaddress",
                table: "Patiëntdossiers",
                newName: "StudentEmailadres");

            migrationBuilder.RenameColumn(
                name: "PhysiotherapistEmailaddress",
                table: "Patiëntdossiers",
                newName: "PatientEmailadres");

            migrationBuilder.RenameColumn(
                name: "PatientEmailaddress",
                table: "Patiëntdossiers",
                newName: "HoofdbehandelaarEmailadres");

            migrationBuilder.RenameColumn(
                name: "HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers",
                newName: "FysiotherapeutEmailadres");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_StudentEmailaddress",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_StudentEmailadres");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_PhysiotherapistEmailaddress",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_PatientEmailadres");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_PatientEmailaddress",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_HoofdbehandelaarEmailadres");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_FysiotherapeutEmailadres");

            migrationBuilder.RenameColumn(
                name: "Patiëntnumber",
                table: "Patient",
                newName: "Patiëntnummer");

            migrationBuilder.RenameColumn(
                name: "Emailaddress",
                table: "Patient",
                newName: "Emailadres");

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
                name: "Fysiotherapeut",
                columns: table => new
                {
                    Emailadres = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BIGNummer = table.Column<int>(type: "int", nullable: false),
                    docentEmailadres = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    studentEmailadres = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                name: "FK_Patient_Persons_Emailadres",
                table: "Patient",
                column: "Emailadres",
                principalTable: "Persons",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Persons_Emailadres",
                table: "Student",
                column: "Emailadres",
                principalTable: "Persons",
                principalColumn: "Emailadres",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
