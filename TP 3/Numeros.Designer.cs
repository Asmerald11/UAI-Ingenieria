namespace TP_3
{
    partial class Numeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListaNumeros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFijarCantidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique la cantidad de numeros y luego ingrese los numeros para sumar";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(386, 101);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 20);
            this.txtCantidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(127, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de numeros a ingresar";
            // 
            // txtListaNumeros
            // 
            this.txtListaNumeros.Location = new System.Drawing.Point(131, 196);
            this.txtListaNumeros.Multiline = true;
            this.txtListaNumeros.Name = "txtListaNumeros";
            this.txtListaNumeros.ReadOnly = true;
            this.txtListaNumeros.Size = new System.Drawing.Size(371, 20);
            this.txtListaNumeros.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(127, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numeros ingresados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(519, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new System.Drawing.Point(542, 194);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(38, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Res";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(523, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(386, 141);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(116, 20);
            this.txtIngreso.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(127, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese el numero";
            // 
            // btnFijarCantidad
            // 
            this.btnFijarCantidad.Location = new System.Drawing.Point(523, 99);
            this.btnFijarCantidad.Name = "btnFijarCantidad";
            this.btnFijarCantidad.Size = new System.Drawing.Size(75, 23);
            this.btnFijarCantidad.TabIndex = 10;
            this.btnFijarCantidad.Text = "Cantidad";
            this.btnFijarCantidad.UseVisualStyleBackColor = true;
            this.btnFijarCantidad.Click += new System.EventHandler(this.btnFijarCantidad_Click);
            // 
            // Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 256);
            this.Controls.Add(this.btnFijarCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtListaNumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Name = "Numeros";
            this.Text = "Numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListaNumeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFijarCantidad;
    }
}