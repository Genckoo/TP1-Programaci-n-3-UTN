using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNombres_Click(object sender, EventArgs e)
        {
            foreach (string nombres in lbNombres.Items)
            {
                if (txtNombres.Text.Trim().ToUpper() == nombres.Trim().ToUpper())
                {
                    MessageBox.Show("Ya existe este nombre");
                    txtNombres.Text = "";
                    return;
                }
            }

                if (txtNombres.Text.Trim().Length > 0)
                {
                    lbNombres.Items.Add(txtNombres.Text);
                    txtNombres.Text = "";
            }
                else
                {
                    MessageBox.Show("Esta vacio");
                    txtNombres.Text = "";
            }
            }

        private void btnPasar1_Click(object sender, EventArgs e)
        {
            if (lbNombres.Items.Count > 0 && lbNombres.SelectedItems.Count > 0)
            {
                lbNombrespasados.Items.Add(lbNombres.SelectedItem.ToString());
                lbNombres.Items.Remove(lbNombres.SelectedItem.ToString());
            }
            else{
                MessageBox.Show("Esta vacio o no seleccionaste nada");
            }
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            if (lbNombres.Items.Count > 0)
            {
                lbNombrespasados.Items.AddRange(lbNombres.Items);
                lbNombres.Items.Clear();
            }
            else{
                MessageBox.Show("Esta vacio");
            }
        }
    }
    }

