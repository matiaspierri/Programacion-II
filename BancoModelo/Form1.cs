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

namespace BancoModelo
{
    public partial class Form1 : Form
    {
        Banco banco;
        public Form1()
        {
            InitializeComponent();

            banco = new Banco();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ID id = (ID)int.Parse(Interaction.InputBox($"Ingrese el tipo de documento{Environment.NewLine}" +
                                                    $"DNI = 0{Environment.NewLine}" +
                                                    $"CI = 1"));

            string nroDocumento = Interaction.InputBox("Ingrese el numero de documento");
            string nombre = Interaction.InputBox("Ingrese el nombre");
            string apellido = Interaction.InputBox("Ingrese el apellido");



            banco.AgregarTitular();
        }
    }
}
