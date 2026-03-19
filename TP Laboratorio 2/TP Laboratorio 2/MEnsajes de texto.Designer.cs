namespace TP_Laboratorio_2
{
    partial class MEnsajes_de_texto
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
            this.Mensaje1 = new System.Windows.Forms.Button();
            this.Mensaje2 = new System.Windows.Forms.Button();
            this.Mensaje3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mensaje1
            // 
            this.Mensaje1.Location = new System.Drawing.Point(41, 23);
            this.Mensaje1.Name = "Mensaje1";
            this.Mensaje1.Size = new System.Drawing.Size(104, 43);
            this.Mensaje1.TabIndex = 0;
            this.Mensaje1.Text = "Mensaje 1";
            this.Mensaje1.UseVisualStyleBackColor = true;
            this.Mensaje1.Click += new System.EventHandler(this.Mensaje1_Click);
            // 
            // Mensaje2
            // 
            this.Mensaje2.Location = new System.Drawing.Point(41, 72);
            this.Mensaje2.Name = "Mensaje2";
            this.Mensaje2.Size = new System.Drawing.Size(104, 43);
            this.Mensaje2.TabIndex = 1;
            this.Mensaje2.Text = "Mensaje 2";
            this.Mensaje2.UseVisualStyleBackColor = true;
            this.Mensaje2.Click += new System.EventHandler(this.Mensaje2_Click);
            // 
            // Mensaje3
            // 
            this.Mensaje3.Location = new System.Drawing.Point(41, 121);
            this.Mensaje3.Name = "Mensaje3";
            this.Mensaje3.Size = new System.Drawing.Size(104, 43);
            this.Mensaje3.TabIndex = 2;
            this.Mensaje3.Text = "Mensaje 3";
            this.Mensaje3.UseVisualStyleBackColor = true;
            this.Mensaje3.Click += new System.EventHandler(this.Mensaje3_Click);
            // 
            // MEnsajes_de_texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 184);
            this.Controls.Add(this.Mensaje3);
            this.Controls.Add(this.Mensaje2);
            this.Controls.Add(this.Mensaje1);
            this.Name = "MEnsajes_de_texto";
            this.Text = "MEnsajes_de_texto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mensaje1;
        private System.Windows.Forms.Button Mensaje2;
        private System.Windows.Forms.Button Mensaje3;
    }
}