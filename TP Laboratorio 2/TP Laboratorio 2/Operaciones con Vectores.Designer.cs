namespace TP_Laboratorio_2
{
    partial class Operaciones_con_Vectores
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Cargar = new System.Windows.Forms.Button();
            this.Ordenar = new System.Windows.Forms.Button();
            this.Copiar = new System.Windows.Forms.Button();
            this.Limites = new System.Windows.Forms.Button();
            this.BusqBinaria = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 186);
            this.listBox1.TabIndex = 0;
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(136, 23);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(101, 28);
            this.Cargar.TabIndex = 1;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // Ordenar
            // 
            this.Ordenar.Location = new System.Drawing.Point(61, 286);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(101, 28);
            this.Ordenar.TabIndex = 2;
            this.Ordenar.Text = "Ordenar";
            this.Ordenar.UseVisualStyleBackColor = true;
            this.Ordenar.Click += new System.EventHandler(this.Ordenar_Click);
            // 
            // Copiar
            // 
            this.Copiar.Location = new System.Drawing.Point(223, 286);
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(101, 28);
            this.Copiar.TabIndex = 3;
            this.Copiar.Text = "Copiar";
            this.Copiar.UseVisualStyleBackColor = true;
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // Limites
            // 
            this.Limites.Location = new System.Drawing.Point(61, 332);
            this.Limites.Name = "Limites";
            this.Limites.Size = new System.Drawing.Size(101, 28);
            this.Limites.TabIndex = 4;
            this.Limites.Text = "Limites";
            this.Limites.UseVisualStyleBackColor = true;
            this.Limites.Click += new System.EventHandler(this.Limites_Click);
            // 
            // BusqBinaria
            // 
            this.BusqBinaria.Location = new System.Drawing.Point(223, 332);
            this.BusqBinaria.Name = "BusqBinaria";
            this.BusqBinaria.Size = new System.Drawing.Size(101, 28);
            this.BusqBinaria.TabIndex = 5;
            this.BusqBinaria.Text = "B. Binaria";
            this.BusqBinaria.UseVisualStyleBackColor = true;
            this.BusqBinaria.Click += new System.EventHandler(this.BusqBinaria_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(136, 366);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(101, 28);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Operaciones_con_Vectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 410);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.BusqBinaria);
            this.Controls.Add(this.Limites);
            this.Controls.Add(this.Copiar);
            this.Controls.Add(this.Ordenar);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.listBox1);
            this.Name = "Operaciones_con_Vectores";
            this.Text = "Operaciones_con_Vectores";
            this.Load += new System.EventHandler(this.Operaciones_con_Vectores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button Ordenar;
        private System.Windows.Forms.Button Copiar;
        private System.Windows.Forms.Button Limites;
        private System.Windows.Forms.Button BusqBinaria;
        private System.Windows.Forms.Button Salir;
    }
}