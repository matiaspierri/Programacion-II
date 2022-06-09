using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EventosPractica
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }


        public event EventHandler EdadInvalida;

        public event EventHandler MiEvento;

        private int _edad;

        public int Edad
        {
            get { return _edad; }

            set
            {
                if (value < -1)
                {
                    EdadInvalida.Invoke(this, new EventArgs());




                }
                else { _edad = value; }
            }


        }

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;

            this.EdadInvalida += EdadIncorrectaMSG;

            this.MiEvento += MiFuncionDelEvento;

            MiEvento.Invoke(this, null);

        }


        private void EdadIncorrectaMSG(object sender, EventArgs e)
        {
            MessageBox.Show("La edad no puede ser menor a 1");
        }

        private void MiFuncionDelEvento(object sender, EventArgs e)
        {
            MessageBox.Show("Hola evento");
        }



   

    }
}
