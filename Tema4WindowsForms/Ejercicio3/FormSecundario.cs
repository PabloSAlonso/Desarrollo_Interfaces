using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FormSecundario : Form
    {
        public FormSecundario()
        {
            InitializeComponent();
            
        }
        public void asignarImagen(string direccion)
        {
            pbImagen.Image = Image.FromFile(direccion);
        }

        private void perfectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void deformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        
    }
}
