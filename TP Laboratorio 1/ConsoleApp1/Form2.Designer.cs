namespace ConsoleApp1
{
    partial class frmradiobtn
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.TxtRta = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Btnif = new System.Windows.Forms.Button();
            this.Btnswitch = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Optsuma = new System.Windows.Forms.RadioButton();
            this.Optresta = new System.Windows.Forms.RadioButton();
            this.Optprod = new System.Windows.Forms.RadioButton();
            this.Optcoc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(111, 30);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 0;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(111, 69);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 1;
            // 
            // TxtRta
            // 
            this.TxtRta.Location = new System.Drawing.Point(111, 110);
            this.TxtRta.Name = "TxtRta";
            this.TxtRta.Size = new System.Drawing.Size(100, 20);
            this.TxtRta.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(806, 141);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(88, 142);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Btnif
            // 
            this.Btnif.Location = new System.Drawing.Point(55, 277);
            this.Btnif.Name = "Btnif";
            this.Btnif.Size = new System.Drawing.Size(75, 23);
            this.Btnif.TabIndex = 5;
            this.Btnif.Text = "Con if";
            this.Btnif.UseVisualStyleBackColor = true;
            this.Btnif.Click += new System.EventHandler(this.Btnif_Click);
            // 
            // Btnswitch
            // 
            this.Btnswitch.Location = new System.Drawing.Point(136, 277);
            this.Btnswitch.Name = "Btnswitch";
            this.Btnswitch.Size = new System.Drawing.Size(75, 23);
            this.Btnswitch.TabIndex = 6;
            this.Btnswitch.Text = "Con switch";
            this.Btnswitch.UseVisualStyleBackColor = true;
            this.Btnswitch.Click += new System.EventHandler(this.Btnswitch_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(170, 309);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(75, 23);
            this.Btnsalir.TabIndex = 7;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Optcoc);
            this.GroupBox1.Controls.Add(this.Optprod);
            this.GroupBox1.Controls.Add(this.Optresta);
            this.GroupBox1.Controls.Add(this.Optsuma);
            this.GroupBox1.Location = new System.Drawing.Point(24, 171);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(212, 100);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Operaciones";
            // 
            // Optsuma
            // 
            this.Optsuma.AutoSize = true;
            this.Optsuma.Location = new System.Drawing.Point(19, 28);
            this.Optsuma.Name = "Optsuma";
            this.Optsuma.Size = new System.Drawing.Size(52, 17);
            this.Optsuma.TabIndex = 0;
            this.Optsuma.TabStop = true;
            this.Optsuma.Text = "Suma";
            this.Optsuma.UseVisualStyleBackColor = true;
            // 
            // Optresta
            // 
            this.Optresta.AutoSize = true;
            this.Optresta.Location = new System.Drawing.Point(109, 28);
            this.Optresta.Name = "Optresta";
            this.Optresta.Size = new System.Drawing.Size(53, 17);
            this.Optresta.TabIndex = 1;
            this.Optresta.TabStop = true;
            this.Optresta.Text = "Resta";
            this.Optresta.UseVisualStyleBackColor = true;
            // 
            // Optprod
            // 
            this.Optprod.AutoSize = true;
            this.Optprod.Location = new System.Drawing.Point(19, 65);
            this.Optprod.Name = "Optprod";
            this.Optprod.Size = new System.Drawing.Size(89, 17);
            this.Optprod.TabIndex = 2;
            this.Optprod.TabStop = true;
            this.Optprod.Text = "Multiplicacion";
            this.Optprod.UseVisualStyleBackColor = true;
            // 
            // Optcoc
            // 
            this.Optcoc.AutoSize = true;
            this.Optcoc.Location = new System.Drawing.Point(109, 65);
            this.Optcoc.Name = "Optcoc";
            this.Optcoc.Size = new System.Drawing.Size(62, 17);
            this.Optcoc.TabIndex = 3;
            this.Optcoc.TabStop = true;
            this.Optcoc.Text = "Division";
            this.Optcoc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "1er operador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "2do operador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmradiobtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnswitch);
            this.Controls.Add(this.Btnif);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.TxtRta);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Name = "frmradiobtn";
            this.Text = "Calculadora con radioboton";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox TxtRta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button Btnif;
        private System.Windows.Forms.Button Btnswitch;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton Optcoc;
        private System.Windows.Forms.RadioButton Optprod;
        private System.Windows.Forms.RadioButton Optresta;
        private System.Windows.Forms.RadioButton Optsuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}