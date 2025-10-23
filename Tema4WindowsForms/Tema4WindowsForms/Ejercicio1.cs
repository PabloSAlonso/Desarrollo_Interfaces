using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema4WindowsForms;

namespace Tema4WindowsForms
{
    public partial class Ejercicio1 : Form
    {
        Button button;
        string titulo;
        public Ejercicio1()
        {
            InitializeComponent();
            titulo = this.Text;
        }

        private void Ejercicio1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int xbtn ;
            int ybtn ;
            if (sender == this)
            {
                //coordenadas del elemento donde está el raton (lo hará si el elemento es el formulario)
               
                this.Text = $"X: {x}, Y: {y}";
            }
            else
            {
               
                xbtn = ((Button)sender).Location.X;
                ybtn = ((Button)sender).Location.Y;
                this.Text = $"X: {xbtn + x} Y:{ybtn + y}";
            }


        }



        private void Ejercicio1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = titulo;
        }


        private void Ejercicio1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Yellow;

            }

            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
            }
        }

        private void Ejercicio1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Empty;

            }

            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Empty;
            }
            else
            {
                button1.BackColor = Color.Empty;
                button2.BackColor = Color.Empty;
            }
        }

        private void Ejercicio1_KeyDown(object sender, KeyEventArgs e)
        {
            Text = e.KeyCode.ToString();
            if (e.KeyCode is Keys.Escape)
            {
                Text = titulo;
            }
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            int x = 200;
            int y = 300;
            for (int i = 0; i < 20; i++)
            {
                button = new Button();
                button.Size = new Size(80, 20);
                button.Enabled = true;
                if (i % 5 == 0)
                {
                    x = 200;
                    y += 40;
                }
                x += 100;
                button.Location = new Point(x, y);
                button.Text = "Boton " + (i + 1);
                button.MouseMove += Ejercicio1_MouseMove;
                button.MouseDown += Botones_MouseDown;
                button.MouseUp += Botones_MouseUp;
                this.Controls.Add(button);

            }
        }
        private void Botones_MouseDown(object sender, MouseEventArgs e)
        {

            ((Button)sender).ForeColor = Color.Red;

        }
        private void Botones_MouseUp(object sender, MouseEventArgs e)
        {

            ((Button)sender).ForeColor = Color.Black;


        }


    }

    //• Los botones “emularán” los botones del ratón (izquierdo y derecho)
    //cambiando de color si dicho botón del ratón está pulsado sobre el
    //formulario imagen. En caso de un ratón con otros botones dicha
    //pulsación coloreará los dos Button al mismo tiempo. Este efecto será
    //solo sobre el formulario, no es necesario sobre los componentes del
    //mismo.

    //• Además si se pulsa alguna tecla, dicha tecla debe aparecer como título
    //del formulario. Si se pulsa ESC, entonces se restaura el título del
    //formulario.


    //• Debajo de los botones, o a un lado, se crearán en tiempo de ejecución
    //20 botones en 4 filas y 5 columnas. Dichos botones tendrán en su
    //campo text los números del 1 al 20.

    //Cuando algún botón es pulsado su número cambia de color y al soltarlo vuelve a negro. Recuerda que las
    //coordenadas también deben funcionar en estos botones.
    //Al salir debe preguntar al usuario si está seguro y cancelar en caso negativo.
}