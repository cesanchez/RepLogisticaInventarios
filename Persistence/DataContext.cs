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
        
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Escenario> Escenarios {get; set;}
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<CentroLogistico> CentroLogisticos { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Campo> Campos { get; set; }
        public DbSet<Hub> Hubs { get; set; }
        public DbSet<Bodega> Bodegas { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Bodega>().HasData(new Bodega {BodegaId = 12, Nombre="MiBodega12"});

            /* builder.Entity<Bodega>().HasData(new Bodega {BodegaId = 12, Nombre="MiBodega12"});

            builder.Entity<Inventario>()
                .HasData(
                    new Inventario {Id = 1, CodigoMaterial= "Value 101", NumPedido= "Value 101", Data= "Value 101", Descripcion= "Value 101", 
                    Proveedor= "Value 101", ProveedorCentroSuministrador= "Value 101", UbicacionProveedor= "Value 101", FechaFacturacion=   ,
                    CantidadUm= 7, UnidadMedida= "Value 101", ImporteMl= "Value 101", Moneda= "Value 101", SafetyStock= 7, Largo= 7,
                    Ancho= 7, Alto= 7, Peso= 7, TipoTransporte= "Value 101", TipoCargue= "Value 101", ModoAlmacenamiento= "Value 101",
                    Tipo= "Value 101", Tiempo= 7, DetieneOperacion= "Value 101", Campo= "Value 101", BodegaId = 12}
                );

            b
                    },
                  
                        Cprodatiende = "Codigo"}
            ); */

            //Escenario -> 1Ruta

            builder.Entity<Escenario>()
            .HasOne(b => b.Ruta)
            .WithOne(i => i.Escenario)
            .HasForeignKey<Ruta>(b => b.EscenarioId);


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


            builder.Entity<Usuario>().HasData(new Usuario {UsuarioId = 1122, Nombre = "Usuario Principal"});
            builder.Entity<Escenario>().HasData( new Escenario() { UsuarioId = 1122, EscenarioId = 1, Nombre = "Red Actual", FechaCreacion =  new DateTime(2020, 12, 25)});
            builder.Entity<Ruta>().HasData(new Ruta(){EscenarioId = 1, RutaId = 7, Nombre = "Blanco-y-Negro7"});
            builder.Entity<Campo>().HasData(new Campo(){CampoId = 1, Nombre= "Campo1" });
            builder.Entity<Campo>().HasData(new Campo(){CampoId = 2, Nombre= "Campo2" });
            builder.Entity<CampoRuta>().HasData(new CampoRuta(){RutaId = 7, CampoId = 1, });
            builder.Entity<CampoRuta>().HasData(new CampoRuta(){RutaId = 7, CampoId = 2, });
            builder.Entity<Bodega>().HasData(new Bodega(){BodegaId = 33, Nombre = "Bodega 33", Codigo = 321, Latitud = 74.553, Longitud = 79.4343, Dependencia  = "Vicepresidencia",
                                                        Area = 10, Tipo = "Cuarto Frio", Cprodatiende = "Codigo"});
            builder.Entity<BodegaRuta>().HasData(new BodegaRuta(){BodegaId = 33, RutaId = 7});
            builder.Entity<Inventario>().HasData(new Inventario(){BodegaId = 33, Id = 1, CodigoMaterial = "Código", NumPedido = "Número pedido",Data = "Datos", Descripcion = "Descripción",
                                                                Proveedor = "Proveedor", ProveedorCentroSuministrador = "Centro suministrador", UbicacionProveedor = "Ubicación Prov",
                                                                FechaFacturacion = new DateTime(2020, 12, 25),CantidadUm = 10, UnidadMedida = "Unidad", ImporteMl = "Importe ML",
                                                                Moneda = "COP", SafetyStock = 100, Largo = 10, Ancho = 30, Alto = 20, Peso = 15, TipoTransporte = "Especializado",
                                                                TipoCargue = "Montacarga", ModoAlmacenamiento = "Cuarto frio", Tipo = "Categoria", Tiempo = 10, DetieneOperacion = "No",
                                                                Campo = "Código campo"});
            builder.Entity<Inventario>().HasData(new Inventario(){BodegaId = 33, Id = 2, CodigoMaterial = "Código", NumPedido = "Número pedido",Data = "Datos", Descripcion = "Descripción",
                                                                Proveedor = "Proveedor", ProveedorCentroSuministrador = "Centro suministrador", UbicacionProveedor = "Ubicación Prov",
                                                                FechaFacturacion = new DateTime(2020, 12, 25),CantidadUm = 10, UnidadMedida = "Unidad", ImporteMl = "Importe ML",
                                                                Moneda = "COP", SafetyStock = 100, Largo = 10, Ancho = 30, Alto = 20, Peso = 15, TipoTransporte = "Especializado",
                                                                TipoCargue = "Montacarga", ModoAlmacenamiento = "Cuarto frio", Tipo = "Categoria", Tiempo = 10, DetieneOperacion = "No",
                                                                Campo = "Código campo"});                                                    

            
          
        }
    }
}
