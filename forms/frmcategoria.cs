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
using WindowsFormsApp2.clases;

namespace WindowsFormsApp2.forms
{
    public partial class frmcategoria : Form

    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;

        public frmcategoria()
        {
            InitializeComponent();
        }

        private void frmcategoria_Load(object sender, EventArgs e)
        {
            txtdescripcion.Focus();
        }

        private void GuardarCategoria()
        {
            clscategoria categoria = new clscategoria();
            categoria.iId_categoria = Convert.ToInt32(txtid.Text);
            categoria.sDescripcion = txtdescripcion.Text;

            if (categoria.GuardarCategoria() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + categoria.error);

            }

        }

        private void limpiar()
        {
            txtid.Clear();
            txtdescripcion.Clear();
        }

        private void dgvcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }
    }
}
