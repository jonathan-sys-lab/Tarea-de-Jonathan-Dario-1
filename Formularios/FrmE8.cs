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
    public partial class FrmE8 : Form
    {
        public FrmE8()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double dias,sueldo,total;
            dias = double.Parse(txttra.Text);
            sueldo = double.Parse(txtd.Text);
            total = dias * sueldo;
            txts.Text = total.ToString();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtd.Text = "";
            txts.Text = "";
            txttra.Text = "";
        }
    }
}
