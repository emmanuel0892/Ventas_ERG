using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_ERG
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            txtUsuarioL.Focus();
        }

        private void bntIngresarU_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Hide();
            Principal principal = new Principal();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtPaswordL.PasswordChar = '*';
        }

        private void txtPaswordL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    bntIngresarU_Click(sender, e);
                }
        }

        private void txtUsuarioL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    bntIngresarU_Click(sender, e);
                }
        }

        private void bntIngresarU_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
