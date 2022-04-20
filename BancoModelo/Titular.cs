using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo
{
    public class Titular
    {

        List<Cuenta> ListaCuentas;

        public Titular() { ListaCuentas = new List<Cuenta>(); }


        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Cuenta> RetiraCuentas { get { return ListaCuentas; } }
        public void CargaCuenta(Cuenta cuenta)
        {
            try
            {
                Cuenta aux; 
                
                if(cuenta is CA) { aux = new CA(); }
                else { aux = new CC(); }
               

                ListaCuentas.Add(cuenta);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
