namespace ConsoleApp1
{
    partial class Form1
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
            this.Op1 = new System.Windows.Forms.TextBox();
            this.Resu = new System.Windows.Forms.TextBox();
            this.Op2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btnsuma = new System.Windows.Forms.Button();
            this.Btnresta = new System.Windows.Forms.Button();
            this.Btndiv = new System.Windows.Forms.Button();
            this.Btnmult = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Op1
            // 
            this.Op1.Location = new System.Drawing.Point(12, 25);
            this.Op1.Name = "Op1";
            this.Op1.Size = new System.Drawing.Size(92, 20);
            this.Op1.TabIndex = 0;
            // 
            // Resu
            // 
            this.Resu.Location = new System.Drawing.Point(12, 116);
            this.Resu.Name = "Resu";
            this.Resu.Size = new System.Drawing.Size(92, 20);
            this.Resu.TabIndex = 1;
            // 
            // Op2
            // 
            this.Op2.Location = new System.Drawing.Point(12, 69);
            this.Op2.Name = "Op2";
            this.Op2.Size = new System.Drawing.Size(92, 20);
            this.Op2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1er operador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2do operador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // Btnsuma
            // 
            this.Btnsuma.Location = new System.Drawing.Point(161, 23);
            this.Btnsuma.Name = "Btnsuma";
            this.Btnsuma.Size = new System.Drawing.Size(85, 23);
            this.Btnsuma.TabIndex = 6;
            this.Btnsuma.Text = "Suma";
            this.Btnsuma.UseVisualStyleBackColor = true;
            this.Btnsuma.Click += new System.EventHandler(this.Btnsuma_Click);
            // 
            // Btnresta
            // 
            this.Btnresta.Location = new System.Drawing.Point(161, 53);
            this.Btnresta.Name = "Btnresta";
            this.Btnresta.Size = new System.Drawing.Size(85, 23);
            this.Btnresta.TabIndex = 7;
            this.Btnresta.Text = "Resta";
            this.Btnresta.UseVisualStyleBackColor = true;
            this.Btnresta.Click += new System.EventHandler(this.Btnresta_Click);
            // 
            // Btndiv
            // 
            this.Btndiv.Location = new System.Drawing.Point(161, 82);
            this.Btndiv.Name = "Btndiv";
            this.Btndiv.Size = new System.Drawing.Size(85, 23);
            this.Btndiv.TabIndex = 8;
            this.Btndiv.Text = "Division";
            this.Btndiv.UseVisualStyleBackColor = true;
            this.Btndiv.Click += new System.EventHandler(this.Btndiv_Click);
            // 
            // Btnmult
            // 
            this.Btnmult.Location = new System.Drawing.Point(161, 111);
            this.Btnmult.Name = "Btnmult";
            this.Btnmult.Size = new System.Drawing.Size(85, 23);
            this.Btnmult.TabIndex = 9;
            this.Btnmult.Text = "Multiplicacion";
            this.Btnmult.UseVisualStyleBackColor = true;
            this.Btnmult.Click += new System.EventHandler(this.Btnmult_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(149, 162);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(75, 23);
            this.Btnsalir.TabIndex = 10;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnmult);
            this.Controls.Add(this.Btndiv);
            this.Controls.Add(this.Btnresta);
            this.Controls.Add(this.Btnsuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Op2);
            this.Controls.Add(this.Resu);
            this.Controls.Add(this.Op1);
            this.Name = "Form1";
            this.Text = "Calculadora simple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Op1;
        private System.Windows.Forms.TextBox Resu;
        private System.Windows.Forms.TextBox Op2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btnsuma;
        private System.Windows.Forms.Button Btnresta;
        private System.Windows.Forms.Button Btndiv;
        private System.Windows.Forms.Button Btnmult;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button button1;
    }
}