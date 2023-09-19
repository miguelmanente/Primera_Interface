using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using prueba.mysql;
using MySql.Data.MySqlClient;

namespace prueba.mysql
{
    class conexion
    {
        public static MySqlConnection obtenerconexion() 
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=csharp;Uid=root;pwd=;");
            conexion.Open();
            return conexion;
        }
    }
}
