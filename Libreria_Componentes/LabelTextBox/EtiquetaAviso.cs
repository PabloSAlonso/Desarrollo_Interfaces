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
    public enum EMarca
    {
        Nada,
        Cruz,
        Circulo
    }
    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics; //Lienzo del componente
            SolidBrush b = new SolidBrush(this.ForeColor); //Pincel de un solo color sin texturas ni gradientes
            g.DrawString(this.Text, this.Font, b, 0, 0); //Pinta String
            this.Size = g.MeasureString(this.Text, this.Font).ToSize(); //Measure devuelve size en float (sirve para comprobar la longitud de un string), se pasa a size normal con ToSize()

        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
    }
}
