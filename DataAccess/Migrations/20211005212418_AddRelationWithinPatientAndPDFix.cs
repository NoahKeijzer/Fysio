using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class AddRelationWithinPatientAndPDFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Persons_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Persons_PhysiotherapistEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Persons_StudentEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Patiëntdossiers_Patiëntnumber",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_Patiëntnumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "BIGNummer",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Patiëntnumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "StaffNumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Studentnumber",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Emailaddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Patiëntnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Emailaddress);
                    table.ForeignKey(
                        name: "FK_Patient_Patiëntdossiers_Patiëntnumber",
                        column: x => x.Patiëntnumber,
                        principalTable: "Patiëntdossiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patient_Persons_Emailaddress",
                        column: x => x.Emailaddress,
                        principalTable: "Persons",
                        principalColumn: "Emailaddress",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "Student",
                columns: table => new
                {
                    Emailaddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Studentnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Emailaddress);
                    table.ForeignKey(
                        name: "FK_Student_Persons_Emailaddress",
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

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Patiëntnumber",
                table: "Patient",
                column: "Patiëntnumber",
                unique: true,
                filter: "[Patiëntnumber] IS NOT NULL");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_PhysiotherapistEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Student_StudentEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Physiotherapist");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teacher");

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
                name: "Patiëntnumber",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffNumber",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Studentnumber",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Patiëntnumber",
                table: "Persons",
                column: "Patiëntnumber",
                unique: true,
                filter: "[Patiëntnumber] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Persons_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers",
                column: "HoofdbehandelaarEmailaddress",
                principalTable: "Persons",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Persons_PhysiotherapistEmailaddress",
                table: "Patiëntdossiers",
                column: "PhysiotherapistEmailaddress",
                principalTable: "Persons",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Persons_StudentEmailaddress",
                table: "Patiëntdossiers",
                column: "StudentEmailaddress",
                principalTable: "Persons",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Patiëntdossiers_Patiëntnumber",
                table: "Persons",
                column: "Patiëntnumber",
                principalTable: "Patiëntdossiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
