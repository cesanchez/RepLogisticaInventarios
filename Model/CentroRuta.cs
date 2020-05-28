using System;
namespace Model
{
    public class CentroRuta
    {
        public int RutaId {get; set;}
        public Ruta Ruta{get; set;}

        public int CentroLogisticoId {get; set;}
        public CentroLogistico CentroLogistico {get; set;}
        
    }
}