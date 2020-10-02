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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmE1();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario2 = new FrmE2();
            formulario2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario3 = new FrmE3();
            formulario3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario4 = new FrmE4();
            formulario4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario5 = new FrmE5();
            formulario5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario6 = new FrmE6();
            formulario6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario7 = new FrmE7();
            formulario7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario8 = new FrmE8();
            formulario8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario9 = new FrmE9();
            formulario9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario10 = new FrmE10();
            formulario10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    