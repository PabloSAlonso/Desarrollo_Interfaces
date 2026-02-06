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

namespace PruebasComponentes//Icono. Preprocesar directorio (im,g corrupta y archivos no imag). Inicio de valor en combo. Excep genérica no.
{
    public partial class PruebaReproductorMultimedia : Form
    {
        public PruebaReproductorMultimedia()
        {
            InitializeComponent();
            multiMediaReproductor1.DesbordaTiempo += multiMediaReproductor1_DesbordaTiempo;
            for (int i = 1; i < 21; i++)
            {
                cbSegundos.Items.Add(i);
                cbSegundos.SelectedItem = 1;
            }
        }

        private void multiMediaReproductor1_DesbordaTiempo(object sender, EventArgs e)
        {
            multiMediaReproductor1.Minutos++;
        }

        String path = "";
        DirectoryInfo d;
        FileInfo[] fotos;

        private void btnSelección_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecciona un directorio con imagenes";
            folderBrowserDialog.ShowDialog();
            path = folderBrowserDialog.SelectedPath;
            d = new DirectoryInfo(path);
            fotos = d.GetFiles();
            indice = 0;
            CambiarFoto();
        }

        int segundosPorFoto = 0;
        private void cbSegundos_SelectedIndexChanged(object sender, EventArgs e)
        {
            segundosPorFoto = int.Parse(cbSegundos.SelectedItem.ToString());
        }

        int segundosImagen = 0;
        int indice = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            multiMediaReproductor1.Segundos++;
            segundosImagen++;

            if (segundosImagen >= segundosPorFoto)
            {
                segundosImagen = 0; //Reiniciamos segundos de tiempo en pantalla de la imagen
                CambiarFoto();
            }
        }

        private void CambiarFoto()
        {
            if (fotos != null && fotos.Length > 0)
            {
                gbImagenes.BackgroundImage = Image.FromFile(fotos[indice].FullName);
                indice++;
                if (indice >= fotos.Length)
                {
                    indice = 0;
                }
            }
        }
        private void multiMediaReproductor1_PlayClick(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }
    }
}
