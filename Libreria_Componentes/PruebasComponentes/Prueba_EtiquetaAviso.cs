using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasComponentes
{
    public partial class Prueba_EtiquetaAviso : Form
    {
        public Prueba_EtiquetaAviso()
        {
            InitializeComponent();
        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
            MessageBox.Show("funcion realizada con exito", "prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
