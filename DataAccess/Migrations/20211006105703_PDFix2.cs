using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class PDFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossier_Patiëntnumber",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossier_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropIndex(
                name: "IX_Patient_Patiëntnumber",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patiëntdossier",
                table: "Patiëntdossier");

            migrationBuilder.RenameTable(
                name: "Patiëntdossier",
                newName: "Patiëntdossiers");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossier_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_HoofdbehandelaarEmailaddress");

            migrationBuilder.AddColumn<int>(
                name: "PatiëntdossierId",
                table: "Patient",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patiëntdossiers",
                table: "Patiëntdossiers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PatiëntdossierId",
                table: "Patient",
                column: "PatiëntdossierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patiëntdossiers_PatiëntdossierId",
                table: "Patient",
                column: "PatiëntdossierId",
                principalTable: "Patiëntdossiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers",
                column: "HoofdbehandelaarEmailaddress",
                principalTable: "Physiotherapist",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossiers_PatiëntdossierId",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropIndex(
                name: "IX_Patient_PatiëntdossierId",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patiëntdossiers",
                table: "Patiëntdossiers");

            migrationBuilder.DropColumn(
                name: "PatiëntdossierId",
                table: "Patient");

            migrationBuilder.RenameTable(
                name: "Patiëntdossiers",
                newName: "Patiëntdossier");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossier",
                newName: "IX_Patiëntdossier_HoofdbehandelaarEmailaddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patiëntdossier",
                table: "Patiëntdossier",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Patiëntnumber",
                table: "Patient",
                column: "Patiëntnumber",
                unique: true,
                filter: "[Patiëntnumber] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patiëntdossier_Patiëntnumber",
                table: "Patient",
                column: "Patiëntnumber",
                principalTable: "Patiëntdossier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossier_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossier",
                column: "HoofdbehandelaarEmailaddress",
                principalTable: "Physiotherapist",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
