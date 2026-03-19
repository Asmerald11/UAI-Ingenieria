namespace TP_Laboratorio_2
{
    partial class Carga_de_Matrices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cargar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(12, 27);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(236, 34);
            this.Cargar.TabIndex = 0;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(12, 233);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(236, 34);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Listado
            // 
            this.Listado.FormattingEnabled = true;
            this.Listado.Location = new System.Drawing.Point(12, 67);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(236, 160);
            this.Listado.TabIndex = 2;
            // 
            // Carga_de_Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 303);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Cargar);
            this.Name = "Carga_de_Matrices";
            this.Text = "Carga_de_Matrices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.ListBox Listado;
    }
}