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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Suma suma = new Suma();
            suma.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SumLabel sum = new SumLabel();
            sum.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Numeros numeros = new Numeros();
            numeros.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Primos primos = new Primos();
            primos.ShowDialog(); 
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PlazoFijo plazo = new PlazoFijo();
            plazo.ShowDialog();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Dado dado = new Dado();
            dado.ShowDialog();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DadoPeak dadoPeak = new DadoPeak();
            dadoPeak.ShowDialog();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Temperatura temp = new Temperatura();
            temp.ShowDialog();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            TaTeTi tateti = new TaTeTi();
            tateti.ShowDialog();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            BackColor backColor = new BackColor();
            backColor.ShowDialog();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Fotos fotos = new Fotos();
            fotos.ShowDialog();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
