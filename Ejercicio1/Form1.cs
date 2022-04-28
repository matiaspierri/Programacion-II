using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;




namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Legajo = int.Parse(Interaction.InputBox("Legajo"));
            string Nombre = Interaction.InputBox("Nombre");
            string Apellido = Interaction.InputBox("Apellido");
            int Edad = int.Parse(Interaction.InputBox("Edad"));
            DateTime FechaNacimiento = DateTime.Parse(Interaction.InputBox("Coloque fecha de nacimiento en formato dd/mm/yyyy"));
            DateTime FechaIngreso = DateTime.Parse(Interaction.InputBox("Coloque fecha de ingreso en formato dd/mm/yyyy"));

            MessageBox.Show(DateAndTime.DateDiff(DateInterval.Year, FechaNacimiento, FechaIngreso).ToString());

            MessageBox.Show(Legajo.ToString());

        }
    }
}
