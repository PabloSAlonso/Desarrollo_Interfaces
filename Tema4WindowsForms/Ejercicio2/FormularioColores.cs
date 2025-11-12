using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormularioColores : Form
    {

        static Color colorDefault;
        public FormularioColores()
        {
            InitializeComponent();
            CancelButton = btnSalir;
            AcceptButton = btnColor;
            colorDefault = btnColor.BackColor;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres salir del formulario?", "Ejercicio2", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ValidateTextBoxsColor(((TextBox)sender).Text).Item1)
            {
                ((TextBox)sender).ForeColor = Color.Green;
            }
            else
            {
                ((TextBox)sender).ForeColor = Color.Red;
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            string[] textBoxes = { textBox1.Text, textBox2.Text, textBox3.Text };

            foreach (string txb in textBoxes)
            {
                if (ValidateTextBoxsColor(txb).Item1)
                {
                    byte r = ValidateTextBoxsColor(txb).Item2;
                    byte g = ValidateTextBoxsColor(txb).Item2;
                    byte b = ValidateTextBoxsColor(txb).Item2;
                    this.BackColor = Color.FromArgb(r, g, b);
                }
                else
                {
                    this.BackColor = Color.White;
                    MessageBox.Show("Color cambiado a blanco por error de datos", "DEFAULT COLOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
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
                ((Button)sender).BackColor = colorDefault;
            }
        }


        public static (bool, byte) ValidateTextBoxsColor(string text)
        {
            bool isChecked = byte.TryParse(text.Trim(), out byte value);
            return (isChecked, value);
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
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.Name == textBox4.Name)
                    {
                        ctrl.Text = "";
                    }
                    else
                    {
                        ctrl.Text = "0";
                    }
                }

            }
            this.BackColor = colorDefault;
            pictureBox1.Image = null;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == null || textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Introduce una ruta válida de una imagen", "ERROR DE IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    pictureBox1.Image = new Bitmap(textBox4.Text);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                } 
                catch (ArgumentException)
                {
                    MessageBox.Show("No se encuentra la imagen", "ERROR DE IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("No se encontró la imagen", "ERROR DE IMAGEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnCargar;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            AcceptButton = btnColor;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
