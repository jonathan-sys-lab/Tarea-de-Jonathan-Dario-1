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
    public partial class FrmE9 : Form
    {
        public FrmE9()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldod, sueldohe, hetrabajdas, diastrabajados,std,sthe,total;
            sueldod = double.Parse(txtsd.Text);
            sueldohe = double.Parse(txtshe.Text);
            hetrabajdas = double.Parse(txthet.Text);
            diastrabajados = double.Parse(txtdias.Text);
            std = diastrabajados * sueldod;
            sthe = sueldohe * hetrabajdas;
            total = std + sthe;
            txtTotal.Text = total.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtdias.Text = "";
            txthet.Text = "";
            txtsd.Text = "";
            txtTotal.Text = "";
            txtshe.Text = "";
        }
    }
}
