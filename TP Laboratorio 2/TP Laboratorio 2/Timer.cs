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
    public partial class Timer : Form
    {
        int hora = 0, min = 0, seg = 0;

        private void Comenzar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Parar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Inicializar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "00:00:00";
            seg = 0;
            min = 0;
            hora = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            } else if (min == 60){
                hora++;
                min = 0;
            }
            label1.Text= hora.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
        }

        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }
    }
}
