using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppnotasUpa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void definitiva_Click(object sender, EventArgs e)
        {
            double nota151, nota201, nota152, nota202, nota103, nota203, suma;
            nota151 = double.Parse(txtNota151.Text);
            nota201 = double.Parse(txtNota201.Text);
            nota152 = double.Parse(txtNota152.Text);
            nota202 = double.Parse(txtNota202.Text);
            nota103 = double.Parse(txtNota103.Text);
            nota203 = double.Parse(txtNota203.Text);
            suma = (nota151 * 0.15) + (nota201 * 0.20) + (nota152 * 0.15) + (nota202 * 0.20) + (nota103 * 0.10) + (nota203 * 0.20);
            Txtresultado.Text = sumaToString();

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            If (suma>=3
           {
                 MessageBox.Show(“Aprobado”)
}
             else
{
                MessageBox.Show(“No Aprobado”)
}

            txtNota151.Text=””;
            txtNota201.Text=””;
            txtNota152.Text=””;
            txtNota202.Text=””;
            txtNota153.Text=””;
            txtNota203.Text=””;
            txtResultado.Text=””;

        }
    }
}
