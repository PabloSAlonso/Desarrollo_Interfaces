using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FormPrincipal : Form
    {
        int segundos;
        int minutos;
        string nombreArchivo;

        public FormPrincipal()
        {
            InitializeComponent();
            this.Text = "Visor de imagenes 00:00";
            timer1.Start();
        }

        private void btnImagenNueva_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "png (*.png) | *.png | jpg (*.jpg) | *.jpg";
            string seleccionDialog = "";
            DialogResult openFile = ofd.ShowDialog();
            if (openFile == DialogResult.OK)
            {
                seleccionDialog = ofd.FileName;
                nombreArchivo = Path.GetFileName(seleccionDialog);
            }
            try
            {
                FormSecundario secundario = new FormSecundario();
                secundario.Text = nombreArchivo;
                secundario.asignarImagen(seleccionDialog);
            }
            catch (IOException) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
            this.Text = $"Visor de imágenes {minutos:D2}:{segundos:D2}";
        }

        private void chBoxModal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBoxModal_CheckStateChanged(object sender, EventArgs e)
        {
            if (chBoxModal.Checked)
            {
                chBoxModal.ForeColor = Color.Red;
            }
            else
            {
                chBoxModal.ForeColor = Color.Black;
            }
        }
    }
}
