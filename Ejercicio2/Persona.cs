using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Persona
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        


        public Persona(string DNI, string Nombre, string Apellido)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

        public List<Auto> GetAutos(List<Auto> autos)
        {
            throw new NotImplementedException();    
        }
        
        public int CountAutos(List<Auto> autos)
        {
            throw new NotImplementedException();
        }

    }
}
