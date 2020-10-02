using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1.Formularios
{
    public partial class FrmE5 : Form
    {
        public FrmE5()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            double dolares, lempiras;
            dolares = double.Parse(txtd.Text);
            lempiras = dolares * 24.64;
            txtl.Text = lempiras.ToString();
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            txtd.Text = "";
            txtl.Text = "";
        }
    }
}
