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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            txtNomCat.Text = "";
        }

        private void btnAgreCat_Click(object sender, EventArgs e)
        {
            string nom = "";
            nom = txtNomCat.Text;

            string colum = "COUNT(*)";
            string tabla = "CATEGORIAS";
            string condi = "NOM_CAT = " + "'" + nom + "'";
            string val = "NOM_CAT";


            try
            {
                if (txtNomCat.Text != "")
                {
                    string sql = Conexion.selectSql(colum, tabla, condi);
                    Conexion.obtConexion();
                    MySqlCommand cmd = new MySqlCommand(sql, Conexion.obtConexion());
                    int resul = Convert.ToInt32(cmd.ExecuteScalar());
                    Conexion.cerrarConexion();

                    if(resul == 0)
                    {
                        try
                        {
                            string sql1 = Conexion.inser2tSql(tabla,val,nom);
                            MySqlCommand cmd2 = new MySqlCommand(sql1, Conexion.obtConexion());
                            Conexion.obtConexion();
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Categoría creada de manera exitosa!!!", "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Conexion.cerrarConexion();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, la categoria ya existe!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar el campo de nombre para continuar!!!|");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtNomCat.Text = "";
            Hide();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            
        }
    }
}
