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

        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {

        }

    }
}
