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
           // string miconexion = @"Data Source=LAPTOP-J9RUHVUG\TRABAJOSDB;Initial Catalog=panesito;user=sa;password=Baltazar-123";
            string miconexion = @"Data Source=LAPTOP-J9RUHVUG\TRABAJOSDB;Initial Catalog=panesito;user=sa;password=Baltazar-123";
            return miconexion;
        }
    }
}
