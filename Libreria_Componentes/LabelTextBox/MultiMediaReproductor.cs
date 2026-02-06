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
    public partial class MultiMediaReproductor : UserControl
    {
        public MultiMediaReproductor()
        {
            InitializeComponent();
        }

        [Category("Acción")]
        [Description("Evento que se lanza al pulsar el boton Play / Stop del componente")]
        public event EventHandler PlayClick; //asegurar que lo que se pulsa es el boton
        protected virtual void OnPlayClick(object sender, EventArgs e)
        {
            if (PlayClick != null)
            {
                PlayClick(this, EventArgs.Empty);
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            btnReproducir.Text = btnReproducir.Text == "Play" ? "Stop" : "Play";
            OnPlayClick(sender, e);
        }

        [Category("Propiedades etiqueta")]
        [Description("Representa los minutos de la etiqueta")]
        private int minutos = 0;
        public int Minutos
        {
            set
            {
                if (value > 59)
                {
                    minutos = 0;
                    this.Refresh();
                }
                else if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    minutos = value;
                    this.Refresh();
                }
            }
            get { return minutos; }
        }

        [Category("Propiedades etiqueta")]
        [Description("Representa los segundos de la etiqueta")]
        private int segundos = 0;
        public int Segundos
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                if (value > 59)
                {
                    if (value % 60 == 0)
                    {
                        OnDesbordaTiempo(this, EventArgs.Empty);
                    }
                    segundos = value % 60;
                }
                else
                {
                    segundos = value;
                }
                this.Refresh();
            }
            get { return segundos; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            lblTiempo.Text = $"{minutos:00}:{segundos:00}";
        }

        public event EventHandler DesbordaTiempo;

        protected virtual void OnDesbordaTiempo(object sender, EventArgs e) // Esto se lanza en la variable segundos, no lo lanza otro método
        {
            if (DesbordaTiempo != null)
            {
                DesbordaTiempo(this, EventArgs.Empty);
            }
        }
    }
}
