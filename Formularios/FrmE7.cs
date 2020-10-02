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
    public partial class FrmE7 : Form
    {
        public FrmE7()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            double llantas, precio, total;
            llantas = double.Parse(txtll.Text);
            precio = double.Parse(txtprecio.Text);
            total = llantas*precio;
            txtpagar.Text = total.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtll.Text = "";
            txtpagar.Text = "";
            txtprecio.Text = "";
        }
    }
}
