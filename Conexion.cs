using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ventas_ERG
{
    internal class Conexion
    {
        public static MySqlConnection obtConexion()//metodo para la apertura de la conexión con MySql
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string bd = "ventas_erg";

            string CadenaConexion = "server=" + servidor + "; user=" + usuario + "; password=" + password + "; database=" + bd + ";";

            MySqlConnection conectar = new MySqlConnection(CadenaConexion);
            conectar.Open();
            return conectar;
        }

        public static MySqlConnection cerrarConexion()//Metodo para el cierre de la conexión con MySql
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string bd = "ventas_erg";

            string CadenaConexion = "server=" + servidor + "; user=" + usuario + "; password=" + password + "; database=" + bd + ";";

            MySqlConnection cerrar = new MySqlConnection(CadenaConexion);
            cerrar.Close();
            return cerrar;
        }

        //metodo para generar diversas consultas select
        public static string selectSql(string Columnas, string Tabla, string Condicion)
        {
            string sql = "SELECT " + Columnas + " FROM " + Tabla + " WHERE " + Condicion + ";";
            return sql;
        }

        public static string selectSql2(string Columnas, string Tabla)
        {
            string sql = "SELECT " + Columnas + " FROM " + Tabla + ";";
            return sql;

        }

        //metodo para insertar datos en las tablas de la base de datos
        public static string insertSql(string Tabla, string Val0, string Val1, string Val2,
                                       string Val3, string Val4, string Val5, string Val6, string Val7,string Val8)
        {
            string sql = "INSERT INTO "+Tabla+" ("+Val0+") VALUES ('" +Val1+ "','" + Val2+ "','" + Val3 + "','"+ Val4 + "','"+ Val5 + "','"+ Val6 + "','"+ Val7 + "','"+ Val8 + "');";
            return sql;
        }
    }
}
