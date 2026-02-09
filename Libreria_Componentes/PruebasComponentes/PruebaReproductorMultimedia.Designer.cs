namespace PruebasComponentes
{
    partial class PruebaReproductorMultimedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PruebaReproductorMultimedia));
            this.btnSelección = new System.Windows.Forms.Button();
            this.cbSegundos = new System.Windows.Forms.ComboBox();
            this.gbImagenes = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.multiMediaReproductor1 = new LabelTextBox.MultiMediaReproductor();
            this.SuspendLayout();
            // 
            // btnSelección
            // 
            this.btnSelección.Location = new System.Drawing.Point(12, 109);
            this.btnSelección.Name = "btnSelección";
            this.btnSelección.Size = new System.Drawing.Size(216, 59);
            this.btnSelección.TabIndex = 1;
            this.btnSelección.Text = "Selecciona un directorio";
            this.btnSelección.UseVisualStyleBackColor = true;
            this.btnSelección.Click += new System.EventHandler(this.btnSelección_Click);
            // 
            // cbSegundos
            // 
            this.cbSegundos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSegundos.FormattingEnabled = true;
            this.cbSegundos.Location = new System.Drawing.Point(12, 174);
            this.cbSegundos.MaxLength = 2;
            this.cbSegundos.Name = "cbSegundos";
            this.cbSegundos.Size = new System.Drawing.Size(216, 21);
            this.cbSegundos.TabIndex = 2;
            this.cbSegundos.SelectedIndexChanged += new System.EventHandler(this.cbSegundos_SelectedIndexChanged);
            // 
            // gbImagenes
            // 
            this.gbImagenes.Location = new System.Drawing.Point(286, 29);
            this.gbImagenes.Name = "gbImagenes";
            this.gbImagenes.Size = new System.Drawing.Size(218, 232);
            this.gbImagenes.TabIndex = 3;
            this.gbImagenes.TabStop = false;
            this.gbImagenes.Text = "Imágenes";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // multiMediaReproductor1
            // 
            this.multiMediaReproductor1.Location = new System.Drawing.Point(12, 29);
            this.multiMediaReproductor1.Minutos = 0;
            this.multiMediaReproductor1.Name = "multiMediaReproductor1";
            this.multiMediaReproductor1.Segundos = 0;
            this.multiMediaReproductor1.Size = new System.Drawing.Size(268, 190);
            this.multiMediaReproductor1.TabIndex = 0;
            this.multiMediaReproductor1.PlayClick += new System.EventHandler(this.multiMediaReproductor1_PlayClick);
            // 
            // PruebaReproductorMultimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 283);
            this.Controls.Add(this.gbImagenes);
            this.Controls.Add(this.cbSegundos);
            this.Controls.Add(this.btnSelección);
            this.Controls.Add(this.multiMediaReproductor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PruebaReproductorMultimedia";
            this.Text = "PruebaReproductorMultimedia";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextBox.MultiMediaReproductor multiMediaReproductor1;
        private System.Windows.Forms.Button btnSelección;
        private System.Windows.Forms.ComboBox cbSegundos;
        private System.Windows.Forms.GroupBox gbImagenes;
        private System.Windows.Forms.Timer timer;
    }
}