using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPractica
{
    public abstract class Operaciones
    {
        public abstract decimal Calcular(decimal a, decimal b);
    }

    public class Sumar : Operaciones
    {
        public override decimal Calcular(decimal a, decimal b)
        {
            return a + b;
        }
    }

    public class Restar: Operaciones
    {
        public override decimal Calcular(decimal a, decimal b)
        {
            return a - b;    
        }
    }

}
