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
        

        

        private void Ejercicio1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Ejercicio1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            this.Text = $"X: {x}, Y: {y}";
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int xbtn = this.button1.Location.X;
            int ybtn = this.button1.Location.Y;
            this.Text = $"X: {xbtn + x} Y:{ybtn + y}";
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int xbtn = this.button2.Location.X;
            int ybtn = this.button2.Location.Y;
            this.Text = $"X: {xbtn + x} Y:{ybtn + y}";
        }
    }
}
