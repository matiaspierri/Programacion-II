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
        List<Auto> autoList = new List<Auto>();
        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            string DNI = Interaction.InputBox("DNI del titular");

            Persona persona = personaList.Find(p => p.DNI == DNI);


            string Patente = Interaction.InputBox("Inserte Patente");
            string Marca = Interaction.InputBox("Inserte Marca");
            string Modelo = Interaction.InputBox("Inserte Modelo");
            string Anio = Interaction.InputBox("Inserte Anio");
            decimal Precio = Convert.ToDecimal(Interaction.InputBox("Inserte Precio"));




            Auto auto = new Auto(Patente, Marca, Modelo, Anio, Precio, persona);

            autoList.Add(auto);

            Mostrar(dataGridView2, autoList);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;

            List<Auto> autosPersona = autoList.FindAll(auto => auto.Persona.DNI == persona.DNI);
            var autos = (from auto in autosPersona select new { patente = auto.Patente, propietario = $"{auto.Persona.Nombre}  {auto.Persona.Apellido}" }).ToList();


            Mostrar(dataGridView3, autos);

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Persona persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;

            personaList.Remove(persona);
            persona = null;

            Mostrar(dataGridView1, personaList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auto auto = dataGridView1.SelectedRows[0].DataBoundItem as Auto;
            Mostrar(dataGridView4, auto);
        }
    }
}
