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


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Inventario>()
                .HasData(
                    new Inventario {Id = 1, CodigoMaterial= "Value 101", NumPedido= "Value 101", Data= "Value 101", Descripcion= "Value 101", 
                    Proveedor= "Value 101", ProveedorCentroSuministrador= "Value 101", UbicacionProveedor= "Value 101", FechaFacturacion= new DateTime(2020, 12, 25),
                    CantidadUm= 7, UnidadMedida= "Value 101", ImporteMl= "Value 101", Moneda= "Value 101", SafetyStock= 7, Largo= 7,
                    Ancho= 7, Alto= 7, Peso= 7, TipoTransporte= "Value 101", TipoCargue= "Value 101", ModoAlmacenamiento= "Value 101",
                    Tipo= "Value 101", Tiempo= 7, DetieneOperacion= "Value 101", Campo= "Value 101", Bodega= "Value 101",}
                );
        }
    }
}
