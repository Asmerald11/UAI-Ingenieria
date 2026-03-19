using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class frmradiobtn : Form
    {
        public frmradiobtn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Txt1.Text = null;
            this.Txt2.Text = null;
            this.TxtRta.Text = null;
        }

        private void Btnif_Click(object sender, EventArgs e)
        {
            if (this.Optresta.Checked)
            {
                this.TxtRta.Text = (Int32.Parse(Txt1.Text) - Int32.Parse(Txt2.Text)).ToString();
            } 
            if (this.Optsuma.Checked)
            {
                this.TxtRta.Text = (Int32.Parse(Txt1.Text) + Int32.Parse(Txt2.Text)).ToString();
            }
            if (this.Optprod.Checked)
            {
                this.TxtRta.Text = (Int32.Parse(Txt1.Text) * Int32.Parse(Txt2.Text)).ToString();
            }
            if (this.Optcoc.Checked)
            { if (Int32.Parse(Txt2.Text) != 0)
                {
                    this.TxtRta.Text = (Int32.Parse(Txt1.Text) / Int32.Parse(Txt2.Text)).ToString();
                }
            }
        }

        private void Btnswitch_Click(object sender, EventArgs e)
        {
            bool mayor_cero = true;
            int opcion = 0;
            if (this.Txt1.Text != null && this.Txt2.Text != null)
            {
                if (Int32.Parse(this.Txt2.Text) != 0)
                {
                    mayor_cero = true;
                }
                else
                {
                    mayor_cero = false;
                }
                if (this.Optsuma.Checked)
                {
                    opcion = 1;
                }
                else if (this.Optresta.Checked)
                {
                    opcion = 2;
                }
                else if (this.Optprod.Checked)
                {
                    opcion = 3;
                }
                else if (this.Optcoc.Checked)
                {
                    if (mayor_cero) opcion = 4;
                }

                switch (opcion)
                {
                    case 1:
                        this.TxtRta.Text = (Int32.Parse(Txt1.Text) + Int32.Parse(Txt2.Text)).ToString();
                        break;
                    case 2:
                        this.TxtRta.Text = (Int32.Parse(Txt1.Text) - Int32.Parse(Txt2.Text)).ToString();
                        break;
                    case 3:
                        this.TxtRta.Text = (Int32.Parse(Txt1.Text) * Int32.Parse(Txt2.Text)).ToString();
                        break;
                    case 4:
                        this.TxtRta.Text = (Int32.Parse(Txt1.Text) / Int32.Parse(Txt2.Text)).ToString();
                        break;
                    default:
                        string mensaje = "La operacion no se puede realizar";
                        string titulo = "Importante";
                        MessageBoxButtons botones = MessageBoxButtons.YesNo;
                        DialogResult resultado;
                        resultado = MessageBox.Show(mensaje, titulo, botones);
                        if (resultado == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Txt1.Text = null;
                            this.Txt2.Text = null;
                            this.TxtRta.Text = null;
                        }
                        break;
                }
            }
        }
    }
}
