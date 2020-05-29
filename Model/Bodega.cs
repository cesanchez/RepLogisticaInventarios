using System.Collections.Generic;
namespace Model
{
    public class Bodega
    {
        public int BodegaId {get; set;}
        public string Nombre {get; set;}
        public double Codigo { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Dependencia { get; set; }
        public double Area { get; set; }
        public string Tipo { get; set; }
        public string Cprodatiende { get; set; }

        public List<BodegaRuta> BodegaRutas { get; set; }

        public List<Inventario> Inventarios { get; set; }
        
    }
}