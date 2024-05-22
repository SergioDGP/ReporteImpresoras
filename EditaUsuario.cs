using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteImpresoras
{
    public partial class EditaUsuario : Form
    {
        public EditaUsuario()
        {
            InitializeComponent();
        }

        private void btnSalirEdicion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
