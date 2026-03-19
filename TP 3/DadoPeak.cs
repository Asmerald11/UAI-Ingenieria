using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_3
{
    public partial class DadoPeak : Form
    {
        public DadoPeak()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(1, i, 0);
            dataGridView1.Rows.Add(2, j, 0);
            dataGridView1.Rows.Add(3, k, 0);
            dataGridView1.Rows.Add(4, l, 0);
            dataGridView1.Rows.Add(5, m, 0);
            dataGridView1.Rows.Add(6, n, 0);
        }
        private Random random = new Random();
        int i=0, j=0, k=0, l=0, m=0, n=0, x=0;

        private void button1_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int dado = random.Next(1, 7);
            int dado2 = aleatorio.Next(1, 7);
            switch (dado)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Cara1;
                    i++;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Cara2;
                    j++;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.cara3;
                    k++;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Cara4;
                    l++;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Cara5;
                    m++;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Cara6;
                    n++;
                    break;
                default:
                    break;
            }
            switch (dado2)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.Cara1;
                    i++;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Cara2;
                    j++;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.cara3;
                    k++;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Cara4;
                    l++;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.Cara5;
                    m++;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.Cara6;
                    n++;
                    break;
                default:
                    break;
            }
            x++;
            dataGridView1.Rows[0].Cells[1].Value = i;
            dataGridView1.Rows[0].Cells[2].Value = ((i * 100) / x)/2;
            dataGridView1.Rows[1].Cells[1].Value = j;
            dataGridView1.Rows[1].Cells[2].Value = ((j * 100) / x)/2;
            dataGridView1.Rows[2].Cells[1].Value = k;
            dataGridView1.Rows[2].Cells[2].Value = ((k * 100) / x)/2;
            dataGridView1.Rows[3].Cells[1].Value = l;
            dataGridView1.Rows[3].Cells[2].Value = ((l * 100) / x)/2;
            dataGridView1.Rows[4].Cells[1].Value = m;
            dataGridView1.Rows[4].Cells[2].Value = ((m * 100) / x)/2;
            dataGridView1.Rows[5].Cells[1].Value = n;
            dataGridView1.Rows[5].Cells[2].Value = ((n * 100) / x)/2;
        }
    }
}
