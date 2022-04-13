using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace Clase_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instancio el objeto ToolTip
            ToolTip toolTip1 = new ToolTip();


            // Le hago un set de tooltip agregandole el boton 1 y su mensaje de ayuda
            toolTip1.SetToolTip(this.button1, "Es un boton, hacer click");

            // Inicializo la data dummy del TreeView
            this.InitializeTreeView();

        }

        // Populates a TreeView control with example nodes. 
        private void InitializeTreeView()
        {

            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Padre");
            treeView1.Nodes[0].Nodes.Add("hijo 1");
            treeView1.Nodes[0].Nodes.Add("hijo 2");
            treeView1.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AddChild();
        }

        private void AddChild()
        {
            this.treeView1.BeginUpdate();
            treeView1.Nodes[0].Nodes.Add("hijo");
            this.treeView1.EndUpdate();
        }


        private void GoButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UrlTextBox.Text) || UrlTextBox.Text.Equals("about:blank"))
            {
                MessageBox.Show("Enter a valid URL.");
                UrlTextBox.Focus();
                return;
            }
            OpenURLInBrowser(UrlTextBox.Text);
        }

        private void OpenURLInBrowser(string url)
        {

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void GoToForm2_Click(object sender, EventArgs e)
        {
            // Instancio el form de clase form2 para seguir
            // con los ejercicios
            Form2 f = new Form2();
            f.Show();
        }

        private void GoToFBD_Click(object sender, EventArgs e)
        {

            FolderBrowserDialogExampleForm FormFBD = new FolderBrowserDialogExampleForm();

            FormFBD.Show();

        }

        private void ButtonOD_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }


        // Declare the PrintDocument object.
        private System.Drawing.Printing.PrintDocument docToPrint =
            new System.Drawing.Printing.PrintDocument();

        private void button3_Click(object sender, EventArgs e)
        {
            // Allow the user to choose the page range he or she would
            // like to print.
            PrintDialog1.AllowSomePages = true;

            // Show the help button.
            PrintDialog1.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            PrintDialog1.Document = docToPrint;

            DialogResult result = PrintDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }


        }

        // The PrintDialog will print the document
        // by handling the document's PrintPage event.
        private void document_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Insert code to render the page here.
            // This code will be called when the control is drawn.

            // The following code will render a simple
            // message on the printed document.
            string text = "In document_PrintPage method.";
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 35, System.Drawing.FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }
    }
}
