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
    public partial class CreacionPro : Form
    {
        public CreacionPro()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que decea cerrar la ventana Producto?", "Precaución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Hide();
                txtNomPro.Text = "";
                cbCat.ResetText();
                cbUniMed.ResetText();
                txtStock.ResetText();
                txtPrecio.ResetText();
                txtIVA.ResetText();
                txtPreIVA.ResetText();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string col1 = "COUNT(*)";
            string tab1 = "CATEGORIAS";

            string sql1 = Conexion.selectSql2(col1, tab1);
            Conexion.obtConexion();
            MySqlCommand cmd1 = new MySqlCommand(sql1, Conexion.obtConexion());
            int resul = Convert.ToInt32(cmd1.ExecuteScalar());
            Conexion.cerrarConexion();


            if (resul != 0)
            {

                string tab = "PRODUCTOS";
                string v1 = "COD_PRO, NOM_PRO, CAT, U_MED, STOCK_PRO, PRECIO, IVA_PRO, PRE_CON_IVA_PRO";

                string val1 = (txtCodPro.Text);
                string val2 = (txtNomPro.Text);
                string val5 = (txtStock.Text);
                string val6 = (txtPrecio.Text);
                string val7 = (txtIVA.Text);
                string val8 = (txtPreIVA.Text);

                string cb = (cbCat.Text);
                string tab2 = "CATEGORIAS";
                string col = "ID_CAT";
                string con = "NOM_CAT = " + "'" + cb + "'";
                string idc = "";

                string cb2 = (cbUniMed.Text);
                string tab3 = "UNIDAD_MEDIDA";
                string col2 = "ID_UNI_MED";
                string con2 = "NOM_UNI_MED = " + "'" + cb2 + "'";
                string idu = "";

                if (txtNomPro.Text != "" && cbCat.Text != "" && cbUniMed.Text != "" &&
                   txtStock.Text != "" && txtPrecio.Text != "" && txtIVA.Text != "" &&
                   txtPreIVA.Text != "")
                {
                    try
                    {
                        MySqlDataReader reader = null;
                        string sql2 = Conexion.selectSql(col, tab2, con);
                        MySqlCommand cmd2 = new MySqlCommand(sql2, Conexion.obtConexion());
                        reader = cmd2.ExecuteReader();

                        while (reader.Read())
                        {
                            idc = reader.GetString(0);
                        }

                        MySqlDataReader reader2 = null;
                        string sql3 = Conexion.selectSql(col2,tab3,con2);
                        MySqlCommand cmd3 = new MySqlCommand(sql3, Conexion.obtConexion());
                        reader2 = cmd3.ExecuteReader();

                        while (reader2.Read())
                        {
                            idu = reader2.GetString(0);
                        }

                        Conexion.cerrarConexion();


                        string sql = Conexion.insertSql(tab, v1, val1, val2, idc, idu, val5, val6, val7, val8);
                        MySqlCommand cmd = new MySqlCommand(sql, Conexion.obtConexion());
                        Conexion.obtConexion();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto registrado de manera exitosa!!!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Conexion.cerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos antes de continuar", "Precaución",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Antes de Ingresar Productos, debe crear las categorías", "Precaución",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtCodPro.Text = "";
            txtNomPro.Text = "";
            cbCat.ResetText();
            cbUniMed.ResetText();
            txtStock.Text = "";
            txtPrecio.Text = "";
            txtIVA.Text = "";
            txtPreIVA.Text = "";

            Hide();
        }

        private void txtCodPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = false;
            }
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
            }
        }

        private void cbUniMed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodPro_TextChanged(object sender, EventArgs e)
        {

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



        private void CreacionPro_Load(object sender, EventArgs e)
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
    }
}
