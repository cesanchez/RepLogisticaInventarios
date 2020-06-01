using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    BodegaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    Codigo = table.Column<double>(nullable: false),
                    Latitud = table.Column<double>(nullable: false),
                    Longitud = table.Column<double>(nullable: false),
                    Dependencia = table.Column<string>(nullable: true),
                    Area = table.Column<double>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Cprodatiende = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.BodegaId);
                });

            migrationBuilder.CreateTable(
                name: "Campos",
                columns: table => new
                {
                    CampoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campos", x => x.CampoId);
                });

            migrationBuilder.CreateTable(
                name: "CentroLogisticos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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

            migrationBuilder.CreateTable(
                name: "Hubs",
                columns: table => new
                {
                    HubId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hubs", x => x.HubId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

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
                    BodegaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventarios_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "BodegaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escenarios",
                columns: table => new
                {
                    EscenarioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escenarios", x => x.EscenarioId);
                    table.ForeignKey(
                        name: "FK_Escenarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    RutaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    EscenarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.RutaId);
                    table.ForeignKey(
                        name: "FK_Rutas_Escenarios_EscenarioId",
                        column: x => x.EscenarioId,
                        principalTable: "Escenarios",
                        principalColumn: "EscenarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodegaRuta",
                columns: table => new
                {
                    RutaId = table.Column<int>(nullable: false),
                    BodegaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodegaRuta", x => new { x.RutaId, x.BodegaId });
                    table.ForeignKey(
                        name: "FK_BodegaRuta_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "BodegaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodegaRuta_Rutas_RutaId",
                        column: x => x.RutaId,
                        principalTable: "Rutas",
                        principalColumn: "RutaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampoRuta",
                columns: table => new
                {
                    RutaId = table.Column<int>(nullable: false),
                    CampoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampoRuta", x => new { x.RutaId, x.CampoId });
                    table.ForeignKey(
                        name: "FK_CampoRuta_Campos_CampoId",
                        column: x => x.CampoId,
                        principalTable: "Campos",
                        principalColumn: "CampoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampoRuta_Rutas_RutaId",
                        column: x => x.RutaId,
                        principalTable: "Rutas",
                        principalColumn: "RutaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CentroRuta",
                columns: table => new
                {
                    RutaId = table.Column<int>(nullable: false),
                    CentroLogisticoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroRuta", x => new { x.RutaId, x.CentroLogisticoId });
                    table.ForeignKey(
                        name: "FK_CentroRuta_CentroLogisticos_CentroLogisticoId",
                        column: x => x.CentroLogisticoId,
                        principalTable: "CentroLogisticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CentroRuta_Rutas_RutaId",
                        column: x => x.RutaId,
                        principalTable: "Rutas",
                        principalColumn: "RutaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HubRuta",
                columns: table => new
                {
                    RutaId = table.Column<int>(nullable: false),
                    HubId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HubRuta", x => new { x.RutaId, x.HubId });
                    table.ForeignKey(
                        name: "FK_HubRuta_Hubs_HubId",
                        column: x => x.HubId,
                        principalTable: "Hubs",
                        principalColumn: "HubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HubRuta_Rutas_RutaId",
                        column: x => x.RutaId,
                        principalTable: "Rutas",
                        principalColumn: "RutaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bodegas",
                columns: new[] { "BodegaId", "Area", "Codigo", "Cprodatiende", "Dependencia", "Latitud", "Longitud", "Nombre", "Tipo" },
                values: new object[] { 33, 10.0, 321.0, "Codigo", "Vicepresidencia", 74.552999999999997, 79.434299999999993, "Bodega 33", "Cuarto Frio" });

            migrationBuilder.InsertData(
                table: "Campos",
                columns: new[] { "CampoId", "Nombre" },
                values: new object[] { 1, "Campo1" });

            migrationBuilder.InsertData(
                table: "Campos",
                columns: new[] { "CampoId", "Nombre" },
                values: new object[] { 2, "Campo2" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Nombre" },
                values: new object[] { 1122, "Usuario Principal" });

            migrationBuilder.InsertData(
                table: "Escenarios",
                columns: new[] { "EscenarioId", "FechaCreacion", "Nombre", "UsuarioId" },
                values: new object[] { 1, new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Actual", 1122 });

            migrationBuilder.InsertData(
                table: "Inventarios",
                columns: new[] { "Id", "Alto", "Ancho", "BodegaId", "Campo", "CantidadUm", "CodigoMaterial", "Data", "Descripcion", "DetieneOperacion", "FechaFacturacion", "ImporteMl", "Largo", "ModoAlmacenamiento", "Moneda", "NumPedido", "Peso", "Proveedor", "ProveedorCentroSuministrador", "SafetyStock", "Tiempo", "Tipo", "TipoCargue", "TipoTransporte", "UbicacionProveedor", "UnidadMedida" },
                values: new object[] { 2, 20.0, 30.0, 33, "Código campo", 10.0, "Código", "Datos", "Descripción", "No", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Importe ML", 10.0, "Cuarto frio", "COP", "Número pedido", 15.0, "Proveedor", "Centro suministrador", 100.0, 10.0, "Categoria", "Montacarga", "Especializado", "Ubicación Prov", "Unidad" });

            migrationBuilder.InsertData(
                table: "Inventarios",
                columns: new[] { "Id", "Alto", "Ancho", "BodegaId", "Campo", "CantidadUm", "CodigoMaterial", "Data", "Descripcion", "DetieneOperacion", "FechaFacturacion", "ImporteMl", "Largo", "ModoAlmacenamiento", "Moneda", "NumPedido", "Peso", "Proveedor", "ProveedorCentroSuministrador", "SafetyStock", "Tiempo", "Tipo", "TipoCargue", "TipoTransporte", "UbicacionProveedor", "UnidadMedida" },
                values: new object[] { 1, 20.0, 30.0, 33, "Código campo", 10.0, "Código", "Datos", "Descripción", "No", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Importe ML", 10.0, "Cuarto frio", "COP", "Número pedido", 15.0, "Proveedor", "Centro suministrador", 100.0, 10.0, "Categoria", "Montacarga", "Especializado", "Ubicación Prov", "Unidad" });

            migrationBuilder.InsertData(
                table: "Rutas",
                columns: new[] { "RutaId", "EscenarioId", "Nombre" },
                values: new object[] { 7, 1, "Blanco-y-Negro7" });

            migrationBuilder.InsertData(
                table: "BodegaRuta",
                columns: new[] { "RutaId", "BodegaId" },
                values: new object[] { 7, 33 });

            migrationBuilder.InsertData(
                table: "CampoRuta",
                columns: new[] { "RutaId", "CampoId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "CampoRuta",
                columns: new[] { "RutaId", "CampoId" },
                values: new object[] { 7, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_BodegaRuta_BodegaId",
                table: "BodegaRuta",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_CampoRuta_CampoId",
                table: "CampoRuta",
                column: "CampoId");

            migrationBuilder.CreateIndex(
                name: "IX_CentroRuta_CentroLogisticoId",
                table: "CentroRuta",
                column: "CentroLogisticoId");

            migrationBuilder.CreateIndex(
                name: "IX_Escenarios_UsuarioId",
                table: "Escenarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HubRuta_HubId",
                table: "HubRuta",
                column: "HubId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_BodegaId",
                table: "Inventarios",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rutas_EscenarioId",
                table: "Rutas",
                column: "EscenarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodegaRuta");

            migrationBuilder.DropTable(
                name: "CampoRuta");

            migrationBuilder.DropTable(
                name: "CentroRuta");

            migrationBuilder.DropTable(
                name: "HubRuta");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Campos");

            migrationBuilder.DropTable(
                name: "CentroLogisticos");

            migrationBuilder.DropTable(
                name: "Hubs");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "Escenarios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
