using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void BotonLogin_Click(object sender, EventArgs e)
        {
            //if(textBoxUsuario.Text.Equals("CajeroAdm") && textBoxPass.Text.Equals("HnmX2020!"))
            if(textBoxUsuario.Text.Equals(""))
            {
                FormCaja caja = new FormCaja();
                this.Hide();
                caja.ShowDialog();
                caja.Dispose();
                this.Show();
            }
            else
            {
                textBoxUsuario.Clear();
                textBoxPass.Clear();
                MessageBox.Show("Usuario o Clave incorrectos");
            }
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {             
                e.Handled = true;
            }
        }
    }
}
