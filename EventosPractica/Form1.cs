using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona();

  

            persona.Edad = -2;

            Sumar sumar = new Sumar();

            decimal result = Calcular(sumar, 2, 3);

            MessageBox.Show(result.ToString());
            
        }


        private decimal Calcular(Operaciones operacion,decimal a, decimal b) 
        {
            return operacion.Calcular(a, b);
        }


    }
}
