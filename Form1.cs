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
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TsmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            
            V.TopLevel = false;
            V.Dock = DockStyle.Fill;
            V.Parent = panel2;
            V.Show();
            V.BringToFront();

        }
        Ventas V = new Ventas();

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Pro.TopLevel = false;
            Pro.Dock = DockStyle.Fill;
            Pro.Parent = panel2;
            Pro.Show();
            Pro.BringToFront();
        }
        Productos Pro = new Productos();
    }
}
