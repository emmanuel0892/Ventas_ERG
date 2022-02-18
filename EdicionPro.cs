using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ventas_ERG
{
    public partial class EdicionPro : Form
    {
        public EdicionPro()
        {
            InitializeComponent();

            txtCodigoP.Focus();

            lbCodigoPro1.Hide();
            txtCodPro.Hide();
            lbNomPro.Hide();
            txtNomPro.Hide();
            lbCat.Hide();
            cbCat.Hide();
            lbUniMed.Hide();
            cbUniMed.Hide();
            lbStock.Hide();
            txtStock.Hide();
            lbPrecio.Hide();
            lbSignoPeso1.Hide();
            txtPrecio.Hide();
            lbIVA.Hide();
            lbSignoPeso2.Hide();
            txtIVA.Hide();
            lbPreIVA.Hide();
            lbSignoPeso3.Hide();
            txtPreIVA.Hide();
            btnActualizarPro.Hide();
            btnAgreCat.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bntActualizarPro_Click(object sender, EventArgs e)
        {
            if (txtNomPro.Text != "" && cbCat.Text != "" && cbUniMed.Text != "" &&
                   txtStock.Text != "" && txtPrecio.Text != "" && txtIVA.Text != "" &&
                   txtPreIVA.Text != "")
            {

                try
                {
                    string columna = "ID_CAT";
                    string tabla = "CATEGORIAS";
                    string condicion = "NOM_CAT = '" + cbCat.Text + "'";
                    int var1 = 0;

                    string columna2 = "ID_UNI_MED";
                    string tabla2 = "UNIDAD_MEDIDA";
                    string condicion2 = "NOM_UNI_MED = '" + cbUniMed.Text + "'";
                    int var2 = 0;

                    string sql3 = Conexion.selectSql(columna2, tabla2, condicion2);
                    MySqlDataReader read2 = null;
                    MySqlCommand comando2 = new MySqlCommand(sql3, Conexion.obtConexion());
                    read2 = comando2.ExecuteReader();
                    while (read2.Read())
                    {
                        var1 = Convert.ToInt32(read2.GetString(0));
                    }

                    string sql2 = Conexion.selectSql(columna, tabla, condicion);
                    MySqlDataReader read = null;
                    MySqlCommand comando = new MySqlCommand(sql2, Conexion.obtConexion());
                    read = comando.ExecuteReader();
                    while (read.Read())
                    {
                        var2 = Convert.ToInt32(read.GetString(0));
                    }
                    Conexion.cerrarConexion();


                    string tabla1 = "PRODUCTOS";
                    string valores = "COD_PRO = " + txtCodPro.Text +
                                     ", NOM_PRO = '" + txtNomPro.Text + "'" + 
                                     ", CAT = " + var1 +
                                     ", U_MED = " + var2 +
                                     ", STOCK_PRO = " + txtStock.Text +
                                     ", PRECIO = " + txtPrecio.Text +
                                     ", IVA_PRO = " + txtIVA.Text +
                                     ", PRE_CON_IVA_PRO = " + txtPreIVA.Text +
                                     " WHERE ID_PRO = " + txtID.Text;

                        string sql = Conexion.updateSql(tabla1, valores);
                        MySqlCommand cmd = new MySqlCommand(sql, Conexion.obtConexion());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("El producto fue actualizado de manera exitosa!!", "Procedimiento Exitoso");
                    }catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos antes de continuar!!!","Precaución");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que decea cacelar la edicion?", "Precaución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Hide();
                txtCodPro.Text = "";
                txtNomPro.Text = "";
                cbCat.ResetText();
                cbUniMed.ResetText();
                txtStock.ResetText();
                txtPrecio.ResetText();
                txtIVA.ResetText();
                txtPreIVA.ResetText();

                lbCodigoPro1.Hide();
                txtCodPro.Hide();
                lbNomPro.Hide();
                txtNomPro.Hide();
                lbCat.Hide();
                cbCat.Hide();
                lbUniMed.Hide();
                cbUniMed.Hide();
                lbStock.Hide();
                txtStock.Hide();
                lbPrecio.Hide();
                lbSignoPeso1.Hide();
                txtPrecio.Hide();
                lbIVA.Hide();
                lbSignoPeso2.Hide();
                txtIVA.Hide();
                lbPreIVA.Hide();
                lbSignoPeso3.Hide();
                txtPreIVA.Hide();
                btnActualizarPro.Hide();
                btnAgreCat.Hide();


                lbCodProducto.Show();
                txtCodigoP.Show();
                btnBuscar.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if(txtCodigoP.Text != ""){
                try
                {
                    string id        = txtID.Text;
                    string cod       = txtCodigoP.Text;
                    string col       = "COUNT(COD_PRO)";
                    string col2      = "*";
                    string tab       = "PRODUCTOS";
                    string con       = "COD_PRO = '" + cod + "'";
                    string codigo    = "";
                    string nombre    = "";
                    string categoria = "";
                    string unidadM   = "";
                    string stock     = "";
                    string precio    = "";
                    string iva       = "";
                    string precioF   = "";
                    int    res       = 0;

                    string slq = Conexion.selectSql(col2,tab,con);
                    MySqlCommand cmd = new MySqlCommand(slq, Conexion.obtConexion());
                    res = Convert.ToInt32(cmd.ExecuteScalar());      

                    if(res != 0)
                    {
                        lbCodProducto.Hide();
                        txtCodigoP.Hide();
                        btnBuscar.Hide();

                        lbCodigoPro1.Show();
                        txtCodPro.Show();
                        lbNomPro.Show();
                        txtNomPro.Show();
                        lbCat.Show();
                        cbCat.Show();
                        lbUniMed.Show();
                        cbUniMed.Show();
                        lbStock.Show();
                        txtStock.Show();
                        lbPrecio.Show();
                        txtPrecio.Show();
                        lbSignoPeso1.Show();
                        lbIVA.Show();
                        lbSignoPeso2.Show();
                        txtIVA.Show();
                        lbPreIVA.Show();
                        lbSignoPeso3.Show();
                        txtPreIVA.Show();
                        btnActualizarPro.Show();
                        btnAgreCat.Show();

                        Conexion.obtConexion();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            id        = reader.GetString(0);
                            codigo    = reader.GetString(1);
                            nombre    = reader.GetString(2);
                            categoria = reader.GetString(3);
                            unidadM   = reader.GetString(4);
                            stock     = reader.GetString(5);
                            precio    = reader.GetString(6);
                            iva       = reader.GetString(7);
                            precioF   = reader.GetString(8);
                        }

                        string columna = "NOM_CAT";
                        string tabla = "CATEGORIAS";
                        string condicion = "ID_CAT = " + categoria;

                        string columna2 = "NOM_UNI_MED";
                        string tabla2 = "UNIDAD_MEDIDA";
                        string condicion2 = "ID_UNI_MED = " + unidadM;

                        string sql3 = Conexion.selectSql(columna2, tabla2, condicion2);
                        MySqlDataReader read2 = null;
                        MySqlCommand comando2 = new MySqlCommand(sql3, Conexion.obtConexion());
                        read2 = comando2.ExecuteReader();
                        while (read2.Read())
                        {
                            cbUniMed.Text = read2.GetString(0);
                        }

                        string sql2 = Conexion.selectSql(columna, tabla, condicion);
                        MySqlDataReader read = null;
                        MySqlCommand comando = new MySqlCommand(sql2, Conexion.obtConexion());
                        read = comando.ExecuteReader();
                        while (read.Read())
                        {
                            cbCat.Text = read.GetString(0);
                        }
                        Conexion.cerrarConexion();

                        txtID.Text = id;
                        txtCodPro.Text = codigo;
                        txtNomPro.Text = nombre;
                        txtStock.Text = stock;
                        txtPrecio.Text = precio;
                        txtIVA.Text = iva;
                        txtPreIVA.Text = precioF;

                    }
                    else
                    {
                        MessageBox.Show("El Producto no existe en nuestra base de datos, pruebe con un producto registrado!!!", "Precaución");
                        txtCodigoP.Text = "";
                        txtCodigoP.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Antes de continuar debe ingresar el codigo de un producto!!!", "Precaución");
            }

            txtCodigoP.Text = "";
            
        }

        private void EdicionPro_Load(object sender, EventArgs e)
        {
            string col = "NOM_CAT";
            string tab = "CATEGORIAS";

            string col2 = "NOM_UNI_MED";
            string tab2 = "UNIDAD_MEDIDA";

            string sql = Conexion.selectSql2(col, tab);
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.obtConexion());
            Conexion.obtConexion();
            MySqlDataReader reader = cmd.ExecuteReader();

            string sql2 = Conexion.selectSql2(col2, tab2);
            MySqlCommand cmd2 = new MySqlCommand(sql2, Conexion.obtConexion());
            Conexion.obtConexion();
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader.Read())
            {
                cbCat.Items.Add(reader[col].ToString());
            }

            while (reader2.Read())
            {
                cbUniMed.Items.Add(reader2[col2].ToString());
            }

            Conexion.cerrarConexion();
        }

        public void recargar_cb()
        {
            string col = "NOM_CAT";
            string tab = "CATEGORIAS";

            string sql = Conexion.selectSql2(col, tab);
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.obtConexion());
            Conexion.obtConexion();
            MySqlDataReader reader = cmd.ExecuteReader();

            cbCat.Items.Clear();

            while (reader.Read())
            {
                cbCat.Items.Add(reader[col].ToString());
            }

            Conexion.cerrarConexion();
        }

        private void btnAgreCat_Click(object sender, EventArgs e)
        {
            cat.TopLevel = true;
            cat.ShowDialog();
            cat.BringToFront();
            cat.TopMost = true;
            recargar_cb();
        }
        Categorias cat = new Categorias();

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
    }
}
