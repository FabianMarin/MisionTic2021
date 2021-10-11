using System.Collections.Generic;
using AgendamientoIps.App.Dominio;
namespace AgendamientoIps.App.Persistencia
{
    interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();
        Medico AddMedico (Medico medico);
        Medico UpdateMedico (Medico medico);
        Medico GetMedico(int idMedico);
        void DeleteMedico (int idMedico);
        
        
    }

}  