using System.Collections.Generic;
namespace Model
{
    public class Bodega
    {
        public int BodegaId {get; set;}

        public string Nombre {get; set;}

        public List<BodegaRuta> BodegaRutas { get; set; }

        public List<Inventario> Inventarios { get; set; }
        
    }
}