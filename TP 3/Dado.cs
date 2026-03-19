using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_3
{
    public partial class Dado : Form
    {
        public Dado()
        {
            InitializeComponent();
        }
        private Random rnd = new Random();
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int dado = rnd.Next(1, 7);
            switch (dado)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Cara1;
                    label2.Text = 1.ToString();
                    i++;
                    label4.Text = i.ToString();
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Cara2;
                    label2.Text = 2.ToString();
                    i++;
                    label4.Text = i.ToString();
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.cara3;
                    label2.Text = 3.ToString();
                    i++;
                    label4.Text = i.ToString();
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Cara4;
                    label2.Text = 4.ToString();
                    i++;
                    label4.Text = i.ToString();
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Cara5;
                    label2.Text = 5.ToString();
                    i++;
                    label4.Text = i.ToString();
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Cara6;
                    label2.Text = 6.ToString();
                    i++;
                    label4.Text = i.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
