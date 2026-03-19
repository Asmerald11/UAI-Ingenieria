namespace TP_Laboratorio_2
{
    partial class Barra_de_Progreso
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
            this.Comenzar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Comenzar
            // 
            this.Comenzar.Location = new System.Drawing.Point(59, 39);
            this.Comenzar.Name = "Comenzar";
            this.Comenzar.Size = new System.Drawing.Size(75, 23);
            this.Comenzar.TabIndex = 0;
            this.Comenzar.Text = "Comenzar";
            this.Comenzar.UseVisualStyleBackColor = true;
            this.Comenzar.Click += new System.EventHandler(this.Comenzar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(59, 118);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Barra_de_Progreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 168);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Comenzar);
            this.Name = "Barra_de_Progreso";
            this.Text = "Barra_de_Progreso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Comenzar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}