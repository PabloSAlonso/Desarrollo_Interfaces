using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Examen
{
    public partial class FormDatos : Form
    {
        Color colorDefault;
        public FormDatos()
        {
            InitializeComponent();
            colorDefault = btnAceptar.BackColor;
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            CboEdad.Items.Clear();
            for (int i = 18; i < 101; i++)
            {
                CboEdad.Items.Add(i);
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                ((Button)sender).BackColor = Color.Blue;
                this.Cursor = Cursors.Hand; //cambia el raton a una mano si entra
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                ((Button)sender).BackColor = colorDefault;
                this.Cursor = Cursors.Default; //al salir del boton vuelve normal
            }
        }
    }
}
