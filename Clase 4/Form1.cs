﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
