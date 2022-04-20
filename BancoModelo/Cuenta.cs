using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo
{
    public abstract class Cuenta
    {
        public string Numero { get; set; }
        public decimal Saldo { get; set; }

        public Titular Titular { get; set; }


        public void Depositar(decimal importe)
        {
            try
            {
                if (importe < 0) throw new Exception("Monto negativo ");
                Saldo += importe;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public abstract bool Extraccion(decimal importe);
    }

    public class CA : Cuenta
    {

    }

    public class CC : Cuenta
    {

    }

}
