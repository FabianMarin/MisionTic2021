using System;
namespace AgendamientoIps.App.Dominio
{
    /// <summary>Class <c>Medico</c>
    /// Modela un Medico en el sistema hereda de Persona 
    /// </summary> 
    public class Medico:Persona
    {
        public string Nombre {get;set;}
        public string TarjetaPro {get;set;}
        public SedeIps SedeIps {get;set;}
        
        public Especialidad Especialidad {get;set;}
    }
}