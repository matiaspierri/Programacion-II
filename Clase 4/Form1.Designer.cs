namespace Clase_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AddChildButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.GoToForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolTip2
            // 
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(57, 142);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 1;
            // 
            // AddChildButton
            // 
            this.AddChildButton.Location = new System.Drawing.Point(57, 113);
            this.AddChildButton.Name = "AddChildButton";
            this.AddChildButton.Size = new System.Drawing.Size(75, 23);
            this.AddChildButton.TabIndex = 2;
            this.AddChildButton.Text = "Agregar hijo";
            this.AddChildButton.UseVisualStyleBackColor = true;
            this.AddChildButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(682, 52);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(83, 27);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Ir a la pagina";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(437, 56);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(239, 20);
            this.UrlTextBox.TabIndex = 4;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(437, 82);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(328, 250);
            this.webBrowser1.TabIndex = 5;
            // 
            // GoToForm2
            // 
            this.GoToForm2.BackColor = System.Drawing.SystemColors.Info;
            this.GoToForm2.Location = new System.Drawing.Point(48, 344);
            this.GoToForm2.Name = "GoToForm2";
            this.GoToForm2.Size = new System.Drawing.Size(144, 23);
            this.GoToForm2.TabIndex = 6;
            this.GoToForm2.Text = "Ver segunda parte";
            this.GoToForm2.UseVisualStyleBackColor = false;
            this.GoToForm2.Click += new System.EventHandler(this.GoToForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoToForm2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.AddChildButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AddChildButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button GoToForm2;
    }
}

