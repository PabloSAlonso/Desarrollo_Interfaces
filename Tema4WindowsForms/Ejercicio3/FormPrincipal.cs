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
            timer1.Start();
            
        }

        private void btnImagenNueva_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "png (*.png) |*.png| jpg (*.jpg) |*.jpg| Todos los archivos |*.*" ;
            ofd.ValidateNames = true ;
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

                if (chBoxModal.Checked)
                {
                    secundario.ShowDialog();
                }
                else
                {
                    secundario.Show();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error de archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (OutOfMemoryException)
            {
                MessageBox.Show("Error con la imagen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Has salido sin seleccionar imagen", "INFO",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
            this.Text = $"Visor de imagenes - {minutos:D2}:{segundos:D2}";
        }

        private void chBoxModal_CheckedChanged(object sender, EventArgs e)
        {
            {
                CheckBox detectaCheckBox = ((CheckBox)sender);
                if (detectaCheckBox.Checked)
                {
                    detectaCheckBox.ForeColor = Color.Red;
                }
                else
                {
                    detectaCheckBox.ForeColor = Color.Black;
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres salir del formulario?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
