using System.Collections.Generic;
using AgendamientoIps.App.Dominio;
namespace AgendamientoIps.App.Persistencia
{
    interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente (Paciente paciente);
        Paciente UpdatePaciente (Paciente paciente);
        Paciente GetPaciente(int idPaciente);
        void DeletePaciente (int idPaciente);
        
        
    }

}    
