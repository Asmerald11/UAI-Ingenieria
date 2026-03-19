using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital();
            hospital.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Escuela escuela = new Escuela();
            escuela.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cine cine = new Cine();
            cine.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Jardin jardin = new Jardin();
            jardin.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HouseMD house = new HouseMD();
            house.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hollywood hollywood = new Hollywood();
            hollywood.ShowDialog();
        }
    }
}
