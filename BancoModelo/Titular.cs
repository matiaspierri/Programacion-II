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

        public Titular() 
        { 
            ListaCuentas = new List<Cuenta>(); 
        }

        public Titular(Titular titular)
        {
            TipoDocumento = titular.TipoDocumento;
            NroDocumento = titular.NroDocumento;
            Nombre = titular.Nombre;
            Apellido = titular.Apellido;
            ListaCuentas = titular.RetiraCuentas;
        }

        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Cuenta> RetiraCuentas { 
            get {
                List<Cuenta> auxLista = new List<Cuenta>();

                try
                {
                    foreach(Cuenta c in ListaCuentas)
                    {
                        Cuenta auxC;

                        if (c is CA) { auxC = new CA(c); }
                        else { auxC = new CC(c); }

                        auxLista.Add(auxC);

                        
                    }
                }
                catch (Exception ex){ throw ex; }

                return auxLista;
            } 
        }

        public void CargaCuenta(Cuenta cuenta)
        {
            try
            {
                Cuenta aux; 
                
                if(cuenta is CA) { aux = new CA(cuenta); }
                else { aux = new CC(cuenta); }
               

                ListaCuentas.Add(aux);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public enum ID
    {
        DNI,
        CI
    }
}
