using System.Collections.Generic;
namespace Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public List<Escenario> Escenarios { get; set; }

    }
}