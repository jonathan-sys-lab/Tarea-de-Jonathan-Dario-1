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
    public partial class FrmE10 : Form
    {
        public FrmE10()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            double galones, litros;
            galones = double.Parse(txtGal.Text);
            litros = galones * 3.78541;
            txtLitros.Text = litros.ToString();
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            txtGal.Text = "";
            txtLitros.Text = "";
        }
    }
}
