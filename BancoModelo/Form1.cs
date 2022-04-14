using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoModelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Banco
        {

        }

        public class Titular
        {

            List<Cuenta> listaCuentas; 

            public Titular() { ListaCuentas = new List<Cuenta>(); }


            public string TipoDocumento { get; set; }
            public string NroDocumento { get; set; }

            public string Nombre { get; set; }  
            public string Apellido { get; set; }

            public List<Cuenta> RetiraCuentas { get { return listaCuentas; } }
            public void CargaCuenta(Cuenta cuenta)
            {
                try
                {
                    listaCuentas.Add(cuenta);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public abstract class Cuenta
        {
            public string Numero { get; set; }  
            public decimal Saldo { get; set; }

            public Titular titular { get; set; }


            public void Depositar(decimal importe)
            {
                try
                {
                    if (importe < 0) throw new Exception("Monto negativo ");
                    Saldo += importe;
                }
                catch (Exception ex )
                {

                    throw ex ;
                }
            }

            public 
        }

        public class CA: Cuenta
        {

        }

        public class CC: Cuenta
        {

        }


    }
}
