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
    public partial class Temperatura : Form
    {
        private int caso = 0;

        public Temperatura()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            caso = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            caso = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            caso = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            caso = 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double tempi = 0, tempf = 0;
            switch (caso)
            {
                case 1:
                    tempi = double.Parse(textBox1.Text);
                    tempf = double.Parse(textBox1.Text);
                    dataGridView1.Rows.Add("Celsius", "Celsius", tempi, " ", tempf);
                    break;
                case 2:
                    tempi = double.Parse(textBox1.Text);
                    tempf = (tempi * 1.8) + 32;
                    dataGridView1.Rows.Add("Fahrenheit", "Celsius", tempi, "(Temp. Inicial * 1.8) + 32", tempf);
                    break;
                case 3:
                    tempi = double.Parse(textBox1.Text);
                    tempf = tempi + 273.15;
                    dataGridView1.Rows.Add("Kelvin", "Celsius", tempi, "(Temp. Inicial + 273.15", tempf);
                    break;
                case 4:
                    tempi = double.Parse(textBox1.Text);
                    tempf = (tempi * 1.8) + 491.67;
                    dataGridView1.Rows.Add("Rankine", "Celsius", tempi, "(Temp. Inicial * 1.8) + 491.67", tempf);
                    break;
                default: break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tempi = 0, tempf = 0;
            switch (caso)
            {
                case 1:
                    tempi = double.Parse(textBox1.Text);
                    tempf = (tempi - 32) / 1.8;
                    dataGridView1.Rows.Add("Celsius", "Fahrenheit", tempi, "(Temp. Inicial - 32) / 1.8", tempf);
                    break;
                case 2:
                    tempi = double.Parse(textBox1.Text);
                    tempf = double.Parse(textBox1.Text);
                    dataGridView1.Rows.Add("Fahrenheit", "Fahrenheit", tempi, "", tempf);
                    break;
                case 3:
                    tempi = double.Parse(textBox1.Text);
                    tempf = (tempi - 32) / 1.8 + 273.15;
                    dataGridView1.Rows.Add("Kelvin", "Fahrenheit", tempi, "(Temp. Inicial - 32) / 1.8 + 273.15", tempf);
                    break;
                case 4:
                    tempi = double.Parse(textBox1.Text);
                    tempf = tempi + 459.67;
                    dataGridView1.Rows.Add("Rankine", "Fahrenheit", tempi, "(Temp. Inicial + 459.67", tempf);
                    break;
                default: break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tempi = 0, tempf = 0;
            switch (caso)
            {
                case 1:
                    tempi = double.Parse(textBox1.Text);
                    tempf = tempi - 273.15;
                    dataGridView1.Rows.Add("Celsius", "Kelvin", tempi, "tempi - 273.15", tempf);
                    break;
                case 2:
                    tempi = double.Parse(textBox1.Text);
                    tempf = (tempi - 273.15) * 1.8 + 32;
                    dataGridView1.Rows.Add("Fahrenheit", "Kelvin", tempi, "(Temp. Inicial - 273.15) * 1.8 + 32", tempf);
                    break;
                case 3:
                    tempi = double.Parse(textBox1.Text);
                    tempf = double.Parse(textBox1.Text);
                    dataGridView1.Rows.Add("Kelvin", "Kelvin", tempi, "", tempf);
                    break;
                case 4:
                    tempi = double.Parse(textBox1.Text);
                    tempf = tempi * 1.8;
                    dataGridView1.Rows.Add("Rankine", "Kelvin", tempi, "Temp. Inicial * 1.8", tempf);
                    break;
                default: break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double tempi = 0, tempf = 0;
            switch (caso)
            {
                case 1:
                    tempi = double.Parse(textBox1.Text);
                    tempf = (tempi - 491.67) * 1.8 - 273.15;
                    dataGridView1.Rows.Add("Celsius", "Rankine", tempi, "(Temp. Inicial - 491.67) * 1.8 - 273.15", tempf);
                    break;
                case 2:
                    tempi = double.Parse(textBox1.Text);
                    tempf = tempi - 459.67;
                    dataGridView1.Rows.Add("Fahrenheit", "Rankine", tempi, "Temp. Inicial - 459.67", tempf);
                    break;
                case 3:
                    tempi = double.Parse(textBox1.Text);
                    tempf = tempi * 1.8;
                    dataGridView1.Rows.Add("Kelvin", "Rankine", tempi, "Temp. Inicial * 1.8", tempf);
                    break;
                case 4:
                    tempi = double.Parse(textBox1.Text);
                    tempf = double.Parse(textBox1.Text);
                    dataGridView1.Rows.Add("Rankine", "Rankine", tempi, "", tempf);
                    break;
                default: break;
            }
        }
    }
}
