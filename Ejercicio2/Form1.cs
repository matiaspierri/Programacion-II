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

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        List<Persona> personaList = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("Inserte DNI");
            string Nombre = Interaction.InputBox("Inserte Nombre");
            string Apellido = Interaction.InputBox("Inserte Apellido");
            Persona persona = new Persona(DNI, Nombre, Apellido);
            personaList.Add(persona);
            Mostrar(dataGridView1, personaList);
        }

        private void Mostrar(DataGridView dataGridView , object obj)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = obj;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox

            Auto auto = new Auto(Patente, Marca, Modelo, Anio, Precio, Persona);
        }
    }
}
