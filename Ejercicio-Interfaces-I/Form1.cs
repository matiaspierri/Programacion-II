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
/*
 * Mascotas:
 * especie
 * edad
 * raza
 * nombre
 * 
 * Ingresar mascotas y ordenarlas por cualqueir caracteristica
 * 
 * Anio de nacimiento en primer columna y raza: nombre de raza segunda columna
 */
namespace Ejercicio_Interfaces_I
{
    public partial class Form1 : Form
    {
        List<Mascota> listMascota = new List<Mascota>();

        IComparer<Mascota> comparer;
        OrdenarEspecieASC _esASC;
        OrdenarEspecieDSC _eDSC;
        Ordenar[] _ordenar;

        public Form1()
        {
            InitializeComponent();
            _esASC = new OrdenarEspecieASC();
            _eDSC = new OrdenarEspecieDSC();

            Ordenar[] _ordenar = new Ordenar[] { _esASC, _eDSC };
        }

        private void Polimorfico(Ordenar ordenar)
        {
            listMascota.Sort( ordenar.RetornaObjOrden());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox.addItems
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string especie = Interaction.InputBox("Nombre de la especie");
            int edad = int.Parse(Interaction.InputBox("Edad de la mascota"));
            string raza = Interaction.InputBox("Nombre de la raza");
            string nombre = Interaction.InputBox("Nombre de la mascota");

            Mascota mascota = new Mascota(especie, edad, raza, nombre);
            listMascota.Add(mascota);

            Mostrar(dataGridView1, listMascota);
        }

        void Mostrar(DataGridView datagridview, object obj)
        {
            datagridview.DataSource = obj;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
