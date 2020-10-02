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
    public partial class FrmE2 : Form
    {
        public FrmE2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnp_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, p;
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);
            n3 = double.Parse(txtn3.Text);
            n4 = double.Parse(txtn4.Text);
            p = (n1 + n2 + n3 + n4) / 4;
            txtp.Text = p.ToString();
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            txtn4.Text = "";
            txtp.Text = "";
        }
    }
}
