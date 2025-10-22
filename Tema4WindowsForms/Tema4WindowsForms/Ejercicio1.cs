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
        string titulo;
        public Ejercicio1()
        {
            InitializeComponent();
            titulo = this.Text;
        }



        private void Ejercicio1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {MousePosition.X}, Y: {MousePosition.Y}";

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
            else if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right && sender == Controls)
            {

            }
            else
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
            }
        }

        private void Ejercicio1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Empty;
            button2.BackColor = Color.Empty;
        }

        private void Ejercicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Text = e.KeyChar.ToString();
            if (e.KeyChar is (char)Keys.Escape)
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
                Button button = new Button();
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
                this.Controls.Add(button);
                button.MouseMove += Ejercicio1_MouseMove;
                button.MouseDown += Ejercicio1_MouseDown;
                button.MouseUp += Ejercicio1_MouseUp;

            }
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