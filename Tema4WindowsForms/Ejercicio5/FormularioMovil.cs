using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class FormularioMovil : Form
    {
        public FormularioMovil()
        {
            InitializeComponent();
        }
        Button boton;

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 50;
            int y = 40;
            for (int i = 0; i < 12; i++)
            {
                boton = new Button();
                boton.Size = new Size(80, 20);
                boton.Enabled = true;
                if (i % 3 == 0)
                {
                    x = 50;
                    y += 40;
                }
                x += 100;
                boton.Location = new Point(x, y);
                if (i < 10)
                {
                    boton.Text = i.ToString();
                }
                else
                {
                    boton.Text = i == 10 ? "*" : "#";
                }
                boton.Visible = true;
                this.Controls.Add(boton);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario recrea el teclado numérico de un teléfono y fue diseñado por Curro Bellas y realizado por Pablo...", "Informacion de la app", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void separadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioMovil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del programa?", "SALIENDO DEL PROGRAMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }
    }
}
