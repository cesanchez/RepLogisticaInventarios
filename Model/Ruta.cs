using System.Collections.Generic;

namespace Model
{
    public class Ruta
    {
        
        public int RutaId {get; set;}
        public string Nombre {get; set;}
        public List<CentroRuta> CentroRutas { get; set; }
        public List<CampoRuta> CampoRutas { get; set; }
        public List<HubRuta> HubRutas { get; set; }
        public List<BodegaRuta> BodegaRutas { get; set; }
        public int EscenarioId {get; set;}
        public Escenario Escenario {get; set;}
    }
}