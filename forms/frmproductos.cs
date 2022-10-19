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
            producto.iId_categoria = Convert.ToInt32(txtcategoria.Text);
            producto.sStatus = cmbxstatus.Text.Substring(0, 1);
            producto.iId_unidad = Convert.ToInt32(txtunidad.Text);

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
            //agregar lo de status aqui
            txtunidad.Clear();
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
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSetproductomod1.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter1.Fill(this.panesitoDataSetproductomod1.PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetproducto.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.dataSetproducto.PRODUCTO);
            txtnombre.Focus();
            consecutivo();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.dataSetproducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_id_producto.ToString();
            txtprecio.Text = this.dataSetproducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_precio.ToString();
            txtnombre.Text = this.dataSetproducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_nombre.ToString();
            txtdescripcion.Text = this.dataSetproducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_descripcion.ToString();
            txtcategoria.Text = this.dataSetproducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_id_categoria.ToString();
            //agregar lo de estatus aqui
            //agregar lo de unidad aqui
            //txtunidad.Text = this.dataSetproducto.PRODUCTO[pRODUCTOBindingSource.Position].pr_unidad.ToString();
        }
    }
}
