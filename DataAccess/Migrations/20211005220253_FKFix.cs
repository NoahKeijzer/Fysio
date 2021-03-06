using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class FKFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossiers_Patiëntnumber",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Physiotherapist_PhysiotherapistEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Student_StudentEmailaddress",
                table: "Patiëntdossiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patiëntdossiers",
                table: "Patiëntdossiers");

            migrationBuilder.RenameTable(
                name: "Patiëntdossiers",
                newName: "Patiëntdossier");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_StudentEmailaddress",
                table: "Patiëntdossier",
                newName: "IX_Patiëntdossier_StudentEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_PhysiotherapistEmailaddress",
                table: "Patiëntdossier",
                newName: "IX_Patiëntdossier_PhysiotherapistEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossiers_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossier",
                newName: "IX_Patiëntdossier_HoofdbehandelaarEmailaddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patiëntdossier",
                table: "Patiëntdossier",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patiëntdossier_Patiëntnumber",
                table: "Patient",
                column: "Patiëntnumber",
                principalTable: "Patiëntdossier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossier_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossier",
                column: "HoofdbehandelaarEmailaddress",
                principalTable: "Physiotherapist",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossier_Patiëntnumber",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossier_Physiotherapist_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossier_Physiotherapist_PhysiotherapistEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossier_Student_StudentEmailaddress",
                table: "Patiëntdossier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patiëntdossier",
                table: "Patiëntdossier");

            migrationBuilder.RenameTable(
                name: "Patiëntdossier",
                newName: "Patiëntdossiers");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossier_StudentEmailaddress",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_StudentEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossier_PhysiotherapistEmailaddress",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_PhysiotherapistEmailaddress");

            migrationBuilder.RenameIndex(
                name: "IX_Patiëntdossier_HoofdbehandelaarEmailaddress",
                table: "Patiëntdossiers",
                newName: "IX_Patiëntdossiers_HoofdbehandelaarEmailaddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patiëntdossiers",
                table: "Patiëntdossiers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patiëntdossiers_Patiëntnumber",
                table: "Patient",
                column: "Patiëntnumber",
                principalTable: "Patiëntdossiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
