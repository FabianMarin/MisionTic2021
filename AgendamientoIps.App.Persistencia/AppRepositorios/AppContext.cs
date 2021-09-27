using Microsoft.EntityFrameworkCore;
using AgendamientoIps.App.Dominio;
namespace AgendamientoIps.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet <Persona> Personas{get;set;}
        public DbSet <Paciente> Pacientes {get;set;}
        public DbSet <Medico> Medicos {get;set;}
        public DbSet <Usuario> Usuario {get;set;}
        //public DbSet <TipoDocumento> TipoDocumentos {get;set;}
        public DbSet <Sintomas> Sintomas {get;set;}
        public DbSet <SedeIps> SedesIps{get;set;}
        public DbSet <Laboratorio> Labortorios {get;set;}
        public DbSet <Horario> Horarios {get;set;}
        //public DbSet <Genero> Generos {get;set;}
        public DbSet <Especialidad>Especialidades {get;set;}
        //public DbSet <Eps> Eps {get;set;}
        //public DbSet <Ciudad> Ciudades {get;set;}
        public DbSet <Cita> Citas {get;set;} 

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDb; Initial Catalog = AgendamientoData");
            }
        }

    }
}