using System;
namespace AgendamientoIps.App.Dominio
{
    /// <summary>Class <c>Paciente</c>
    /// Modela un Paciente en el sistema hereda de Persona 
    /// </summary> 
    public class Paciente:Persona
    {
        public Id id {get;set;}
        public SedeIps SedeIps {get;set;}
        public String Ciudad{get;set;}
        public Genero genero{get;set;}

    }
}