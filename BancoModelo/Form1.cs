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

            Titular titular = new Titular(id, nroDocumento, nombre, apellido);  


            banco.AgregarTitular(titular);

            Mostrar(dataGridView1, banco.RetornaTitulares());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay nada parar borrar");
                banco.BorrarTitular(dataGridView1.SelectedRows[0].DataBoundItem as Titular);

                Mostrar(dataGridView1, banco.RetornaTitulares());


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay nada para modificar");
                
                Titular titular = dataGridView1.SelectedRows[0].DataBoundItem as Titular ;
                ID tdOrigen = titular.TipoDocumento;
                string nroOirgen = titular.NroDocumento;


                ID id = (ID)int.Parse(Interaction.InputBox($"Ingrese el tipo de documento{Environment.NewLine}" +
                                                    $"DNI = 0{Environment.NewLine}" +
                                                    $"CI = 1", "Modificando ...",((int)tdOrigen).ToString()));

                string nroDocumento = Interaction.InputBox("Ingrese el numero de documento");
                string nombre = Interaction.InputBox("Ingrese el nombre");
                string apellido = Interaction.InputBox("Ingrese el apellido");





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void Mostrar(DataGridView datagridview, Object obj)
        {
            datagridview.DataSource = null; 
            datagridview.DataSource = obj; 

        }
    }
}
