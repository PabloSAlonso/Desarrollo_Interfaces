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
        string formato;
        public MultiMediaReproductor()
        {
            InitializeComponent();
            formato = $"{Minutos:00}:{Segundos:00}";
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
                if (minutos > 59)
                {
                    minutos = 0;
                    this.Refresh();
                }
                else if (minutos < 0)
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
                if (segundos > 59)
                {
                    if (segundos != 0 && segundos % 60 == 0)
                    {
                        OnDesbordaTiempo(this, EventArgs.Empty);
                    }
                    segundos = value % 60;
                    this.Refresh();
                }
                else if (segundos < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    segundos = value;
                    this.Refresh();
                }
            }
            get { return segundos; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            lblTiempo.Text = formato;
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
