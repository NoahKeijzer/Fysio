using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class PDFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossier_Patiëntnumber",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossier_Physiotherapist_PhysiotherapistEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossier_Student_StudentEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropIndex(
                name: "IX_Patiëntdossier_PhysiotherapistEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropIndex(
                name: "IX_Patiëntdossier_StudentEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropColumn(
                name: "PhysiotherapistEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropColumn(
                name: "StudentEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patiëntdossier_Patiëntnumber",
                table: "Patient",
                column: "Patiëntnumber",
                principalTable: "Patiëntdossier",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossier_Patiëntnumber",
                table: "Patient");

            migrationBuilder.AddColumn<string>(
                name: "PhysiotherapistEmailaddress",
                table: "Patiëntdossier",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentEmailaddress",
                table: "Patiëntdossier",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossier_PhysiotherapistEmailaddress",
                table: "Patiëntdossier",
                column: "PhysiotherapistEmailaddress");

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossier_StudentEmailaddress",
                table: "Patiëntdossier",
                column: "StudentEmailaddress");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patiëntdossier_Patiëntnumber",
                table: "Patient",
                column: "Patiëntnumber",
                principalTable: "Patiëntdossier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossier_Physiotherapist_PhysiotherapistEmailaddress",
                table: "Patiëntdossier",
                column: "PhysiotherapistEmailaddress",
                principalTable: "Physiotherapist",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossier_Student_StudentEmailaddress",
                table: "Patiëntdossier",
                column: "StudentEmailaddress",
                principalTable: "Student",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
