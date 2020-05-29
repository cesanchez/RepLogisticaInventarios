namespace Model
{
    public class CampoRuta
    {
        public int RutaId { get; set; }
        
        public Ruta Ruta { get; set; }

        public int CampoId { get; set; }
        public Campo Campo { get; set; }

    }
}