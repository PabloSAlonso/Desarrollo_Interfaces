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
        public Form2()
        {
            InitializeComponent();

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

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] colorFinal = new byte[3];
            string[] rgb = { textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim() };
            for (int i = 0; i < rgb.Length; i++)
            {
                if (byte.TryParse(rgb[i], out colorFinal[i]))
                {

                }
            }
            this.BackColor = Color.FromArgb(colorFinal[0], colorFinal[1], colorFinal[2]);
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
                ((Button)sender).BackColor = Color.Empty;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CancelButton = btnSalir;
            AcceptButton = btnColor;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnColor;
        }
    }
}
