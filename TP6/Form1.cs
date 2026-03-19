using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Natatorio croll = new Natatorio();
            croll.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prioridades lista = new Prioridades();
            lista.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Movistar_Arena arena = new Movistar_Arena();
            arena.ShowDialog();
        }
    }
}
