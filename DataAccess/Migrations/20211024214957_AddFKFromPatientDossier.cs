using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class AddFKFromPatientDossier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossiers_PatiëntdossierId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Patient_PatiëntdossierId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Behandelingen",
                table: "Patiëntdossiers");

            migrationBuilder.DropColumn(
                name: "PatiëntdossierId",
                table: "Patient");

            migrationBuilder.AddColumn<string>(
                name: "PatientEmail",
                table: "Patiëntdossiers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TherapyId",
                table: "Patiëntdossiers",   
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vektis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vektis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Therapy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Therapy_Vektis_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Vektis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossiers_PatientEmail",
                table: "Patiëntdossiers",
                column: "PatientEmail",
                unique: true,
                filter: "[PatientEmail] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossiers_TherapyId",
                table: "Patiëntdossiers",
                column: "TherapyId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapy_TypeId",
                table: "Therapy",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Patient_PatientEmail",
                table: "Patiëntdossiers",
                column: "PatientEmail",
                principalTable: "Patient",
                principalColumn: "Emailaddress",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Therapy_TherapyId",
                table: "Patiëntdossiers",
                column: "TherapyId",
                principalTable: "Therapy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Patient_PatientEmail",
                table: "Patiëntdossiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Therapy_TherapyId",
                table: "Patiëntdossiers");

            migrationBuilder.DropTable(
                name: "Therapy");

            migrationBuilder.DropTable(
                name: "Vektis");

            migrationBuilder.DropIndex(
                name: "IX_Patiëntdossiers_PatientEmail",
                table: "Patiëntdossiers");

            migrationBuilder.DropIndex(
                name: "IX_Patiëntdossiers_TherapyId",
                table: "Patiëntdossiers");

            migrationBuilder.DropColumn(
                name: "PatientEmail",
                table: "Patiëntdossiers");

            migrationBuilder.DropColumn(
                name: "TherapyId",
                table: "Patiëntdossiers");

            migrationBuilder.AddColumn<string>(
                name: "Behandelingen",
                table: "Patiëntdossiers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatiëntdossierId",
                table: "Patient",
                type: "int",
                nullable: true);

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
        }
    }
}
