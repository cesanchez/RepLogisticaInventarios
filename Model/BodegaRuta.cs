namespace Model
{
    public class BodegaRuta
    {
        
        public int RutaId {get; set;}
        public Ruta Ruta{get; set;}

        public int BodegaId {get; set;}
        public Bodega Bodega {get; set;}
    }
}