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
        Color colorDefault;
        String[] teclas = {"1","2","3","4","5","6","7", "8", "9", "*", "0", "#"};
        public FormularioMovil()
        {
            InitializeComponent();
            colorDefault = btnReset.ForeColor;

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
                boton.Text = teclas[i];
                boton.Visible = true;
                boton.MouseClick += botones_MouseClick;
                boton.MouseEnter += botones_MouseEnter;
                boton.MouseLeave += botones_MouseLeave;
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
        private void botones_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                textBox1.Text += ((Button)sender).Text;
            }
        }

        private void botones_MouseEnter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                ((Button)sender).ForeColor = Color.Red;
            }
        }
        private void botones_MouseLeave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                ((Button)sender).ForeColor = colorDefault;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (Control control in Controls)
            {
                ((Button)control).ForeColor = colorDefault;
            }
        }
    }
}
