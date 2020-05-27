using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CentroLogAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentroLogisticos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Codigo = table.Column<string>(nullable: true),
                    Latitud = table.Column<double>(nullable: false),
                    Longitud = table.Column<double>(nullable: false),
                    Dependencia = table.Column<string>(nullable: true),
                    Bodegas = table.Column<string>(nullable: true),
                    AreaBodegas = table.Column<double>(nullable: false),
                    Patios = table.Column<string>(nullable: true),
                    AreaPatios = table.Column<double>(nullable: false),
                    CuartosFrios = table.Column<string>(nullable: true),
                    AreaCFrios = table.Column<double>(nullable: false),
                    CuartosQuimicos = table.Column<string>(nullable: true),
                    AreaCQuimicos = table.Column<double>(nullable: false),
                    CentrosProdAtiendad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroLogisticos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CentroLogisticos");
        }
    }
}
