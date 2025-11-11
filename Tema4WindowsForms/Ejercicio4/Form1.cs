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
            foreach (String item in listBox1.Items)
            {
                if (textBox1.Text != "" && textBox1.Text != null && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(textBox1.Text);
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (rbtn1.Checked)
            {
                foreach (String item in listBox1.Items)
                {
                    if (item == textBox1.Text)
                    {
                        listBox1.Items.Remove(item);
                    }
                }
            }
            else if (rbtn2.Checked)
            {
                foreach (String item in listBox2.Items)
                {
                    if (item == textBox1.Text)
                    {
                        listBox2.Items.Remove(item);
                    }
                }
            } else
            {

            }

        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {

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
                btnQuitar.Text = "Traspasar 1 a 2";
            }
            else if (rbtn4.Checked)
            {
                btnQuitar.Text = "Traspasar 2 a 1";
            }
            else
            {
                btnQuitar.Text = "Traspasar";
            }
        }
    }
}
