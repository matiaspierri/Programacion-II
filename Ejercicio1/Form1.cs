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
        List<Alumno> alumnoList = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Legajo = int.Parse(Interaction.InputBox("Legajo"));
            string Nombre = Interaction.InputBox("Nombre");
            string Apellido = Interaction.InputBox("Apellido");
            int Edad = int.Parse(Interaction.InputBox("Edad"));
            DateTime FechaNacimiento = DateTime.Parse(Interaction.InputBox("Coloque fecha de nacimiento en formato mm/dd/yyyy"));
            DateTime FechaIngreso = DateTime.Parse(Interaction.InputBox("Coloque fecha de ingreso en formato mm/dd/yyyy"));

            Alumno alumno = new Alumno(Legajo,Nombre,Apellido,Edad,FechaNacimiento,FechaIngreso);

            alumnoList.Add(alumno);

            
            MessageBox.Show("Alumno creado");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
