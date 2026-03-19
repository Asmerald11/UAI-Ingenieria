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
    public partial class BackColor : Form
    {
        public BackColor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog cuadroColor = new ColorDialog())
            {
                cuadroColor.AllowFullOpen = true;      
                cuadroColor.FullOpen = true;           
                cuadroColor.Color = this.BackColor;    

                if (cuadroColor.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = cuadroColor.Color;
                }
            }
        }
    }
}
