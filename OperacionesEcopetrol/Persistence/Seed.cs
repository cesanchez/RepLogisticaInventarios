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
        }
    }
}