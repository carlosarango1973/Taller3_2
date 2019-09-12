using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txthoras.Text) * Convert.ToDouble(txtvalor.Text);
            if (salario > 750000)
                lblmensaje.Text = "ganas más del mínimo";
            else
            { 
                salario = salario + salario * 0.2;
                lblmensaje.Text = salario.ToString();

            }
        }
    }
}
