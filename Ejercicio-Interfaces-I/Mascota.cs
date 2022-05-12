using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Interfaces_I
{
    public class Mascota
    {
        public string Especie { get; set; }

        public int Edad { get; set; }

        public string Raza { get; set; }

        public string Nombre { get; set; }

        public Mascota(string especie, int edad, string raza, string nombre)
        {
            this.Especie = especie;
            this.Edad = edad;  
            this.Raza = raza;
            this.Nombre = nombre;
        }

        public class EspecieASC : IComparer<Mascota>
        {
            public int Compare(Mascota x, Mascota y)
            {
                return string.Compare(x.Especie, y.Especie);
            }
        }

        public class EspecieDESC : IComparer<Mascota>
        {
            public int Compare(Mascota x, Mascota y)
            {
                return string.Compare(x.Especie, y.Especie)*-1;
            }
        }


    }

    public abstract class Ordenar
    {
        public abstract IComparer<Mascota> RetornaObjOrden();
    }

    public class OrdenarEspecieASC : Ordenar
    {
        public override IComparer<Mascota> RetornaObjOrden()
        {
            return new Mascota.EspecieASC();
        }
    }

    public class OrdenarEspecieDSC : Ordenar
    {
        public override IComparer<Mascota> RetornaObjOrden()
        {
            return new Mascota.EspecieDESC();
        }
    }

}
