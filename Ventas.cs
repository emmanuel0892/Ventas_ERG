using MySql.Data.MySqlClient;
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
    public partial class Ventas : Form
    {

        public Ventas()
        {
            InitializeComponent();

            lbVendedor.Hide();
            txtNomVendedor.Hide();
            lbProducto.Hide();
            txtProducto.Hide();
            lbTipo.Hide();
            txtTipoP.Hide();
            lbCantidad.Hide();
            txtCantidadP.Hide();
            lbUmedida.Hide();
            txtUmedida.Hide();
            lbStock.Hide();
            txtStock.Hide();
            btnAgregarP.Hide();
            tabla1.Hide();
            txtDescuento.Hide();
            lbPorcentaje.Hide();
            lbDescuento.Hide();
            txtDescuentoT.Hide();
            lbTotal.Hide();
            txtTotal.Hide();
            button1.Hide();
            btnGuardarV.Hide();
            btnRecuperarV.Hide();
            btnEliminarP.Hide();
            btnEditarP.Hide();
            btnPagar.Hide();
            btnBuscar.Hide();
            lbCodProducto.Hide();
            txtCodigoP.Hide();
            bnt1.Hide();
            btn2.Hide();
            btn3.Hide();
            btn4.Hide();
            btn5.Hide();
            btn6.Hide();
            btn7.Hide();
            btn8.Hide();
            btn9.Hide();
            btn0.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validamos con un MessageBox que tras presionar cancelar, nos pregunte si en verdad o no deceamos salir
            if (MessageBox.Show("Esta seguro que decea cacelar la compra?", "Precaución",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Hide();
                txtCodigoV.Clear();
                txtProducto.Clear();
                txtTipoP.Clear();
                txtCantidadP.Clear();
                txtUmedida.Clear();
                txtStock.Clear();
                txtDescuento.Clear();
                txtDescuentoT.Clear();
                txtTotal.Clear();
                txtCodigoP.Clear();

                lbVendedor.Hide();
                txtNomVendedor.Hide();
                lbProducto.Hide();
                txtProducto.Hide();
                lbTipo.Hide();
                txtTipoP.Hide();
                lbCantidad.Hide();
                txtCantidadP.Hide();
                lbUmedida.Hide();
                txtUmedida.Hide();
                lbStock.Hide();
                txtStock.Hide();
                btnAgregarP.Hide();
                tabla1.Hide();
                txtDescuento.Hide();
                lbPorcentaje.Hide();
                lbDescuento.Hide();
                txtDescuentoT.Hide();
                lbTotal.Hide();
                txtTotal.Hide();
                button1.Hide();
                btnGuardarV.Hide();
                btnRecuperarV.Hide();
                btnEliminarP.Hide();
                btnEditarP.Hide();
                btnPagar.Hide();
                btnBuscar.Hide();
                lbCodProducto.Hide();
                txtCodigoP.Hide();
                bnt1.Hide();
                btn2.Hide();
                btn3.Hide();
                btn4.Hide();
                btn5.Hide();
                btn6.Hide();
                btn7.Hide();
                btn8.Hide();
                btn9.Hide();
                btn0.Hide();

                txtCodigoV.Enabled = true;
                btnBuscarVendedor.Visible = true;
            }
        }

        private void btnGuardarV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Se procederá a gruardar el proceso de compra para su posterior uso", "Guardar Compra", MessageBoxButtons.OK);
            txtCodigoV.Clear();
            txtProducto.Clear();
            txtTipoP.Clear();
            txtCantidadP.Clear();
            txtUmedida.Clear();
            txtStock.Clear();
            txtDescuento.Clear();
            txtDescuentoT.Clear();
            txtTotal.Clear();
            txtCodigoP.Clear();
            txtCodigoV.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Creacion de variables para guardar los datos de la consulta sql
            string codP = (txtCodigoP.Text);
            string Columna    = "*";
            string Tabla      = "PRODUCTOS";
            string Condicion = "id_pro = " + codP;
            string var = "";

            if (txtCodigoP.Text != "")
            {
                //Llamamos a la clase conexión para generar la consulta y le damos los parametros (columna,tabla y condicion)
                //declarados anteriormente
                string sql = Conexion.selectSql(Columna,Tabla,Condicion);
                Conexion.obtConexion();

                try
                {
                    //Creamos una variable de tipo MySql para guardar los datos que nos devuelve la consulta
                    MySqlDataReader reader = null;

                    MySqlCommand cmd = new MySqlCommand(sql, Conexion.obtConexion());
                    reader = cmd.ExecuteReader();

                    //Validamo que la variable retorne información
                    if (reader == null)
                    {
                        MessageBox.Show("Error, el producto no existe!");
                        txtCodigoP.Focus();
                    }
                    else
                    {
                        //Recorremos la variable y la le asignamos a los textbox la información que requerimos
                        while (reader.Read())
                        {
                            txtProducto.Text = reader.GetString(2);
                            var = reader.GetString(3);
                        }

                        string columna = "NOM_CAT";
                        string tabla = "CATEGORIAS";
                        string condicion = "ID_CAT = " + "'"+var+"'";

                        string sql2 = Conexion.selectSql(columna, tabla, condicion);
                        MySqlDataReader read = null;
                        MySqlCommand comando = new MySqlCommand(sql2, Conexion.obtConexion());
                        read = comando.ExecuteReader();
                        while (read.Read())
                        {
                            txtTipoP.Text = read.GetString(0);
                        }
                        Conexion.cerrarConexion();

                        //SELECT CATEGORIAS.NOM_CAT FROM PRODUCTOS INNER JOIN CATEGORIAS ON PRODUCTOS.CAT = CATEGORIAS.ID_CAT WHERE CATEGORIAS.ID_CAT = '1';
                    }

                }
                //realizamos un control de excepción para MySql
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe llenar el campo Codigo de Producto para continuar!!!");
            }
            txtCodigoP.Clear();
            txtCodigoP.Focus();
        }

        private void txtCodigoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validamos que no se pueda teclear la barra espaceadora en este textbox
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                e.Handled = char.IsWhiteSpace(e.KeyChar);
            }
            else
            //Validamos que no se puedan ingresar caracteres y solo números en este textbox
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                //validamos para que nos permita realizar la acción de enter en este textbox con la tecla intro de nuestro teclado
            if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    btnBuscar_Click(sender, e);
                }
            }
        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "1";
            txtCodigoP.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "2";
            txtCodigoP.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "3";
            txtCodigoP.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "4";
            txtCodigoP.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "5";
            txtCodigoP.Focus();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "6";
            txtCodigoP.Focus();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "7";
            txtCodigoP.Focus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "8";
            txtCodigoP.Focus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "9";
            txtCodigoP.Focus();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = txtCodigoP.Text + "0";
            txtCodigoP.Focus();
        }

        private void txtCodigoV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                e.Handled = char.IsWhiteSpace(e.KeyChar);
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    btnBuscarVendedor_Click(sender, e);
                }
            }
        }

        private void txtCodigoV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            btncancelar2.Hide();
            btnBuscarVendedor.Hide();
            txtCodigoV.Enabled = false;
            lbVendedor.Visible = true;
            txtNomVendedor.Visible = true;
            lbProducto.Visible = true;
            txtProducto.Visible = true;
            lbTipo.Visible = true;
            txtTipoP.Visible = true;
            lbCantidad.Visible = true;
            txtCantidadP.Visible = true;
            lbUmedida.Visible = true;
            txtUmedida.Visible = true;
            lbStock.Visible = true;
            txtStock.Visible = true;
            btnAgregarP.Visible = true;
            tabla1.Visible = true;
            txtDescuento.Visible = true;
            lbPorcentaje.Visible = true;
            lbDescuento.Visible = true;
            txtDescuentoT.Visible = true;
            lbTotal.Visible = true;
            txtTotal.Visible = true;
            button1.Visible = true;
            btnGuardarV.Visible = true;
            btnRecuperarV.Visible = true;
            btnEliminarP.Visible = true;
            btnEditarP.Visible = true;
            btnPagar.Visible = true;
            btnBuscar.Visible = true;
            lbCodProducto.Visible = true;
            txtCodigoP.Visible = true;
            bnt1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;
            btn0.Visible = true;

            txtCodigoP.Focus();
        }

        private void txtCodigoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtCodigoP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Creacion de variables para guardar los datos de la consulta sql
                string codP = (txtCodigoP.Text);
                string Columna = "*";
                string Tabla = "PRODUCTOS";
                string Condicion = "COD_PRO = " + codP;
                string var = "";

                //Llamamos a la clase conexión para generar la consulta y le damos los parametros (columna,tabla y condicion)
                //declarados anteriormente
                string sql = Conexion.selectSql(Columna, Tabla, Condicion);
                Conexion.obtConexion();

                try
                {
                    //Creamos una variable de tipo MySql para guardar los datos que nos devuelve la consulta
                    MySqlDataReader reader = null;

                    MySqlCommand cmd = new MySqlCommand(sql, Conexion.obtConexion());
                    reader = cmd.ExecuteReader();
                    Conexion.cerrarConexion();

                    //Validamo que la variable retorne información
                    if (reader == null)
                    {
                        MessageBox.Show("Error, el producto no existe!");
                        txtCodigoP.Focus();
                    }
                    else
                    {
                        //Recorremos la variable y la le asignamos a los textbox la información que requerimos
                        while (reader.Read())
                        {
                            txtProducto.Text = reader.GetString(2);
                            var = reader.GetString(3);
                        }

                        string columna = "NOM_CAT";
                        string tabla = "CATEGORIAS";
                        string condicion = "ID_CAT = " + var;

                        string sql2 = Conexion.selectSql(columna, tabla, condicion);
                        MySqlDataReader read = null;
                        MySqlCommand comando = new MySqlCommand(sql2,Conexion.obtConexion());
                        read = comando.ExecuteReader();
                        while (read.Read())
                        {
                            txtTipoP.Text = read.GetString(0);
                        }
                        Conexion.cerrarConexion();
                    }

                }
                //realizamos un control de excepción para MySql
                catch (Exception)
                {
                    MessageBox.Show("El producto no existe!!!");
                }
            }
        
        }
    }
}
