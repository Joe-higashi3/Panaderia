using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.clases;

namespace WindowsFormsApp2.forms
{
    public partial class frmunidad : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;

        public frmunidad()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
            uNIDADTableAdapter.Connection.ConnectionString = sConexion;
        }

        private void frmunidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsUnidadp.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter.Fill(this.dsUnidadp.UNIDAD);

            consecutivo();

        }

        private void GuardarUnidad()
        {
            clsunidad unidad = new clsunidad();
            unidad.iIdUnidad = Convert.ToInt32(txtidunidad.Text);
            unidad.sDescripcion = txtdescunidad.Text;
     
            if (unidad.GuardarUnidad() == true)
            {
                MessageBox.Show("Los datos se han guardado correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("ERROR: Los datos no se pudieron guardar: " + unidad.error);

            }
        }
        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(un_id_unidad),0) + 1 AS consecutivo FROM UNIDAD";


            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtidunidad.Text = Convert.ToString(l.GetInt32(0));
            }


        }

        private void limpiar()
        {
            txtdescunidad.Clear();
            consecutivo();
            this.uNIDADTableAdapter.Fill(this.dsUnidadp.UNIDAD);
            txtdescunidad.Focus();
        }


        private void dgvunidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidunidad.Text = this.dsUnidadp.UNIDAD[uNIDADBindingSource.Position].un_id_unidad.ToString();
            txtdescunidad.Text = this.dsUnidadp.UNIDAD[uNIDADBindingSource.Position].un_descripcion.ToString();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarUnidad();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
