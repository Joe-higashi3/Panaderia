﻿using System;
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
            string miconexion = @"Data Source=M3\BASEDATOSJUAN;Initial Catalog=panesito;Integrated Security=True";
            //Data Source = M3\BASEDATOSJUAN; Initial Catalog = panesito; Integrated Security = True
            return miconexion;
        }
    }
}
