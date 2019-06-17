using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            
            if(rdbEqui.Checked == true)
            {
                triangulo.LadoA = Double.Parse(txtLado1.Text);
                triangulo.LadoB = Double.Parse(txtLado1.Text);
                triangulo.LadoC = Double.Parse(txtLado1.Text);
            }

            else if (rdbIso.Checked == true)
            {
                triangulo.LadoA = Double.Parse(txtLado1.Text);
                triangulo.LadoB = Double.Parse(txtLado2.Text);
                triangulo.LadoC = Double.Parse(txtLado1.Text);
            }

            //if (rdbEsc.Checked == true)
            else
            {
                triangulo.LadoA = Double.Parse(txtLado1.Text);
                triangulo.LadoB = Double.Parse(txtLado2.Text);
                triangulo.LadoC = Double.Parse(txtLado3.Text);
            }

            txtArea.Text = Convert.ToString(triangulo.CalcularArea());
            txtPerim.Text = Convert.ToString(triangulo.CalcularPerimetro());
        }

        private void rdbEqui_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEqui.Checked == true)
            {
                lblLado1.Visible = true;
                lblLado2.Visible = false;
                lblLado3.Visible = false;

                txtLado1.Visible = true;
                txtLado2.Visible = false;
                txtLado3.Visible = false;
            }            
        }

        private void rdbIso_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIso.Checked == true)
            {
                lblLado1.Visible = true;
                lblLado2.Visible = true;
                lblLado3.Visible = false;

                txtLado1.Visible = true;
                txtLado2.Visible = true;
                txtLado3.Visible = false;
            }
        }

        private void rdbEsc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEsc.Checked == true)
            {
                lblLado1.Visible = true;
                lblLado2.Visible = true;
                lblLado3.Visible = true;

                txtLado1.Visible = true;
                txtLado2.Visible = true;
                txtLado3.Visible = true;
            }
        }
    }
}