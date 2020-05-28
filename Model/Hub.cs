using System.Collections.Generic;
namespace Model
{
    public class Hub
    {
        public int HubId {get; set;}

        public string Nombre {get; set;}

        public List<HubRuta> HubRutas { get; set; }
    }
}