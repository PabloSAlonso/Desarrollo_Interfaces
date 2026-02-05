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
        }

        int segundosPorFoto = 0;
        private void cbSegundos_SelectedIndexChanged(object sender, EventArgs e)
        {
            segundosPorFoto = int.Parse(cbSegundos.SelectedItem.ToString());
        }

        int segundos = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            multiMediaReproductor1.Segundos = segundos;
            if (flagReproductor && segundosPorFoto % segundos == 0)
            {
                foreach (FileInfo foto in fotos)
                {
                    gbImagenes.BackgroundImage = Image.FromFile(path + "\\" + foto.Name);
                }
            }
        }
        bool flagReproductor = false;
        private void multiMediaReproductor1_PlayClick(object sender, EventArgs e)
        {
            flagReproductor = !flagReproductor;
        }
    }
}
