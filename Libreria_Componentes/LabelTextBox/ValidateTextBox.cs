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
    public partial class ValidateTextBox : UserControl
    {
        public enum ETipo
        {
            Numerico,
            Textual
        }
        public ValidateTextBox()
        {
            InitializeComponent();
        }
        private ETipo tipo = ETipo.Numerico;
        [Category("Mis propiedades")]
        [Description("tipo del enumerado")]
        public ETipo Tipo
        {
            set
            {
                tipo = value;
            }
            get
            {
                return tipo;
            }
        }


        [Category("Mis propiedades")]
        [Description("Texto asociado al textbox del control")]
        public String Texto
        {
            set
            {
                txt.Text = value;
                Refresh();
            }
            get
            {
                return txt.Text;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Propiedad asociada al multiLine del textbox del componente")]
        public bool MultiLine
        {
            set
            {
                txt.Multiline = value;
                Refresh();
            }
            get
            {
                return txt.Multiline;
            }
        }

        public void ajustarAnchoAlto()
        {
            Height = txt.Height + 20;
            txt.Width = Width - 20;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ajustarAnchoAlto();
        }
    }
}
