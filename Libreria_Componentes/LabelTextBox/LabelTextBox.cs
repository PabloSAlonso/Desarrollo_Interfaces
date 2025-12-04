using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTextBox
{
    public enum EPosicion
    {
        IZQUIERDA, DERECHA
    }
    [DefaultProperty("TextLbl"), DefaultEvent("Load")]
    public partial class LabelTextBox : UserControl
    {

        public LabelTextBox()
        {
            InitializeComponent();
        }

        private EPosicion posicion = EPosicion.IZQUIERDA;
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public EPosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
                    OnPosicionChanged(EventArgs.Empty);
                    Refresh();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Design")] // O se puede meter en categoría Design.
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    OnSeparacionChanged(EventArgs.Empty);
                    Refresh();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Mis Propiedades")] // O se puede meter en categoría Appearance.
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set { lbl.Text = value; }
            get { return lbl.Text; }
        }

        [Category("Mis Propiedades")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
                OnTxtTextChanged(EventArgs.Empty);
            }
            get
            {
                return txt.Text;
            }
        }
        [Category("Mis Propiedades")]
        [Description("Caracter asociado al PasswordChar del textbox")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
                //OnTxtPasswordCharChanged(EventArgs.Empty); No lo pide
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        private void Recolocar()
        {
            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(0, 0);
                    // Establecemos posición componente txt
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //Establecemos ancho del Textbox
                    //(la label tiene ancho por autosize)
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = lbl.Width + txt.Width + separacion;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case EPosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Width = lbl.Width + txt.Width + separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Recolocar();
            e.Graphics.DrawLine(new Pen(Color.Violet), //Subrayamos el texto de la etiqueta
            lbl.Left, this.Height - 1,
            lbl.Left + lbl.Width, this.Height - 1);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e); //Enlazar Formulario con texto del TextBox del LabelTextBox
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler PosicionChanged;
        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler SeparacionChanged;
        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            if (SeparacionChanged != null)
            {
                SeparacionChanged(this, e);
            }
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad text del textbox cambia")]
        public event System.EventHandler TxtTextChanged;
        protected virtual void OnTxtTextChanged(EventArgs e)
        {
            if (TxtTextChanged != null)
            {
                TxtTextChanged(this, e);
            }
        }

        //[Category("La propiedad cambió")] No lo pide
        //[Description("Se lanza cuando la propiedad passwordchar del textbox cambia")]
        //public event System.EventHandler TxtPasswordChar;
        //protected virtual void OnTxtPasswordCharChanged(EventArgs e)
        //{
        //    if (TxtPasswordChar != null)
        //    {
        //        TxtPasswordChar(this, e);
        //    }
        //}

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            OnTxtTextChanged(e);
        }

        private void lbl_SizeChanged(object sender, EventArgs e)
        {
            Recolocar();
        }
    }
}
