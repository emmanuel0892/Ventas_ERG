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

            timer1.Enabled = true;


            //botones de Venta
            btnVenN.Hide();
            btnNotaCre.Hide();
            btnGuiaDes.Hide();
            btnNotaDeb.Hide();

            //botones de Usuarios
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            //botones de Productos
            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            //botones de Categorías
            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            //botones de Reportes
            btnRepoF.Hide();
            btnRepoV.Hide();
            btnRepoComi.Hide();
            btnRepoMer.Hide();

            //botones de Tesorería
            btnApeCaja.Hide();
            btnReti.Hide();
            btnDepo.Hide();
            btnCierrC.Hide();

            //boton para retroceder en los menu
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
            btnVenN.Show();
            btnNotaCre.Show();
            btnNotaCre.BringToFront();
            btnGuiaDes.Show();
            btnGuiaDes.BringToFront();
            btnNotaDeb.Show();
            btnNotaDeb.BringToFront();

            btnAtras.Show();

            btnUsuarios.Location = new System.Drawing.Point(1,260);
            btnProductos.Location = new System.Drawing.Point(1, 348);
            btnCat.Location = new System.Drawing.Point(1, 435);
            btnReportes.Location = new System.Drawing.Point(1, 523);
            btnTeso.Location = new System.Drawing.Point(1, 611);

            btnAtras.Location = new System.Drawing.Point(1, 205);

            //botones de Usuarios
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            //botones de Productos
            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            //botones de Categorías
            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            //botones de Reportes
            btnRepoF.Hide();
            btnRepoV.Hide();
            btnRepoComi.Hide();
            btnRepoMer.Hide();

            //botones de Tesorería
            btnApeCaja.Hide();
            btnReti.Hide();
            btnDepo.Hide();
            btnCierrC.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            btnVenta.Location = new System.Drawing.Point(1, 0);
            btnUsuarios.Location = new System.Drawing.Point(1, 89);
            btnProductos.Location = new System.Drawing.Point(1, 178);
            btnCat.Location = new System.Drawing.Point(1, 425);
            btnReportes.Location = new System.Drawing.Point(1, 513);
            btnTeso.Location = new System.Drawing.Point(1, 601);

            btnAtras.Location = new System.Drawing.Point(1, 370);
            btnAtras.Show();

            //botones de Venta
            btnVenN.Hide();
            btnNotaCre.Hide();
            btnGuiaDes.Hide();
            btnNotaDeb.Hide();

            //botones de Usuarios
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            //botones de Productos
            btnNuevoPro.Show();
            btnEditPro.Show();
            btnEliminarPro.Show();

            //botones de Categorías
            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            //botones de Reportes
            btnRepoF.Hide();
            btnRepoV.Hide();
            btnRepoComi.Hide();
            btnRepoMer.Hide();

            //botones de Tesorería
            btnApeCaja.Hide();
            btnReti.Hide();
            btnDepo.Hide();
            btnCierrC.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnVenta.Location = new System.Drawing.Point(1, 0);
            btnUsuarios.Location = new System.Drawing.Point(1, 89);
            btnProductos.Location = new System.Drawing.Point(1, 320);
            btnCat.Location = new System.Drawing.Point(1, 408);
            btnReportes.Location = new System.Drawing.Point(1, 496);
            btnTeso.Location = new System.Drawing.Point(1, 584);
            btnAtras.Location = new Point(1, 265);

            btnVenN.Hide();
            btnNotaCre.Hide();
            btnGuiaDes.Hide();
            btnNotaDeb.Hide();

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

            txtFechaHora.BringToFront();

            btnVenta.Show();
            btnVenta.Location = new Point(1, 0);

            btnUsuarios.Show();
            btnUsuarios.Location = new Point(1, 89);

            btnProductos.Show();
            btnProductos.Location = new Point(1, 178);

            btnCat.Show();
            btnCat.Location = new Point(1, 267);

            btnReportes.Show();
            btnReportes.Location = new Point(1, 356);

            btnTeso.Show();
            btnTeso.Location = new Point(1, 445);

            btnAtras.Hide();

            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();
        }
        CreacionPro CreacionPro = new CreacionPro();

        private void btnEditPro_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //botones de Venta
            btnVenN.Hide();
            btnNotaCre.Hide();
            btnGuiaDes.Hide();
            btnNotaDeb.Hide();

            //botones de Usuarios
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            //botones de Productos
            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            //botones de Categorías
            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            //botones de Reportes
            btnRepoF.Hide();
            btnRepoV.Hide();
            btnRepoComi.Hide();
            btnRepoMer.Hide();

            //botones de Tesorería
            btnApeCaja.Hide();
            btnReti.Hide();
            btnDepo.Hide();
            btnCierrC.Hide();

            //boton para retroceder en los menu
            btnAtras.Hide();

            btnVenta.Show();
            btnVenta.Location = new Point(1, 0);

            btnUsuarios.Show();
            btnUsuarios.Location = new Point(1, 89);

            btnProductos.Show();
            btnProductos.Location = new Point(1, 178);

            btnCat.Show();
            btnCat.Location = new Point(1, 267);

            btnReportes.Show();
            btnReportes.Location = new Point(1, 356);

            btnTeso.Show();
            btnTeso.Location = new Point(1, 445);

            btnAtras.Location = new Point(1, 649);

            btnCerrarP.Location = new Point(1, 704);
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            btnVenta.Show();
            btnVenta.Location = new Point(1, 0);

            btnUsuarios.Show();
            btnUsuarios.Location = new Point(1, 89);

            btnProductos.Show();
            btnProductos.Location = new Point(1, 178);

            btnCat.Show();
            btnCat.Location = new Point(1, 267);

            btnReportes.Show();
            btnReportes.Location = new Point(1, 512);

            btnTeso.Location = new Point(1, 600);

            btnAtras.Location = new Point(1, 458);


            btnNuevCat.Show();
            btnEditCat.Show();
            btnElimCat.Show();
            btnAtras.Show();

            //botones de Venta
            btnVenN.Hide();
            btnNotaCre.Hide();
            btnGuiaDes.Hide();
            btnNotaDeb.Hide();

            //botones de Usuarios
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            //botones de Productos
            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            //botones de Reportes
            btnRepoF.Hide();
            btnRepoV.Hide();
            btnRepoComi.Hide();
            btnRepoMer.Hide();

            //botones de Tesorería
            btnApeCaja.Hide();
            btnReti.Hide();
            btnDepo.Hide();
            btnCierrC.Hide();
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

            txtFechaHora.BringToFront();

            btnVenta.Show();
            btnVenta.Location = new Point(1, 0);

            btnUsuarios.Show();
            btnUsuarios.Location = new Point(1, 89);

            btnProductos.Show();
            btnProductos.Location = new Point(1, 178);

            btnCat.Show();
            btnCat.Location = new Point(1, 267);

            btnReportes.Show();
            btnReportes.Location = new Point(1, 356);

            btnTeso.Show();
            btnTeso.Location = new Point(1, 445);
        }
        Categorias cat = new Categorias();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVenN_Click(object sender, EventArgs e)
        {
            V.TopLevel = false;
            V.Dock = DockStyle.Fill;
            V.Parent = panel2;
            V.Show();
            V.BringToFront();

            txtFechaHora.BringToFront();

            //botones de Venta
            btnVenN.Hide();
            btnNotaCre.Hide();
            btnGuiaDes.Hide();
            btnNotaDeb.Hide();

            btnVenta.Show();
            btnVenta.Location = new Point(1, 0);

            btnUsuarios.Show();
            btnUsuarios.Location = new Point(1, 89);

            btnProductos.Show();
            btnProductos.Location = new Point(1, 178);

            btnCat.Show();
            btnCat.Location = new Point(1, 267);

            btnReportes.Show();
            btnReportes.Location = new Point(1, 356);

            btnTeso.Show();
            btnTeso.Location = new Point(1, 445);
        }
        Ventas V = new Ventas();

        private void btnReportes_Click(object sender, EventArgs e)
        {
            btnVenta.Show();
            btnVenta.Location = new Point(1, 0);

            btnUsuarios.Show();
            btnUsuarios.Location = new Point(1, 89);

            btnProductos.Show();
            btnProductos.Location = new Point(1, 178);

            btnCat.Show();
            btnCat.Location = new Point(1, 267);

            btnReportes.Show();
            btnReportes.Location = new Point(1, 356);
            
            btnTeso.Show();
            btnTeso.Location = new Point(1, 616);

            btnAtras.Show();
            btnAtras.Location = new Point(1, 562);

            btnCerrarP.Location = new Point(1, 706);

            //botones de Venta
            btnVenN.Hide();
            btnNotaCre.Hide();
            btnGuiaDes.Hide();
            btnNotaDeb.Hide();

            //botones de Usuarios
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            //botones de Productos
            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            //botones de Categorías
            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            //botones de Reportes
            btnRepoF.Show();
            btnRepoV.Show();
            btnRepoComi.Show();
            btnRepoMer.Show();

            //botones de Tesorería
            btnApeCaja.Hide();
            btnReti.Hide();
            btnDepo.Hide();
            btnCierrC.Hide();
        }

        private void btnTeso_Click(object sender, EventArgs e)
        {
            btnVenta.Show();
            btnVenta.Location = new Point(1, 0);

            btnUsuarios.Show();
            btnUsuarios.Location = new Point(1, 89);

            btnProductos.Show();
            btnProductos.Location = new Point(1, 178);

            btnCat.Show();
            btnCat.Location = new Point(1, 267);

            btnReportes.Show();
            btnReportes.Location = new Point(1, 356);

            btnTeso.Show();
            btnTeso.Location = new Point(1, 445);

            btnAtras.Show();
            btnAtras.Location = new Point(1, 648);

            //botones de Venta
            btnVenN.Hide();
            btnNotaCre.Hide();
            btnGuiaDes.Hide();
            btnNotaDeb.Hide();

            //botones de Usuarios
            btnNuevoUs.Hide();
            btnEditUs.Hide();
            btnEliminarUs.Hide();

            //botones de Productos
            btnNuevoPro.Hide();
            btnEditPro.Hide();
            btnEliminarPro.Hide();

            //botones de Categorías
            btnNuevCat.Hide();
            btnEditCat.Hide();
            btnElimCat.Hide();

            //botones de Reportes
            btnRepoF.Hide();
            btnRepoV.Hide();
            btnRepoComi.Hide();
            btnRepoMer.Hide();

            //botones de Tesorería
            btnApeCaja.Show();
            btnReti.Show();
            btnDepo.Show();
            btnCierrC.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFechaHora.Text = DateTime.Now.ToString("U");
        }

        private void lbHora_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaHora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
