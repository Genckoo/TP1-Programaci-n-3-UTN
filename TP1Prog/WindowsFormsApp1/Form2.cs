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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtNombre.Text + " " + txtApe.Text;
            foreach (string nombres in lbNom.Items)
            {
                if (nombres.ToUpper() == nombreCompleto.ToUpper())
                {
                    MessageBox.Show("Ya existe este nombre");
                    return;
                }
            }
            if (txtNombre.Text.Trim().Length > 0 && txtApe.Text.Trim().Length > 0)
            {
                lbNom.Items.Add(nombreCompleto);
                txtApe.Text = "";
                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Se deben llenar ambos campos");
            }
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            if (lbNom.SelectedItem != null)
            {
                lbNom.Items.Remove(lbNom.SelectedItem);
            }
            else
            {
                MessageBox.Show("No estas seleccionando nada");
            }
        }
    }
}
