using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4WindowsForms
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }



        private void Ejercicio1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {MousePosition.X}, Y: {MousePosition.Y}";
        }

        private void Ejercicio1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

       
    }
}

