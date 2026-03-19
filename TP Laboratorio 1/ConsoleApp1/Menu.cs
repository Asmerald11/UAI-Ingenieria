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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void radiobuttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmradiobtn frm = new frmradiobtn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manejo_de_checkbox frm = new Manejo_de_checkbox();
            frm.MdiParent = this;
            frm.Show();
        }

        private void groupBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManejoDeGroupbox frm = new ManejoDeGroupbox();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
