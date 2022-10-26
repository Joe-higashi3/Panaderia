using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Libreria
{
    public partial class validacionvaciosynumeros : TextBox
    {
        public validacionvaciosynumeros()
        {
            InitializeComponent();
        }
        public Boolean validarvacio
        {
            set;get;
        }

        public Boolean SoloNum
        {

            set; get;

        }



    }
}
