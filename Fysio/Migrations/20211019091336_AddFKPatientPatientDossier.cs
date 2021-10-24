using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class AddFKPatientPatientDossier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossiers_PatiëntdossierId",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patiëntdossiers",
                table: "Patiëntdossiers");

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
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TherapyId",
                table: "Patiëntdossiers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patiëntdossiers",
                table: "Patiëntdossiers",
                column: "PatientEmail");

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
                name: "Therapys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Therapys_Vektis_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Vektis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patiëntdossiers_TherapyId",
                table: "Patiëntdossiers",
                column: "TherapyId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapys_TypeId",
                table: "Therapys",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Patiëntdossiers_Emailaddress",
                table: "Patient",
                column: "Emailaddress",
                principalTable: "Patiëntdossiers",
                principalColumn: "PatientEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Patiëntdossiers_Therapys_TherapyId",
                table: "Patiëntdossiers",
                column: "TherapyId",
                principalTable: "Therapys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Patiëntdossiers_Emailaddress",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Patiëntdossiers_Therapys_TherapyId",
                table: "Patiëntdossiers");

            migrationBuilder.DropTable(
                name: "Therapys");

            migrationBuilder.DropTable(
                name: "Vektis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patiëntdossiers",
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
        }
    }
}
