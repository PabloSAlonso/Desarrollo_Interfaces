namespace Ejercicio3
{
    partial class FormSecundario
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
            this.components = new System.ComponentModel.Container();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.menuOpcionesImagen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajusteImagen = new System.Windows.Forms.ToolStripMenuItem();
            this.perfectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.menuOpcionesImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(303, 83);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(100, 50);
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // menuOpcionesImagen
            // 
            this.menuOpcionesImagen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOpcionesImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajusteImagen});
            this.menuOpcionesImagen.Name = "menuOpcionesImagen";
            this.menuOpcionesImagen.Size = new System.Drawing.Size(211, 56);
            // 
            // ajusteImagen
            // 
            this.ajusteImagen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfectoToolStripMenuItem,
            this.deformaciónToolStripMenuItem});
            this.ajusteImagen.Name = "ajusteImagen";
            this.ajusteImagen.Size = new System.Drawing.Size(210, 24);
            this.ajusteImagen.Text = "Ajuste Imagen";
            // 
            // perfectoToolStripMenuItem
            // 
            this.perfectoToolStripMenuItem.Name = "perfectoToolStripMenuItem";
            this.perfectoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.perfectoToolStripMenuItem.Text = "Perfecto";
            this.perfectoToolStripMenuItem.Click += new System.EventHandler(this.perfectoToolStripMenuItem_Click);
            // 
            // deformaciónToolStripMenuItem
            // 
            this.deformaciónToolStripMenuItem.Name = "deformaciónToolStripMenuItem";
            this.deformaciónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deformaciónToolStripMenuItem.Text = "Deformación";
            this.deformaciónToolStripMenuItem.Click += new System.EventHandler(this.deformaciónToolStripMenuItem_Click);
            // 
            // FormSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImagen);
            this.Name = "FormSecundario";
            this.Text = "Formulario Imagen Secundario";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.menuOpcionesImagen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.ContextMenuStrip menuOpcionesImagen;
        private System.Windows.Forms.ToolStripMenuItem ajusteImagen;
        private System.Windows.Forms.ToolStripMenuItem perfectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deformaciónToolStripMenuItem;
    }
}