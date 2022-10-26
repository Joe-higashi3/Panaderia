﻿using System;
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
    public partial class frminsumo : Form
    {
        clases.Conexion objconection;
        SqlConnection conexion;
        string sConexion;
        public frminsumo()
        {
            InitializeComponent();
            sConexion = Conexion.conn();
            uNIDADTableAdapter.Connection.ConnectionString = sConexion;
            iNSUMOTableAdapter.Connection.ConnectionString = sConexion;
        }

        private void frminsumos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsunidadp.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter.Fill(this.dsunidadp.UNIDAD);
            // TODO: esta línea de código carga datos en la tabla 'dsinsumop.INSUMO' Puede moverla o quitarla según sea necesario.
            this.iNSUMOTableAdapter.Fill(this.dsinsumop.INSUMO);
            consecutivo();

        }

        private void GuardarInsumo()
        {
            clsinsumo insumo = new clsinsumo();
            insumo.iIdinsumo = Convert.ToInt32(txtid.Text);
            insumo.sNombre = txtnombre.Text;
            insumo.fCosto = float.Parse(txtcosto.Text);
            insumo.iIdUnidad = Convert.ToInt32(cmbxunidad.SelectedValue);
            insumo.sStatus = cmbxistatus.Text.Substring(0, 1);

            if (insumo.GuardarInsumo() == true)
            {
                MessageBox.Show("Los datos se han guardado correctamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("ERROR: Los datos no se pudieron guardar: " + insumo.error);

            }
        }
        private void consecutivo()
        {

            SqlConnection conn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader l;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISNULL(MAX(in_id_insumo),0) + 1 AS consecutivo FROM INSUMO";


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
            txtcosto.Clear();
            consecutivo();
            this.iNSUMOTableAdapter.Fill(this.dsinsumop.INSUMO);
            this.uNIDADTableAdapter.Fill(this.dsunidadp.UNIDAD);
            txtnombre.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarInsumo();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void dgvinsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = this.dsinsumop.INSUMO[iNSUMOBindingSource.Position].in_id_insumo.ToString();
            txtnombre.Text = this.dsinsumop.INSUMO[iNSUMOBindingSource.Position].in_nombre.ToString();
            txtcosto.Text = this.dsinsumop.INSUMO[iNSUMOBindingSource.Position].in_costo.ToString();
            cmbxunidad.SelectedValue = this.dsunidadp.UNIDAD[uNIDADBindingSource.Position].un_id_unidad;

            cmbxistatus.SelectedValue = this.dsinsumop.INSUMO[iNSUMOBindingSource.Position].in_status;
            string sSTATUS;
            sSTATUS = this.dsinsumop.INSUMO[iNSUMOBindingSource.Position].in_status.ToString();
            switch (sSTATUS)
            {
                case "A":
                    cmbxistatus.Text = "Activo";
                    break;
                case "C":
                    cmbxistatus.Text = "Cancelado";
                    break;
                default:
                    cmbxistatus.Text = "Activo";
                    break;
            }
        }

        
    }
}
