using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.CentroLogisticos.Any())
            {
                var cenLogisticos = new List<CentroLogistico>
                {
                    new CentroLogistico
                    {
                        Nombre = "Nombre",
                        Codigo = "Codigo",
                        Latitud = 1.11,
                        Longitud = 1.11,
                        Dependencia = "Dependencia",
                        Bodegas = "Bodegas",
                        AreaBodegas = 10,
                        Patios = "Patios",
                        AreaPatios = 10,
                        CuartosFrios = "CuartosFrios",
                        AreaCFrios = 10,
                        CuartosQuimicos = "Cuartos Quimicos",
                        AreaCQuimicos = 10,
                        CentrosProdAtiendad = "Centros Producción que atiended"
                    },

                    new CentroLogistico
                    {
                        Nombre = "Nombre",
                        Codigo = "Codigo",
                        Latitud = 1.11,
                        Longitud = 1.11,
                        Dependencia = "Dependencia",
                        Bodegas = "Bodegas",
                        AreaBodegas = 10,
                        Patios = "Patios",
                        AreaPatios = 10,
                        CuartosFrios = "CuartosFrios",
                        AreaCFrios = 10,
                        CuartosQuimicos = "Cuartos Quimicos",
                        AreaCQuimicos = 10,
                        CentrosProdAtiendad = "Centros Producción que atiended"
                    }

                };

                context.CentroLogisticos.AddRange(cenLogisticos);
                context.SaveChanges();
            }

            if (!context.Inventarios.Any())
            {
                var inventarios = new List<Inventario>
                {
                    new Inventario
                    {

                        CodigoMaterial = "Código",
                        NumPedido = "Número pedido",
                        Data = "Datos",
                        Descripcion = "Descripción",
                        Proveedor = "Proveedor",
                        ProveedorCentroSuministrador = "Centro suministrador",
                        UbicacionProveedor = "Ubicación Prov",
                        FechaFacturacion = new DateTime(2020, 12, 25),
                        CantidadUm = 10,
                        UnidadMedida = "Unidad",
                        ImporteMl = "Importe ML",
                        Moneda = "COP",
                        SafetyStock = 100,
                        Largo = 10,
                        Ancho = 30,
                        Alto = 20,
                        Peso = 15,
                        TipoTransporte = "Especializado",
                        TipoCargue = "Montacarga",
                        ModoAlmacenamiento = "Cuarto frio",
                        Tipo = "Categoria",
                        Tiempo = 10,
                        DetieneOperacion = "No",
                        Campo = "Código campo",
                        BodegaId = 33,
                        Bodega = new Bodega {
                                BodegaId = 33,
                                Nombre = "Bodega 33",
                                Codigo = 321,
                                Latitud = 74.553,
                                Longitud = 79.4343,
                                Dependencia  = "Vicepresidencia",
                                Area = 10,
                                Tipo = "Cuarto Frio",
                                Cprodatiende = "Codigo"
                        }
                    }

                };

                context.Inventarios.AddRange(inventarios);
                context.SaveChanges();

            }

            if (!context.Bodegas.Any())
            {

                var bodegas = new List<Bodega>{

                    new Bodega{
                        Nombre = "Bodega1",
                        Codigo = 321,
                        Latitud = 74.553,
                        Longitud = 79.4343,
                        Dependencia  = "Vicepresidencia",
                        Area = 10,
                        Tipo = "Patio",
                        Cprodatiende = "Codigo"
                    },
                    new Bodega{
                        Nombre = "Bodega1",
                        Codigo = 321,
                        Latitud = 74.553,
                        Longitud = 79.4343,
                        Dependencia  = "Vicepresidencia",
                        Area = 10,
                        Tipo = "Patio",
                        Cprodatiende = "Codigo"
                    },
                    new Bodega{
                        Nombre = "Bodega1",
                        Codigo = 321,
                        Latitud = 74.553,
                        Longitud = 79.4343,
                        Dependencia  = "Vicepresidencia",
                        Area = 10,
                        Tipo = "Patio",
                        Cprodatiende = "Codigo"
                    }

                };

                context.Bodegas.AddRange(bodegas);
                context.SaveChanges();
            }
        }
    }
}