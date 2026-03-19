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
    public partial class Numeros : Form
    {
        private int cantidadTotalEsperada = 0;
        private List<double> numeros = new List<double>();
        double sumaTotal = 0;
        public Numeros()
        {
            InitializeComponent();
            txtIngreso.Enabled = false;
            btnAgregar.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtIngreso.Text, out double nuevoNumero))
            {
                numeros.Add(nuevoNumero);
                txtListaNumeros.AppendText(nuevoNumero.ToString() + "-");
                txtIngreso.Clear();
                txtIngreso.Focus();

                if (numeros.Count >= cantidadTotalEsperada) {
                    sumaTotal = numeros.Sum();
                    lblResultado.Text = sumaTotal.ToString();
                    txtIngreso.Enabled = false;
                    btnAgregar.Enabled = false;

                }
            }else
            {
                MessageBox.Show("Por favor, ingrese un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIngreso.Clear();
                txtIngreso.Focus();
            }
           
            
        }

        private void btnFijarCantidad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out cantidadTotalEsperada) && cantidadTotalEsperada > 0)
            {

                txtCantidad.Enabled = false;
                btnFijarCantidad.Enabled = false;

                txtIngreso.Enabled = true;
                btnAgregar.Enabled = true;
                txtIngreso.Focus();

                lblResultado.Text = "Esperando números...";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad entera válida mayor a 0.", "Error de cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }
    }

