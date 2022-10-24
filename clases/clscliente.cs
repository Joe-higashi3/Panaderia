using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.libreria;

namespace WindowsFormsApp2.clases
{
    public class clscliente
    {
        public string error;
        public int iIdcliente { get; set; }
        public string sNombre { get; set; }
        public string sApellido_p { get; set; }
        public string sApellido_m { get; set; }
        public string sTelefono { get; set; }
        public string sCalle { get; set; }
        public string sNum_int { get; set; }
        public string sNum_ext { get; set; }
        public string sColonia { get; set; }
        public int iMunicipio { get; set; }
        public string sStatus { get; set; }

        public static Boolean ValidarCamposVacios(Control Objeto, ErrorProvider ErroProvider)
        {

            Boolean ExErrores = false;

            foreach (Control Item in Objeto.Controls)
            {


                if (Item is Errortxtbox)
                {

                    Errortxtbox Obj = (Errortxtbox)Item;

                    if (Obj.Validar == true)
                    {

                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {

                            ErroProvider.SetError(Obj, "No Puede Estar Vacio");
                            ExErrores = true;

                        }

                    }
                                                         
                    else
                    {

                        ErroProvider.SetError(Obj, "");

                    }
                }

            }

            return ExErrores;
        

        }

        public bool Guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conn());
            SqlCommand cmd = new SqlCommand("", conn);
            bool respuesta;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTE";

            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@IDCLIENTE", 1);
            cmd.Parameters.AddWithValue("@NOMBRE", sNombre);
            cmd.Parameters.AddWithValue("@APELLIDO_P", sApellido_p);
            cmd.Parameters.AddWithValue("@APELLIDO_M", sApellido_m);
            cmd.Parameters.AddWithValue("@TELEFONO", sTelefono);
            cmd.Parameters.AddWithValue("@CALLE", sCalle);
            cmd.Parameters.AddWithValue("@NUM_INT", sNum_int);
            cmd.Parameters.AddWithValue("@NUM_EXT", sNum_ext);
            cmd.Parameters.AddWithValue("@COLONIA", sColonia);
            cmd.Parameters.AddWithValue("@MUNICIPIO", iMunicipio);
            cmd.Parameters.AddWithValue("@STATUS", sStatus);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                respuesta = true;
            }
            catch(Exception ex)
            {
                respuesta = false;
                error = ex.ToString();
            }
            conn.Close();
            return respuesta;
        }
    }
}
