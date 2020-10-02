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
    public partial class FrmE4 : Form
    {
        public FrmE4()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double mi, km;
            mi = double.Parse(txtm.Text);
            km = mi * 1.60934;
            txtk.Text = km.ToString();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtk.Text = "";
            txtm.Text = "";

        }
    }
}
