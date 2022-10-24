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
    public partial class frmempleados : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmempleados()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
            rOLTableAdapter.Connection.ConnectionString = sConexion;
            eMPLEADOTableAdapter.Connection.ConnectionString = sConexion;
            mUNICIPIOTableAdapter.Connection.ConnectionString = sConexion;
        }

        private void frmempleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSRolEdi.ROL' Puede moverla o quitarla según sea necesario.
            this.rOLTableAdapter.Fill(this.dSRolEdi.ROL);
            // TODO: esta línea de código carga datos en la tabla 'dSEmpleadoEdi.EMPLEADO' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOTableAdapter.Fill(this.dSEmpleadoEdi.EMPLEADO);
            // TODO: esta línea de código carga datos en la tabla 'dSMunicipioEdi.MUNICIPIO' Puede moverla o quitarla según sea necesario.
            this.mUNICIPIOTableAdapter.Fill(this.dSMunicipioEdi.MUNICIPIO);


            txttelefono.Focus();
            consecutivo();
        }

        private void GuardarEmpleado()
        {
            clsempleado empleado = new clsempleado();
            byte[] bytes = Encoding.ASCII.GetBytes(txtcontraseña.Text);
            empleado.iIdempleado = Convert.ToInt32(txtid.Text);
            empleado.sUsuario = txtusuario.Text;
            empleado.sContraseña = bytes;
            empleado.sApellido_p = txtapaterno.Text;
            empleado.sApellido_m = txtamaterno.Text;
            empleado.sColonia = txtcolonia.Text;
            empleado.sTelefono = txttelefono.Text;
            empleado.iNum_int = Convert.ToInt32(txtinterior.Text);
            empleado.iNum_ext = Convert.ToInt32(txtexterior.Text);
            empleado.sCalle = txtcalle.Text;
            empleado.iId_municipio = Convert.ToInt32(cmbmunicipio.SelectedValue);
            empleado.iId_rol = Convert.ToInt32(cmbrol.SelectedValue);
            empleado.sStatus = cmbstatus.Text.Substring(0, 1);
            
            if (empleado.GuardarEmpleado() == true)
            {
                MessageBox.Show("Sus Datos se guardaron correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("Sus Datos no se pudieron guardar error: " + empleado.error);

            }
        }
        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(em_id_empleado),0) + 1 AS consecutivo FROM EMPLEADO";
            

            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }


        }
        private void limpiar()
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
            txtamaterno.Clear();
            txtapaterno.Clear();
            txtcolonia.Clear();
            txttelefono.Clear();
            txtcalle.Clear();
            txtinterior.Clear();
            txtexterior.Clear();
            txtvcontraseña.Clear();
            consecutivo();
            this.eMPLEADOTableAdapter.Fill(this.dSEmpleadoEdi.EMPLEADO);
            txttelefono.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtcontraseña.Text == txtvcontraseña.Text)
            {
                GuardarEmpleado();
            }
            else
            {
                MessageBox.Show("Las contrasenas no coinciden");
                txtcontraseña.Clear();
                txtvcontraseña.Clear();
                txtcontraseña.Focus();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_id_empleado.ToString();
            txtusuario.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_usuario.ToString();
            txtcontraseña.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_contraseña.ToString();
            txtamaterno.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_apellido_paterno.ToString();
            txtapaterno.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_apellido_materno.ToString();
            txttelefono.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_telefono.ToString();
            txtcolonia.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_colonia.ToString();
            txtinterior.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_num_interior.ToString();
            txtexterior.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_num_exterior.ToString();
            txtcalle.Text = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_calle.ToString();
            cmbmunicipio.SelectedValue = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_id_municipio;
            string sSTATUS;
            sSTATUS = this.dSEmpleadoEdi.EMPLEADO[eMPLEADOBindingSource.Position].em_status.ToString();
            switch (sSTATUS)
            {
                case "A":
                    cmbstatus.Text = "Activo";
                    break;
                case "C":
                    cmbstatus.Text = "Cancelado";
                    break;
                default:
                    cmbstatus.Text = "Activo";
                    break;
            }
        }
    }
}
