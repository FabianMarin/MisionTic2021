using System;
namespace AgendamientoIps.App.Dominio
{
    /// <summary>Class <c>Paciente</c>
    /// Modela un Paciente en el sistema hereda de Persona 
    /// </summary> 
    public class Paciente:Persona
    {
        public Eps Eps {get;set;}
        public Sintomas Sintomas {get;set;}
        public SedeIps SedeIps {get;set;}
        public bool Agendado {get;set;}
        public bool Convenio {get;set;}
    }
}