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
    public partial class FormularioListas : Form//Texto a labels
    {
        ToolTip tp = new ToolTip();

        public FormularioListas()
        {
            InitializeComponent();
            AcceptButton = btnAñadir;
            timer1.Start();
            this.Text = "Formulario Listas";
            tp.SetToolTip(listBox2, $"El numero de elementos de la lista es {listBox2.Items.Count}");
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
                while (listBox.SelectedItems.Count > 0)
                {
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                }
                lblContarItems.Text = listBox1.Items.Count.ToString();
                tp.SetToolTip(listBox2, $"El numero de elementos de la lista es {listBox2.Items.Count}");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            EliminarDeLista(listBox1, rbtn1);
            EliminarDeLista(listBox2, rbtn2);
        }

        public void TraspasarElementosLista(ListBox origen, ListBox destino, RadioButton radio)
        {
            ListBox listaAux = new ListBox();
            if (radio.Checked && origen.Items.Count > 0)
            {

                while (origen.SelectedItems.Count > 0)
                {
                    destino.Items.Add(origen.SelectedItem);
                    origen.Items.RemoveAt(origen.SelectedIndex);
                }
                lblContarItems.Text = listBox1.Items.Count.ToString();
                tp.SetToolTip(listBox2, $"El numero de elementos de la lista es {listBox2.Items.Count}");

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

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icono1;
            string textoAux = "FormularioListas";
            this.Text = textoAux.Substring(textoAux.Length - i - 1);
            i++;
            if (i >= textoAux.Length)
            {
                i = 0;

            }
            if (i % 2 == 0)
            {
                this.Icon = Properties.Resources.icono2;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textAux = "";
            foreach (var indice in listBox1.SelectedIndices)
            {
                textAux += $"{indice}, ";
            }
            lblListarIndices.Text = textAux;
        }

    }
}