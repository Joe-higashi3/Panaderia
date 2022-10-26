using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.clases
{
    public class Conexion
    {
        public static string conn()
        {
            string miconexion = @"Data Source=LAPTOP-4RK8N9SL;Initial Catalog=panesito;user=Administrador;password=1234";
            return miconexion;
        }
    }
}
