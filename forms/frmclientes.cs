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
    public partial class frmclientes : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frmclientes()
        {
            InitializeComponent();
            sConexion = Conexion.conn();

        }
        private void frmclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMunicipio.MUNICIPIO' Puede moverla o quitarla según sea necesario.
            this.mUNICIPIOTableAdapter.Fill(this.dsMunicipio.MUNICIPIO);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet2.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter2.Fill(this.panesitoDataSet2.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet1.CLIENTE' Puede moverla o quitarla según sea necesario.
            //this.cLIENTETableAdapter1.Fill(this.panesitoDataSet1.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'panesitoDataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            //this.cLIENTETableAdapter.Fill(this.panesitoDataSet.CLIENTE);
            txttelefono.Focus();
            consecutivo();
        }

        private void GuardarCliente()
        {
            clscliente cliente = new clscliente();
            cliente.iIdcliente = Convert.ToInt32(txtid.Text);
            cliente.sNombre = txtnombre.Text;
            cliente.sApellido_p = txtapellidop.Text;
            cliente.sApellido_m = txtapellidom.Text;
            cliente.sTelefono = txttelefono.Text;
            cliente.sCalle = txtcalle.Text;
            cliente.sNum_int = txtnumint.Text;
            cliente.sNum_ext = txtnumext.Text;
            cliente.sColonia = txtcolonia.Text;
            cliente.iMunicipio = Convert.ToInt32(cmbxMunicipio.SelectedValue);
            cliente.sStatus = cmbxstatus.Text.Substring(0,1);

            
                if (cliente.Guardar() == true)
                {
                    MessageBox.Show("Sus Datos se guardaron correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Sus Datos no se pudieron guardar error: " + cliente.error);

                }

            

            



        }
        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(cl_id_cliente),0) + 1 AS consecutivo FROM CLIENTE";


            conn.Open();
            l = cmd.ExecuteReader();
            if (l.Read())
            {
                txtid.Text = Convert.ToString(l.GetInt32(0));
            }


        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtapellidop.Clear();
            txtapellidom.Clear();
            txttelefono.Clear();
            txtcalle.Clear();
            txtnumint.Clear();
            txtnumext.Clear();
            txtcolonia.Clear();
            consecutivo();
            this.cLIENTETableAdapter2.Fill(this.panesitoDataSet2.CLIENTE);

        }

        private void actualizar()
        {
            SqlConnection con = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTE";
            string sSTATUS = cmbxstatus.Text;

            cmd.Parameters.AddWithValue("@op", 2);
            cmd.Parameters.AddWithValue("@IDCLIENTE", txtid.Text);
            cmd.Parameters.AddWithValue("@STATUS", sSTATUS.Substring(0, 1));
            MessageBox.Show("Sus datos se guardaron correctamente");

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            limpiar();

        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
                       
            if(clscliente.ValidarCamposVacios(this, errorValidacionVacio) == false)

            {

                MessageBox.Show("Ha ocurrido un error");
                limpiar();


            }
            else
            {

                GuardarCliente();

            }

            
              

        }

        private void txtid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmpedidos PED = new frmpedidos();
                PED.Show();
            }
        }

        private void dtwclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_id_cliente.ToString();
            txtnombre.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_nombre.ToString();
            txtapellidop.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_apellido_pat.ToString();
            txtapellidom.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_apellido_mat.ToString();
            txttelefono.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_telefono.ToString();
            txtcalle.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_calle.ToString();
            txtnumint.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_num_interior.ToString();
            txtnumext.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_num_exterior.ToString();
            txtcolonia.Text = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_colonia.ToString();
            cmbxMunicipio.SelectedValue = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_id_municipio;
            string sMUNICIPIO;
            sMUNICIPIO = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_id_municipio.ToString();
            switch (sMUNICIPIO)
            {
                case "11":
                    cmbxMunicipio.Text = "Guasave";
                    break;
                default:
                    cmbxMunicipio.Text = "";
                    break;
            }
            string sSTATUS;
            sSTATUS = this.panesitoDataSet2.CLIENTE[cLIENTEBindingSource2.Position].cl_status.ToString();
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


        // Validacion de los cuadros de Texto
        /*ublic bool ValidarDatos() // Validar espacios en blanco y si no cumplen con las condiciones
        {

            bool validacion = true;

            if(txttelefono.Text == "")
            {

                validacion = false;
                //errorTel.SetError(txttelefono, "Ingresar Telefono");
                MessageBox.Show(" Error al ingresar el Telefono");
             

            }

            if (txtnombre.Text == "")
            {

                validacion = false;
                errorNombre.SetError(txtnombre, "Ingresar Nombre");
                //MessageBox.Show(" Error al ingresar el Nombre");


            }


            if (txtapellidop.Text == "")
            {

                validacion = false;
                errorApePat.SetError(txttelefono, "Ingresar Apellido Paterno");
                //MessageBox.Show(" Error al ingresar el Apellido Paterno");

            }
            if (txtapellidom.Text == "")
            {

                validacion = false;
                //errorApeMat.SetError(txttelefono, "Ingresar Apellido Materno");
                MessageBox.Show(" Error al ingresar el Apellido Materno");

            }
            if (txtcolonia.Text == "")
            {

                validacion = false;
                //errorCol.SetError(txttelefono, "Ingresar Colonia");
                MessageBox.Show(" Error al ingresar la Colonia");



            }

            if (txtnumint.Text == "")
            {

                validacion = false;
                errorNInte.SetError(txttelefono, "Ingresar Numero Interior");
                //MessageBox.Show(" Error al ingresar el Numero Interior");

            }
            if (txtnumext.Text == "")
            {

                validacion = false;
                errorrNumExt.SetError(txttelefono, "Ingresar Numero Exterior");
                //MessageBox.Show(" Error al ingresar el Numero Exterior");


            }

            if (txtcalle.Text == "")
            {

                validacion = false;
                errorCalle.SetError(txttelefono, "Ingresar Calle");
                //MessageBox.Show(" Error al ingresar la Calle");


            }


            return validacion;

        }*/



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txttelefono_Validating(object sender, CancelEventArgs e)
        {

            /*int num;
            if(!int.TryParse(txttelefono.Text, out num))
            {

                errorTel.SetError(txttelefono, "Ingrese Solo Numeros");

            }
            else
            {

                errorTel.SetError(txttelefono, "");

            }*/

        }

        private void txtnumint_Validating(object sender, CancelEventArgs e)
        {

            /*int ErrorNum;
            if (!int.TryParse(txtnumint.Text, out ErrorNum))
            {

                errorNInte.SetError(txtnumint, "Ingrese Solo Numeros");

            }
            else
            {

                errorNInte.SetError(txtnumint, "");

            }*/

        }

        private void txtnumext_Validating(object sender, CancelEventArgs e)
        {

            /*int ErrorNum;
            if (!int.TryParse(txtnumext.Text, out ErrorNum))
            {

                errorrNumExt.SetError(txtnumext, "Ingrese Solo Numeros");

            }
            else
            {

                errorrNumExt.SetError(txtnumext, "");

            }*/

        }








        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                errorNombre.SetError(txtnombre, "Ingrese solo Letras");


            }
            else
            {
                
                errorNombre.SetError(txtnombre, "");

            }*/

        }




        private void txtapellidop_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                errorApePat.SetError(txtapellidop, "Ingrese solo Letras");
                

            }
            else
            {

                errorApePat.SetError(txtapellidop, "");

            }*/

        }

        private void txtapellidom_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                errorApeMat.SetError(txtapellidom, "Ingrese solo Letras");
               

            }
            else
            {

                errorApeMat.SetError(txtapellidom, "");

            }*/

        }

        private void txtcolonia_KeyPress(object sender, KeyPressEventArgs e)
        {

            /*if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                errorCol.SetError(txtcolonia, "Ingrese solo Letras");
              

            }
            else
            {

                errorCol.SetError(txtcolonia, "");

            }*/

        }

        private void txtcalle_KeyPress(object sender, KeyPressEventArgs e)
        {


            /*if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                errorCalle.SetError(txtcalle, "Ingrese solo Letras");

            }

            else
            {

                errorCalle.SetError(txtcalle, "");
                

            }*/

            

        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {

            

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

            limpiar();

        }
    }
}
