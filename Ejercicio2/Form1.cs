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

            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

            var autos = (from a in autoList select new{ 
                Marca= a.Marca,
                Año= a.Anio,
                Modelo= a.Modelo,
                Patente= a.Patente,
                DNI_del_dueño= a.Persona.DNI,
                Apellido_Nombre = $"{a.Persona.Nombre} {a.Persona.Apellido}" 
            }).ToList();

            Mostrar(dataGridView4, autos);
           
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

        private void button7_Click(object sender, EventArgs e)
        {
            Persona persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;

            persona.Nombre = Interaction.InputBox("Nombre:", "nombre", persona.Nombre);
            persona.DNI = Interaction.InputBox("DNI:", "nombre", persona.DNI);
            persona.Apellido = Interaction.InputBox("Apellido:", "nombre", persona.Apellido);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Persona persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;

            personaList.Remove(persona);
            persona = null;


        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Persona persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
            Auto auto = dataGridView2.SelectedRows[0].DataBoundItem as Auto;

            auto.Persona = persona;


            // Refresco el datagridview 4 porque se queda desactualizado
            var autos = (from a in autoList
                         select new
                         {
                             Marca = a.Marca,
                             Año = a.Anio,
                             Modelo = a.Modelo,
                             Patente = a.Patente,
                             DNI_del_dueño = a.Persona.DNI,
                             Apellido_Nombre = $"{a.Persona.Nombre} {a.Persona.Apellido}"
                         }).ToList();

            Mostrar(dataGridView4, autos);

        }
    }
}
