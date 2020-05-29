using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class BodegaFieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Bodegas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Codigo",
                table: "Bodegas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Cprodatiende",
                table: "Bodegas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dependencia",
                table: "Bodegas",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitud",
                table: "Bodegas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitud",
                table: "Bodegas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Bodegas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "Cprodatiende",
                table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "Dependencia",
                table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Bodegas");
        }
    }
}
