using System;
namespace CitasMedicas.App.Dominio
{
    public class Agenda
    {
        
        public int Id {get;set;}
        public Sede Sede{get;set;}
        public Paciente Paciente{get;set;}
        public Medico Medico{get;set;}
        public string Nota{get;set;}
        public DateTime FechaCita{get;set;}
    }
}