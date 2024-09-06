using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo, estado, oficios = "";

            if (rbtnFem.Checked)
            {
                sexo = rbtnFem.Text;
            }
            else{ 
                sexo = rbtnMasc.Text;
            }

            if (rbtnCasado.Checked)
            {
                estado = rbtnCasado.Text;
            }
            else
            {
                estado= rbtnSoltero.Text;
            }

            foreach (string lista in clbOpcs.CheckedItems)
            {
                oficios +="- " + lista + "\n";
            }

            label1.Text = "Usted seleccionó los siguientes elementos: ";
            lblSexo.Text= "Sexo: " + sexo;
            lblEstado.Text = "Estado civil: " + estado;
            lblPosiciones.Text = "Oficio: " + "\n" + oficios;
        }
    }
}
