using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Laboratorio_2
{
    public partial class Manejo_de_Strings : Form
    {
        public Manejo_de_Strings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string variable = textBox1.Text;
            textBox2.Text = variable.Length.ToString();
            if (txtdato.Text.Length > 0)
            {
                int pos = Convert.ToInt32(txtdato.Text);
                textBox3.Text = (variable[pos]).ToString();
            }
            textBox4.Text = variable.Insert(3, "12345");
            textBox8.Text = variable.TrimStart();
            if ((variable.Length < 10))
            {
                textBox7.Text = variable.PadRight(10, '0');
            }
            txt8.Text = string.Concat(txt9, variable);
            if (textBox6.Text == "ABC")
            {
                textBox6.Text = "Si";
            }
            else
            {
                textBox6.Text = "No";
            }
        }
    }
}
