using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasComponentes
{
    public partial class Formulario_LabelTextBox : Form
    {
        static bool flagSeparacion = true;
        public Formulario_LabelTextBox()
        {
            InitializeComponent();
        }

        private void labelTextBox1_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("estoy en el paint del txtbox");
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == LabelTextBox.EPosicion.DERECHA)
            {
                labelTextBox1.Posicion = LabelTextBox.EPosicion.IZQUIERDA;
            }
            else
            {
                labelTextBox1.Posicion = LabelTextBox.EPosicion.DERECHA;
            }
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }

        private void btnSeparacionMas_Click(object sender, EventArgs e)
        {
            flagSeparacion = true;
            labelTextBox1.Separacion += 5;
        }

        private void btnSeparacionMenos_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Separacion >= 5)
            {
                flagSeparacion = false;
                labelTextBox1.Separacion -= 5;
            }
        }

        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            if (flagSeparacion)
            {
                this.Text = "La separacion aumentó";
            }
            else
            {
                this.Text = "La separación disminuyó";
            }
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            labelTextBox1.TextLbl = "Tecla:" + e.KeyValue.ToString();
        }

        private void labelTextBox1_TxtTextChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.TextTxt.ToString();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            labelTextBox1.TextLbl = "Prueba de si va bien el ancho del componente";
        }
    }
}
