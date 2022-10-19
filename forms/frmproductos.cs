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
    public partial class frmproductos : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmproductos()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }


        private void GuardarProducto()
        {
            clsproducto producto = new clsproducto();
            producto.iId_producto = Convert.ToInt32(txtid.Text);
            producto.fPrecio99 = Convert.ToInt32(txtprecio.Text);
            producto.sNombre = txtnombre.Text;
            producto.sDescripcion = txtdescripcion.Text;
            producto.iId_categoria = Convert.ToInt32(txtid.Text);
            if (producto.GuardarProducto() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + producto.error);

            }

        }

        private void limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            txtdescripcion.Clear();
            txtcategoria.Clear();
            consecutivo();
        }

        private void consecutivo()
        {
            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(pr_id_producto),0) + 1 AS consecutivo FROM PRODUCTO";

            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }
        }

        private void frmproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetproducto.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.dataSetproducto.PRODUCTO);
            txtprecio.Focus();
            consecutivo();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = 
            txtprecio.Text = 
            txtdescripcion.Text = 
            txtcategoria.Text = 
        }
    }
}
