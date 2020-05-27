using System;
namespace Model
{
    public class CentroLogistico
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Dependencia { get; set; }
        public string Bodegas { get; set; }
        public double AreaBodegas { get; set; }
        public string Patios { get; set; }
        public double AreaPatios { get; set; }
        public string CuartosFrios { get; set; }
        public double AreaCFrios { get; set; }
        public string CuartosQuimicos { get; set; }
        public double AreaCQuimicos { get; set; }
        public string CentrosProdAtiendad { get; set; }
    }
}