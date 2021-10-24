using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class RemoveFKFromPatientDossier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossiers_Emailaddress",
                table: "Patient");

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Patient_PatientEmail",
                table: "Patiëntdossiers",
                column: "PatientEmail",
                principalTable: "Patient",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Patient_PatientEmail",
                table: "Patiëntdossiers");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patiëntdossiers_Emailaddress",
                table: "Patient",
                column: "Emailaddress",
                principalTable: "Patiëntdossiers",
                principalColumn: "PatientEmail");
        }
    }
}
