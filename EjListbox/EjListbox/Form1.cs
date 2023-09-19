using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjListbox
{
    public partial class Form1 : Form
    {
        List<string> listaNombres = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = txt_Nombres.Text;
            listaNombres.Add(nombre);

            listNombres.DataSource = null;
            txt_Nombres.Text = "";
            listNombres.DataSource = listaNombres;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            listaNombres.Remove(txt_Nombres.Text);

            listNombres.DataSource = null;
            txt_Nombres.Text = "";
            listNombres.DataSource = listaNombres;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            var indice = listaNombres.IndexOf(txt_NombreCambiar.Text);
            listaNombres.RemoveAt(indice);
            listaNombres.Insert(indice, txt_Nombres.Text);
            
            listNombres.DataSource = null;
            txt_Nombres.Text = "";
            listNombres.DataSource = listaNombres;
        }
    }
}
