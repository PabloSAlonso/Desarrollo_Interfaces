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
        public event EventHandler PlayClick;
        protected virtual void OnPlayClick(object sender, EventArgs e)
        {
            if (PlayClick != null)
            {
                PlayClick(this, EventArgs.Empty);
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            if (sender == btnReproducir)
            {
                btnReproducir.Text = btnReproducir.Text == "Play" ? "Stop" : "Play";
                OnPlayClick(sender, e);
            }
        }

        [Category("Propiedades etiqueta")]
        [Description("Representa los minutos de la etiqueta")]
        public int Minutos = 0;
        private int minutos
        {
            set
            {
                if (minutos > 59)
                {
                    minutos = 0;
                }
                else
                {
                    minutos = value;
                }
            }
            get { return minutos; }
        }

        [Category("Propiedades etiqueta")]
        [Description("Representa los segundos de la etiqueta")]
        public int Segundos = 0;
        private int segundos
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
                    lblTiempo.Text = formato;
                }
                else
                {
                    segundos = value;
                    lblTiempo.Text = formato;
                }
            }
            get { return segundos; }
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
