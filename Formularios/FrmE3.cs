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
    public partial class FrmE3 : Form
    {
        public FrmE3()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            double me, mi;
            mi = double.Parse(txtmillas.Text);
            me = mi * 1609.34;
            txtmetros.Text = me.ToString();
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            txtmetros.Text = "";
            txtmillas.Text = "";
        }
    }
}
