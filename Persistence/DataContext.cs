using System;
using Model;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<CentroLogistico> CentroLogisticos { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Campo> Campos { get; set; }
        public DbSet<Hub> Hubs { get; set; }
        public DbSet<Bodega> Bodegas { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Bodega>().HasData(new Bodega {BodegaId = 12, Nombre="MiBodega12"});

            builder.Entity<Inventario>()
                .HasData(
                    new Inventario {Id = 1, CodigoMaterial= "Value 101", NumPedido= "Value 101", Data= "Value 101", Descripcion= "Value 101", 
                    Proveedor= "Value 101", ProveedorCentroSuministrador= "Value 101", UbicacionProveedor= "Value 101", FechaFacturacion= new DateTime(2020, 12, 25),
                    CantidadUm= 7, UnidadMedida= "Value 101", ImporteMl= "Value 101", Moneda= "Value 101", SafetyStock= 7, Largo= 7,
                    Ancho= 7, Alto= 7, Peso= 7, TipoTransporte= "Value 101", TipoCargue= "Value 101", ModoAlmacenamiento= "Value 101",
                    Tipo= "Value 101", Tiempo= 7, DetieneOperacion= "Value 101", Campo= "Value 101", BodegaId = 12}
                );

            builder.Entity<Bodega>().HasData(
                new Bodega{
                        BodegaId = 1,
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
                        BodegaId = 2,
                        Nombre = "Bodega2",
                        Codigo = 321,
                        Latitud = 74.553,
                        Longitud = 79.4343,
                        Dependencia  = "Vicepresidencia",
                        Area = 10,
                        Tipo = "Patio",
                        Cprodatiende = "Codigo"
                    },
                    new Bodega{
                        BodegaId = 3,
                        Nombre = "Bodega3",
                        Codigo = 321,
                        Latitud = 74.553,
                        Longitud = 79.4343,
                        Dependencia  = "Vicepresidencia",
                        Area = 10,
                        Tipo = "Patio",
                        Cprodatiende = "Codigo"}
            );

            //CentroLogisticos - Rutas

            builder.Entity<CentroRuta>().HasKey(t => new {t.RutaId, t.CentroLogisticoId});

            builder.Entity<CentroRuta>().HasOne(pt => pt.CentroLogistico).WithMany(p => p.CentroRutas).HasForeignKey(pt => pt.CentroLogisticoId);

            builder.Entity<CentroRuta>().HasOne(pt => pt.Ruta).WithMany(t => t.CentroRutas).HasForeignKey(pt => pt.RutaId);

            //Campos - Rutas

            builder.Entity<CampoRuta>().HasKey(t => new {t.RutaId, t.CampoId});

            builder.Entity<CampoRuta>().HasOne(pt => pt.Campo).WithMany(p => p.CampoRutas).HasForeignKey(pt => pt.CampoId);

            builder.Entity<CampoRuta>().HasOne(pt => pt.Ruta).WithMany(t => t.CampoRutas).HasForeignKey(pt => pt.RutaId);

            //Hub-Rutas

            builder.Entity<HubRuta>().HasKey(t => new {t.RutaId, t.HubId});

            builder.Entity<HubRuta>().HasOne(pt => pt.Hub).WithMany(p => p.HubRutas).HasForeignKey(pt => pt.HubId);

            builder.Entity<HubRuta>().HasOne(pt => pt.Ruta).WithMany(t => t.HubRutas).HasForeignKey(pt => pt.RutaId);

            //Bodega-Rutas
            builder.Entity<BodegaRuta>().HasKey(t => new {t.RutaId, t.BodegaId});

            builder.Entity<BodegaRuta>().HasOne(pt => pt.Bodega).WithMany(p => p.BodegaRutas).HasForeignKey(pt => pt.BodegaId);

            builder.Entity<BodegaRuta>().HasOne(pt => pt.Ruta).WithMany(t => t.BodegaRutas).HasForeignKey(pt => pt.RutaId);

          
        }
    }
}
