using System;
namespace Model
{
    public class Escenario
    {
        public int EscenarioId {get; set;}
        public string Nombre {get; set;}
        public DateTime FechaCreacion {get; set;}
        public Ruta Ruta {get; set;}
        public int UsuarioId {get; set;}
        public Usuario Usuario {get; set;}
        
    }
}