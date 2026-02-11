using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int Errores
        {
            set
            {
                errores = value;
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
                    point1 = new Point(0, 0);
                    point2 = new Point(0, this.Height);
                    pe.Graphics.DrawLine(pen, 0, 0, 0, this.Height);
                    return;

                case 2:
                    point1 = new Point(0, this.Height);
                    point2 = new Point(this.Width / 2, 0);
                    pe.Graphics.DrawLine(pen, 0, this.Height, this.Width / 2, 0);
                    return;

                case 3:
                    point1 = new Point(this.Width / 2, 0);
                    point2 = new Point(this.Width / 2, this.Height / 12);
                    pe.Graphics.DrawLine(pen, this.Width / 2, 0, this.Width / 2, this.Height / 12);
                    return;

                case 4:
                    pe.Graphics.DrawEllipse(pen, this.Width / 2 - 15, this.Height / 12, 30, 30);
                    return;

                case 5:
                    point1 = new Point();
                    point2 = new Point();
                    pe.Graphics.DrawLine(pen, point1, point2);
                    return;

                case 6:
                    point1 = new Point();
                    point2 = new Point();
                    pe.Graphics.DrawLine(pen, point1, point2);
                    point2 = new Point(); //Cambia hacia donde va el brazo
                    pe.Graphics.DrawLine(pen, point1, point2);
                    return;

                case 7:
                    point1 = new Point();
                    point2 = new Point();
                    pe.Graphics.DrawLine(pen, point1, point2);
                    point2 = new Point(); //Cambia hacia donde va la pierna
                    pe.Graphics.DrawLine(pen, point1, point2);
                    return;

            }
        }
    }
}
