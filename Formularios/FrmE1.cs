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
    public partial class FrmE1 : Form
    {
        public FrmE1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, r;
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);
            n3 = double.Parse(txtn3.Text);
            r = n1 + n2 + n3;
            txtr.Text = r.ToString();
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            txtr.Text = "";

        }
    }
}
