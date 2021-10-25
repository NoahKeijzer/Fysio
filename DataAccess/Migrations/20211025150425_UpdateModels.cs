using Microsoft.EntityFrameworkCore.Migrations;

namespace Fysio.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiagnosOmschrijving",
                table: "Patiëntdossiers",
                newName: "DiagnoseOmschrijving");

            migrationBuilder.AlterColumn<int>(
                name: "DiagnoseCode",
                table: "Patiëntdossiers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiagnoseOmschrijving",
                table: "Patiëntdossiers",
                newName: "DiagnosOmschrijving");

            migrationBuilder.AlterColumn<string>(
                name: "DiagnoseCode",
                table: "Patiëntdossiers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
