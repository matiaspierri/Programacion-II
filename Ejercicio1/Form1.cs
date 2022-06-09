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

            //MessageBox.Show(DateAndTime.DateDiff(DateInterval.Year, FechaNacimiento, FechaIngreso).ToString());

            //MessageBox.Show(Legajo.ToString());

            Alumno alumno = new Alumno(Legajo,Nombre,Apellido,Edad,FechaNacimiento,FechaIngreso);




            
            MessageBox.Show("Alumno creado");

            alumnoList.Add(alumno);

            Mostrar(dataGridView1, alumnoList);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;

            EnumFormatoTiempo formato = (EnumFormatoTiempo)Int32.Parse(Interaction.InputBox("0.En anios 1. En meses 2. en dias"));


            alumnoSeleccionado.GetAntiguedad(formato);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alumno alumno = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;

            alumno.MateriasDesaprobadas();

        }


        private void Mostrar(DataGridView datagridview, object obj)
        {
            datagridview.DataSource = null;
            datagridview.DataSource = obj;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Alumno alumno = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;

            alumno.CantidadMateriasAprobadas += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumno alumno = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;

            alumno.EdadIngreso();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Alumno alumno = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;

            alumno.Apellido = Interaction.InputBox("Apellido", "modi", alumno.Apellido);
            alumno.Nombre = Interaction.InputBox("Apellido", "modi", alumno.Nombre);

            alumno.Legajo = int.Parse((Interaction.InputBox("Apellido", "modi", $"{alumno.Legajo}"));
        }
    }
}
