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

namespace PruebasComponentes
{
    public partial class PruebaReproductorMultimedia : Form
    {
        public PruebaReproductorMultimedia()
        {
            InitializeComponent();
            for (int i = 1; i < 21; i++)
            {
                cbSegundos.Items.Add(i);
            }
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

            }
            catch (Exception)
            {
                Console.WriteLine("Error con el directorio");
            }
            indice = 0;

        }

        int segundosPorFoto = 0;
        private void cbSegundos_SelectedIndexChanged(object sender, EventArgs e)
        {
            segundosPorFoto = int.Parse(cbSegundos.SelectedItem.ToString());
        }

        int segundosTotales = 0;
        int indice = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            segundosTotales++;
            multiMediaReproductor1.Segundos++;

            if (segundosPorFoto >= segundosTotales)
            {
                segundosPorFoto = 0; //Reiniciamos segundos de imagen
                // cambiar la foto
            }
        }

        private void CambiarFoto()
        {
            if (fotos == null || fotos.Length == 0)
            {
                MessageBox.Show("Problemas con el directorio", "DIRECTORIO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
        private void multiMediaReproductor1_PlayClick(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
            else
                timer.Start();
        }
    }
}
