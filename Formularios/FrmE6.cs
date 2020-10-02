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
    public partial class FrmE6 : Form
    {
        public FrmE6()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double lempiras, euros;
            lempiras = double.Parse(txtlem.Text);
            euros = lempiras * 0.035;
            txteu.Text = euros.ToString();

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txteu.Text = "";
            txtlem.Text = "";

        }
    }
}
