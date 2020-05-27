using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoMaterial = table.Column<string>(nullable: true),
                    NumPedido = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Proveedor = table.Column<string>(nullable: true),
                    ProveedorCentroSuministrador = table.Column<string>(nullable: true),
                    UbicacionProveedor = table.Column<string>(nullable: true),
                    FechaFacturacion = table.Column<DateTime>(nullable: false),
                    CantidadUm = table.Column<double>(nullable: false),
                    UnidadMedida = table.Column<string>(nullable: true),
                    ImporteMl = table.Column<string>(nullable: true),
                    Moneda = table.Column<string>(nullable: true),
                    SafetyStock = table.Column<double>(nullable: false),
                    Largo = table.Column<double>(nullable: false),
                    Ancho = table.Column<double>(nullable: false),
                    Alto = table.Column<double>(nullable: false),
                    Peso = table.Column<double>(nullable: false),
                    TipoTransporte = table.Column<string>(nullable: true),
                    TipoCargue = table.Column<string>(nullable: true),
                    ModoAlmacenamiento = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Tiempo = table.Column<double>(nullable: false),
                    DetieneOperacion = table.Column<string>(nullable: true),
                    Campo = table.Column<string>(nullable: true),
                    Bodega = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Inventarios",
                columns: new[] { "Id", "Alto", "Ancho", "Bodega", "Campo", "CantidadUm", "CodigoMaterial", "Data", "Descripcion", "DetieneOperacion", "FechaFacturacion", "ImporteMl", "Largo", "ModoAlmacenamiento", "Moneda", "NumPedido", "Peso", "Proveedor", "ProveedorCentroSuministrador", "SafetyStock", "Tiempo", "Tipo", "TipoCargue", "TipoTransporte", "UbicacionProveedor", "UnidadMedida" },
                values: new object[] { 1, 7.0, 7.0, "Value 101", "Value 101", 7.0, "Value 101", "Value 101", "Value 101", "Value 101", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Value 101", 7.0, "Value 101", "Value 101", "Value 101", 7.0, "Value 101", "Value 101", 7.0, 7.0, "Value 101", "Value 101", "Value 101", "Value 101", "Value 101" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventarios");
        }
    }
}
