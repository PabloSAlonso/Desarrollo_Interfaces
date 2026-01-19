namespace PruebasComponentes
{
    partial class Prueba_EtiquetaAviso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etiquetaAviso1 = new LabelTextBox.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorFinalGradiente = System.Drawing.Color.Lime;
            this.etiquetaAviso1.ColorInicioGradiente = System.Drawing.Color.OrangeRed;
            this.etiquetaAviso1.FondoGradiente = true;
            this.etiquetaAviso1.ImagenMarca = null;
            this.etiquetaAviso1.Location = new System.Drawing.Point(91, 53);
            this.etiquetaAviso1.Marca = LabelTextBox.EMarca.Cruz;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(97, 15);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            // 
            // Prueba_EtiquetaAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso1);
            this.Name = "Prueba_EtiquetaAviso";
            this.Text = "Prueba_EtiquetaAviso";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextBox.EtiquetaAviso etiquetaAviso1;
    }
}