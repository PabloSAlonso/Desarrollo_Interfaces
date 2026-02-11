using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasComponentes//Icono. Inicio de valor en combo. Excep genérica no. DONE
                            //Preprocesar directorio(im, g corrupta y archivos no imag). 
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
            }
            cbSegundos.SelectedItem = 1;
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
            try
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
            catch (ArgumentException)
            {
                MessageBox.Show("Debes seleccionar un directorio", "Has cancelado la selección de directorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        private bool EsImagenValida(int i)
        {
            string ext = fotos[i].Extension.ToLower();
            return (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp");
        }


        private void CambiarFoto()
        {
            if (fotos != null && fotos.Length > 0)
            {
                int intentos = 0;
                while (intentos < fotos.Length)
                {
                    if (EsImagenValida(indice))
                    {
                        gbImagenes.BackgroundImage =
                            Image.FromFile(fotos[indice].FullName);

                        indice++;
                        if (indice >= fotos.Length)
                        {
                            indice = 0;
                        }
                        intentos = fotos.Length; //forzar salida de while
                    }
                    if (intentos < fotos.Length) //si no se forzó la salida y no hay solo archivos válidos se ejecuta lo siguiente cuando la imagen no es válida
                    {

                        indice++;
                        if (indice >= fotos.Length)
                        {
                            indice = 0;
                        }
                    }
                    intentos++;
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
