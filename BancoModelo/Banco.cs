using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo
{
    public class Banco
    {
        List<Titular> listaTitular;
        List<Cuenta> listaCuenta;


        public Banco()
        {
            listaTitular = new List<Titular>();
            listaCuenta = new List<Cuenta>();
        }

        public void AgregarTitular(Titular titular)
        {

            try
            {

                Titular aux = new Titular(titular);
                listaTitular.Add(aux);
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        public void BorrarTitular(Titular titular)
        {
            Titular auxTitular = listaTitular.Find(x => x.TipoDocumento == titular.TipoDocumento &&
                                                  x.NroDocumento == titular.NroDocumento);
            if (auxTitular == null) throw new Exception("No se encontro el titular");

            foreach (Cuenta C in auxTitular.RetiraCuentas)
            {
                listaCuenta.Remove(listaCuenta.Find(x => x.Numero == C.Numero ));
            }

            listaTitular.Remove(auxTitular);
        }
           
        public List<Titular> RetornaTitulares()
        {
            List<Titular> ret = new List<Titular>();

            foreach (Titular titular in listaTitular)
            {
                ret.Add(new Titular(titular));
            }

            return ret;
        }
        
    }
}
