using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("Quieres poner \"" + txtBox1.Text + "\" como titulo del formulario?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                Form1.ActiveForm.Text = txtBox1.Text;
            }

        }
    }
}
