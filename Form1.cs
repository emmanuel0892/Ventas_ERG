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
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            btnAtras.Hide();
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
            btnUsuarios.Show();
            btnProductos.Show();
            btnCat.Show();

            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            btnAtras.Hide();
            
            V.TopLevel = false;
            V.Dock = DockStyle.Fill;
            V.Parent = panel2;
            V.Show();
            V.BringToFront();

        }
        Ventas V = new Ventas();

        private void btnProductos_Click(object sender, EventArgs e)
        {
            btnNuevoPro.Show();
            btnEditPro.Show();
            btnEliminarPro.Show();
            btnAtras.Show();

            btnCat.Hide();
            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnProductos.Hide();
            btnCat.Hide();

            btnNuevoUs.Show();
            btnEditUs.Show();
            btnEliminarUs.Show();
            btnAtras.Show();

            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();
        }

        private void btnNuevoPro_Click(object sender, EventArgs e)
        {
            CreacionPro.TopLevel = false;
            CreacionPro.Dock = DockStyle.Fill;
            CreacionPro.Parent = panel2;
            CreacionPro.Show();
            CreacionPro.BringToFront();

            btnCat.Show();

            btnAtras.Hide();

            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();
        }
        CreacionPro CreacionPro = new CreacionPro();

        private void btnEditPro_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();
            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();
            btnAtras.Hide();
            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            btnUsuarios.Show();
            btnProductos.Show();
            btnCat.Show();
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            btnNuevCat.Show();
            btnEditCat.Show();
            btnElimCat.Show();
            btnAtras.Show();

            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();
        }

        private void btnNuevCat_Click(object sender, EventArgs e)
        {
            cat.TopLevel = true;
            cat.Show();
            cat.BringToFront();
            cat.TopMost = true;

            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();
        }
        Categorias cat = new Categorias();
    }
}
