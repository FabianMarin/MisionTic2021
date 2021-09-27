using System;
namespace AgendamientoIps.App.Dominio
{
    public class Horario
    {
        public int Id {get;set;}
        public string Dia{get;set;}
        public DateTime HoraInicio{get;set;}
        public DateTime HoraFinal{get;set;}
    }
}