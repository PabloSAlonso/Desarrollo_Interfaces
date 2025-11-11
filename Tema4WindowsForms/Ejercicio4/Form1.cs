using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = btnAñadir;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text.Trim();
            if (texto != "" && texto != null && !listBox1.Items.Contains(texto))
            {
                listBox1.Items.Add(textBox1.Text);
                lblContarItems.Text = listBox1.Items.Count.ToString();
            }

        }

        public void EliminarDeLista(ListBox listBox, RadioButton radio)
        {
            if (radio.Checked && listBox.Items.Count > 0)
            {
                try
                {
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Selecciona un elemento para eliminar y el radiobutton correspondiente", "Programa en Pausa...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            EliminarDeLista(listBox1, rbtn1);
            EliminarDeLista(listBox2, rbtn2);
        }

        public void TraspasarElementosLista(ListBox origen, ListBox destino, RadioButton radio)
        {
            if (radio.Checked && origen.Items.Count > 0)
            {
                //Traspasar solo seleccionados, no todos.
                foreach (var item in origen.Items)
                {
                    destino.Items.Add(origen.SelectedItem);
                }
                origen.Items.RemoveAt(origen.SelectedIndex);
            }
        }
        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            TraspasarElementosLista(listBox1, listBox2, rbtn3);
            TraspasarElementosLista(listBox2, listBox1, rbtn4);
        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked)
            {
                btnQuitar.Text = "Eliminar de 1";
            }
            else if (rbtn2.Checked)
            {
                btnQuitar.Text = "Eliminar de 2";
            }
            else
            {
                btnQuitar.Text = "Eliminar";
            }
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn3.Checked)
            {
                btnTraspasar.Text = "Traspasar 1 a 2";
            }
            else if (rbtn4.Checked)
            {
                btnTraspasar.Text = "Traspasar 2 a 1";
            }
            else
            {
                btnTraspasar.Text = "Traspasar";
            }
        }
    }
}
