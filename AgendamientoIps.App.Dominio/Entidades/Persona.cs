using System;
namespace AgendamientoIps.App.Dominio
{
    /// <summary>Class <c>Persona</c>
    /// Modela una Persona en general en el sistema 
    /// </summary> 
    public class Persona
    {
        public int Id { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public Usuario Usuario{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Email {get;set;}
        public Ciudad Ciudad{get;set;}
        public int Edad{get;set;}
        public string FechaNacimiento{get;set;}
        public DateTime TimeStamp {get;set;}
    }
}