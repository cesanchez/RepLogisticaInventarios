using System.Collections.Generic;
namespace Model
{
    public class Campo
    {
        public int CampoId {get; set;}

        public string Nombre {get; set;}

        public List<CampoRuta> CampoRutas { get; set; }
    }
}