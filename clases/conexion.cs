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
            string miconexion = @"Data Source=PB;Initial Catalog=panesito;User ID=SA;Password=perla0238";
            return miconexion;
        }
    }
}
