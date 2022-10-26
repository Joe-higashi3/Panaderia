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
    public partial class frmrol : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmrol()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
        }

        private void frmrolcs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSRol.ROL' Puede moverla o quitarla según sea necesario.
            this.rOLTableAdapter.Fill(this.dSRol.ROL);
            consecutivo();
        }

        private void GuardarRol()
        {
            clsrol rol = new clsrol();
            rol.iIdrol = Convert.ToInt32(txtid.Text);
            rol.stipo = txttipo.Text;

            if (rol.GuardarRol() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + rol.error);

            }
        }

        private void limpiar()
        {
            txttipo.Clear();
            consecutivo();
            this.rOLTableAdapter.Fill(this.dSRol.ROL);
            txttipo.Focus();
        }

        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(r_id),0) + 1 AS consecutivo FROM ROL";


            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarRol();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvrol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.dSRol.ROL[rOLBindingSource.Position].r_id.ToString();
            txttipo.Text = this.dSRol.ROL[rOLBindingSource.Position].r_tipo.ToString();
        }
    }
}
