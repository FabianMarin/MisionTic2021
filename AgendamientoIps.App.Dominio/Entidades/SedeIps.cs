using System;
namespace AgendamientoIps.App.Dominio
{
    public class SedeIps
    {
        public int Id {get;set;}
        public string Nombre{get;set;}
        public Ciudad Ciudad{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Email{get;set;}
    }
}