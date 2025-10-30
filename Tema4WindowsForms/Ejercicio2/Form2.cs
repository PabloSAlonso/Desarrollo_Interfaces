using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form2 : Form
    {

        static Color coloresBotones;
        public Form2()
        {
            InitializeComponent();
            CancelButton = btnSalir;
            AcceptButton = btnColor;
            coloresBotones = btnColor.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Quieres salir del formulario?", "Ejercicio2", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        private void Form2_MouseEnter(object sender, EventArgs e) //Revisar condicion
        {
            if (sender.GetType() == typeof(Button))
            {
                ((Button)sender).BackColor = Color.Red;
            }
        }

        private void Form2_MouseLeave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                ((Button)sender).BackColor = coloresBotones;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnColor;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            String direccionImagen = textBox4.Text;
        }
        public static (bool, byte) validateTextBoxsColor(string text)
        {
            bool isChecked = byte.TryParse(text.Trim(), out byte value);
            return (isChecked, value);
        }
        private void btnColor_MouseClick(object sender, MouseEventArgs e)
        {
            string[] textBoxes = { textBox1.Text, textBox2.Text, textBox3.Text };

            foreach (string txb in textBoxes)
            {
                if (validateTextBoxsColor(txb).Item1)
                {
                    byte r = validateTextBoxsColor(txb).Item2;
                    byte g = validateTextBoxsColor(txb).Item2;
                    byte b = validateTextBoxsColor(txb).Item2;

                    this.BackColor = Color.FromArgb(r, g, b);
                }
                else
                {
                    MessageBox.Show("Introduce números del 0 al 255 en todos los campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    control.MouseEnter += Form2_MouseEnter;
                    control.MouseLeave += Form2_MouseLeave;
                }
            }
        }

        private void btnReset_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = coloresBotones;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox)) //TODO mar de dudas
                {
                    if (((TextBox)control).Name == textBox4.Name)
                    {

                        control.Text = "0";
                    }
                    else
                    {
                        control.ResetText();
                    }
                    control.ResetText();
                }
            }
        }
    }
}
