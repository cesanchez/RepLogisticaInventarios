using System;

namespace Model
{
    public class Inventario
    {
        public int Id { get; set; }
        public string CodigoMaterial { get; set; }
        public string NumPedido { get; set; }
        public string Data { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public string ProveedorCentroSuministrador { get; set; }
        public string UbicacionProveedor { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public double CantidadUm { get; set; }
        public string UnidadMedida { get; set; }
        public string ImporteMl { get; set; }
        public string Moneda { get; set; }
        public double SafetyStock { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Alto { get; set; }
        public double Peso { get; set; }
        public string TipoTransporte { get; set; }
        public string TipoCargue { get; set; }
        public string ModoAlmacenamiento { get; set; }
        public string Tipo { get; set; }
        public double Tiempo { get; set; }
        public string DetieneOperacion { get; set; }
        public string Campo { get; set; }
        public int BodegaId { get; set; }
        public Bodega Bodega { get; set; }
    }
}
