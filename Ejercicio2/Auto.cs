using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public decimal Precio { get; set; }

        public Persona Persona { get; set; }
        
        public Auto(string Patente, string Marca, string Modelo, string Anio, decimal Precio, Persona Persona)
        {
            this.Patente = Patente;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Anio = Anio;
            this.Precio = Precio;
            this.Persona = Persona;
        }
        




    }
}
