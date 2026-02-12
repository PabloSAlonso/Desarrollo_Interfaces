using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LabelTextBox
{
    public partial class dibujoAhorcado : Control
    {
        public dibujoAhorcado()
        {
            InitializeComponent();
        }

        private int errores = 0;
        [Category("Mis atributos")]
        [Description("Errores que determinan cuanto dibujo hay")]
        public int Errores
        {
            set
            {
                if (value < 0 || value > 7)
                {
                    value = 0;
                }
                if (errores != value)
                {
                    OnCambiaError(this, EventArgs.Empty);
                }
                if (value == 7)
                {
                    OnAhorcado(this, EventArgs.Empty);
                }
                errores = value;
                Refresh();
            }
            get
            {
                return errores;
            }
        }

        [Category("Eventos Propios Componente")]
        [Description("Evento que se lanza cada vez que cambia el número de errores")]
        public event EventHandler CambiaError;
        protected virtual void OnCambiaError(object sender, EventArgs e)
        {
            if (CambiaError != null)
            {
                CambiaError(this, EventArgs.Empty);
            }
        }

        [Category("Eventos Propios Componente")]
        [Description("Evento que se lanza cuando se completa el dibujo")]
        public event EventHandler Ahorcado;
        protected virtual void OnAhorcado(object sender, EventArgs e)
        {
            if (Ahorcado != null)
            {
                Ahorcado(this, EventArgs.Empty);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Pen pen = new Pen(Color.Black);
            Point point1;
            Point point2;
            switch (errores)
            {
                case 0:
                    pe.Graphics.Clear(DefaultBackColor);
                    return;
                case 1:
                    //Poste
                    point1 = new Point(this.Width - 1, this.Height - 1);
                    point2 = new Point(0, this.Height - 1);
                    pe.Graphics.DrawLine(pen, point1, point2);
                    point1 = new Point(0, 0);
                    point2 = new Point(0, this.Height);
                    pe.Graphics.DrawLine(pen, point1, point2);
                    return;

                case 2:
                    //Rama para cuerda
                    point1 = new Point(0, 0);
                    point2 = new Point(this.Width - (this.Width / 10), 0);
                    pe.Graphics.DrawLine(pen, point1, point2);
                    goto case 1;

                case 3:
                    //Cuerda
                    point1 = new Point(this.Width - (this.Width / 4), 0);
                    point2 = new Point(this.Width - (this.Width / 4), this.Height / 10);
                    pe.Graphics.DrawLine(pen, point1, point2);
                    goto case 2;

                case 4:
                    //Cabeza
                    pe.Graphics.DrawEllipse(pen, this.Width - (this.Width / 4) - 15, this.Height / 10, 30, 30);
                    goto case 3;

                case 5:
                    //Torso
                    point1 = new Point(this.Width - (this.Width / 4), this.Height / 10 + 30);
                    point2 = new Point(this.Width - (this.Width / 4), this.Height / 10 + 60);
                    pe.Graphics.DrawLine(pen, point1, point2);
                    goto case 4;

                case 6:
                    point1 = new Point(this.Width - (this.Width / 4), this.Height / 10 + 40);
                    point2 = new Point(this.Width - (this.Width / 4) + 25, this.Height / 10 + 50);
                    pe.Graphics.DrawLine(pen, point1, point2);
                    point2 = new Point(this.Width - (this.Width / 4) - 25, this.Height / 10 + 50); //Cambia hacia donde va el 2º brazo
                    pe.Graphics.DrawLine(pen, point1, point2);
                    goto case 5;

                case 7:
                    point1 = new Point(this.Width - (this.Width / 4), this.Height / 10 + 60);
                    point2 = new Point(this.Width - (this.Width / 4) + 25, this.Height / 10 + 70);
                    pe.Graphics.DrawLine(pen, point1, point2);
                    point2 = new Point(this.Width - (this.Width / 4) - 25, this.Height / 10 + 70); //Cambia hacia donde va la 2º pierna
                    pe.Graphics.DrawLine(pen, point1, point2);
                    goto case 6;
            }
        }
    }
}
