namespace ConsoleApp1
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laboratorio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiobuttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratorio1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratorio1ToolStripMenuItem
            // 
            this.laboratorio1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radiobuttonToolStripMenuItem,
            this.checkBoxToolStripMenuItem,
            this.groupBoxToolStripMenuItem});
            this.laboratorio1ToolStripMenuItem.Name = "laboratorio1ToolStripMenuItem";
            this.laboratorio1ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.laboratorio1ToolStripMenuItem.Text = "Laboratorio1";
            // 
            // radiobuttonToolStripMenuItem
            // 
            this.radiobuttonToolStripMenuItem.Name = "radiobuttonToolStripMenuItem";
            this.radiobuttonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radiobuttonToolStripMenuItem.Text = "Radiobutton";
            this.radiobuttonToolStripMenuItem.Click += new System.EventHandler(this.radiobuttonToolStripMenuItem_Click);
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // groupBoxToolStripMenuItem
            // 
            this.groupBoxToolStripMenuItem.Name = "groupBoxToolStripMenuItem";
            this.groupBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupBoxToolStripMenuItem.Text = "GroupBox";
            this.groupBoxToolStripMenuItem.Click += new System.EventHandler(this.groupBoxToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratorio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiobuttonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupBoxToolStripMenuItem;
    }
}