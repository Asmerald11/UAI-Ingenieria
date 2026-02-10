using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDeUsuarioClase3
{
    public partial class FormLogin : Form
    {
        string[] nombre = { "usuario1", "usuario2", "usuario3" };
        string[] clave = { "123456", "654321", "hola123" };
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                textBoxPassword.BackColor = Color.White;
                textBoxUser.BackColor = Color.White;
                if (textBoxUser.Text.CompareTo(nombre[i]) == 0)
                {
                    if (textBoxPassword.Text.CompareTo(clave[i]) == 0)
                    {
                        this.BackColor = Color.Green;
                        break;
                    } else {
                        textBoxPassword.BackColor = Color.Red;
                        break;
                    }
                } else {
                    textBoxUser.BackColor = Color.Yellow;
                }
            } 
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
            textBoxUser.BackColor = Color.White;
            this.BackColor = Color.White;
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
            textBoxUser.BackColor = Color.White;
            this.BackColor = Color.White;
        }
    }
}
