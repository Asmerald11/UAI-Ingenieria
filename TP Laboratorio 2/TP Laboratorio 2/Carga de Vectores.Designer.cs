namespace TP_Laboratorio_2
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
            this.Cargar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(42, 39);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(237, 23);
            this.Cargar.TabIndex = 0;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(42, 294);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(237, 23);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Listado
            // 
            this.Listado.FormattingEnabled = true;
            this.Listado.Location = new System.Drawing.Point(42, 79);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(237, 199);
            this.Listado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 374);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.ListBox Listado;
    }
}

