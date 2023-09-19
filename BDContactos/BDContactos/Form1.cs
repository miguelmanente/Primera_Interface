using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BDContactos
{
    public partial class Form1 : Form
    {
        static string conexionstring = "server=PC02; database=Agenda;integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La conexión a la BD: " + conexion.Database + " se ha realizado correctamente");
        }

        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("La base de datos ha sido desconectada");
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            if (TxtConsulta.Text == "")
            {
                string query = "Select * from Contactos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DgvDatos.DataSource = tabla;
            }
            else 
            {
                string query = "Select * from Contactos where pApellidos='"+TxtConsulta.Text+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                DgvDatos.DataSource = tabla;
            }
        }
    }
}
