using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.libreria
{
    public partial class Errortxtbox : TextBox
    {
        public Errortxtbox()
        {
            InitializeComponent();
        }


        public Boolean Validar
        {
            set; get;

        }


    }
}
