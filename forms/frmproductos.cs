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
            producto.fPrecio99 = float.Parse(txtprecio.Text);
            producto.sNombre = txtnombre.Text;
            producto.sDescripcion = txtdescripcion.Text;
            producto.iId_categoria = Convert.ToInt32(cbxcategoria.SelectedValue);
            producto.sStatus = cmbxstatus.Text.Substring(0, 1);
            producto.iId_unidad = Convert.ToInt32(cbxunidad.SelectedValue);

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
            consecutivo();
            this.pRODUCTOTableAdapter1.Fill(this.panesitoDataSetcatag.PRODUCTO);

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
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSetcatag.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter.Fill(this.panesitoDataSetcatag.UNIDAD);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSetcatag.CATEGORIA' Puede moverla o quitarla según sea necesario.
            this.cATEGORIATableAdapter.Fill(this.panesitoDataSetcatag.CATEGORIA);
            txtprecio.Focus();
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSetcatag.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter1.Fill(this.panesitoDataSetcatag.PRODUCTO);
            consecutivo();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoDataSetcatag.PRODUCTO[pRODUCTOBindingSource4.Position].pr_id_producto.ToString();
            txtprecio.Text = this.panesitoDataSetcatag.PRODUCTO[pRODUCTOBindingSource4.Position].pr_precio.ToString();
            txtnombre.Text = this.panesitoDataSetcatag.PRODUCTO[pRODUCTOBindingSource4.Position].pr_nombre.ToString();
            txtdescripcion.Text = this.panesitoDataSetcatag.PRODUCTO[pRODUCTOBindingSource4.Position].pr_descripcion.ToString();
            cbxcategoria.SelectedValue = this.panesitoDataSetcatag.PRODUCTO[pRODUCTOBindingSource4.Position].pr_id_categoria;

            cbxunidad.SelectedValue = this.panesitoDataSetcatag.PRODUCTO[pRODUCTOBindingSource4.Position].pr_id_unidad;

            string sSTATUS;
            sSTATUS = this.panesitoDataSetcatag.PRODUCTO[pRODUCTOBindingSource4.Position].pr_status.ToString();
            switch (sSTATUS)
            {
                case "A":
                    cmbxstatus.Text = "Activo";
                break;
                case "C":
                    cmbxstatus.Text = "Cancelado";
                break;
                default:
                    cmbxstatus.Text = "Activo";
                break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
