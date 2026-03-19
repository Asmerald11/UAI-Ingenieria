namespace TP_Laboratorio_2
{
    partial class Timer
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
            this.components = new System.ComponentModel.Container();
            this.Comenzar = new System.Windows.Forms.Button();
            this.Parar = new System.Windows.Forms.Button();
            this.Inicializar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Comenzar
            // 
            this.Comenzar.Location = new System.Drawing.Point(12, 188);
            this.Comenzar.Name = "Comenzar";
            this.Comenzar.Size = new System.Drawing.Size(75, 23);
            this.Comenzar.TabIndex = 0;
            this.Comenzar.Text = "Comenzar";
            this.Comenzar.UseVisualStyleBackColor = true;
            this.Comenzar.Click += new System.EventHandler(this.Comenzar_Click);
            // 
            // Parar
            // 
            this.Parar.Location = new System.Drawing.Point(93, 188);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(75, 23);
            this.Parar.TabIndex = 1;
            this.Parar.Text = "Parar";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.Parar_Click);
            // 
            // Inicializar
            // 
            this.Inicializar.Location = new System.Drawing.Point(174, 188);
            this.Inicializar.Name = "Inicializar";
            this.Inicializar.Size = new System.Drawing.Size(75, 23);
            this.Inicializar.TabIndex = 2;
            this.Inicializar.Text = "Inicializar";
            this.Inicializar.UseVisualStyleBackColor = true;
            this.Inicializar.Click += new System.EventHandler(this.Inicializar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "00:00:00";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inicializar);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.Comenzar);
            this.Name = "Timer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comenzar;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.Button Inicializar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}