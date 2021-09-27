using System;
namespace AgendamientoIps.App.Dominio
{
    public class Cita
    {
        public int Id {get;set;}
        public Medico Medico{get;set;}
        public Paciente Paciente{get;set;}
        public DateTime FechaCita{get;set;}
        public DateTime HoraInicio{get;set;}
        public DateTime HoraFinal{get;set;}
        public double ValorConsulta{get;set;}    
    }
}