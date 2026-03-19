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
    public partial class Primos : Form
    {


        public Primos()
        {
            InitializeComponent();
        }
 


        private void button1_Click(object sender, EventArgs e)
        {
            List<int> listaPrimos = new List<int>();
            int numero1, numero2;
            numero1 = int.Parse(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);
            int minimo = Math.Min(numero1, numero2);
            int maximo = Math.Max(numero1, numero2);
            for (int i = minimo; i <= maximo; i++)
            {
                if (EsPrimo(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero %2 == 0) return false;
            int limite = (int)Math.Sqrt(numero);
            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
