using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Manejo_de_checkbox : Form
    {
        public Manejo_de_checkbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.checkBox1.Checked == true ) & (this.checkBox2.Checked == false )) 
            {
                label1.BackColor = Color.Aquamarine;
                label2.BackColor = Color.Beige;
                label3.BackColor = Color.Black;
            }
            if ((this.checkBox1.Checked == false) & (this.checkBox2.Checked == true))
            {
                label1.BackColor = Color.Green;
                label2.BackColor = Color.LightPink;
                label3.BackColor = Color.Linen;
            }
            if ((this.checkBox1.Checked == true) & (this.checkBox2.Checked == true))
            {
                label1.BackColor = Color.Blue;
                label2.BackColor = Color.White;
                label3.BackColor = Color.Blue;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}