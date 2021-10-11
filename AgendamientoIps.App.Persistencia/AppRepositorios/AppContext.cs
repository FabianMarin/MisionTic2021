using Microsoft.EntityFrameworkCore;
using AgendamientoIps.App.Dominio;
namespace AgendamientoIps.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet <Persona> Personas{get;set;}
        public DbSet <Paciente> Pacientes {get;set;}
        public DbSet <Medico> Medico {get;set;}
        public DbSet <Usuario> Usuario {get;set;}
        public DbSet <Agenda> Agendas {get;set;}
        public DbSet <SedeIps> SedeIps {get;set;}   
        public DbSet <Especialidad> Especialidades {get;set;}
        public DbSet <Ciudad> Ciudades {get;set;}
       

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Initial Catalog=AgendamientoData; Data Source=LAPTOP-AKB0L4HT; Integrated Security=true");
               // optionsBuilder.UseSqlServer("Data Source =LAPTOP-AKB0L4HT; Initial Catalog = AgendamientoData");
            }       //  optionsBuilder.UseSqlServer("Initial Catalog=AgendamientoData; Data Source=LAPTOP-AKB0L4HT; Integrated Security=true");
                        
        }

    }
}