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
            this.multiMediaReproductor1 = new LabelTextBox.MultiMediaReproductor();
            this.SuspendLayout();
            // 
            // multiMediaReproductor1
            // 
            this.multiMediaReproductor1.Location = new System.Drawing.Point(12, 29);
            this.multiMediaReproductor1.Name = "multiMediaReproductor1";
            this.multiMediaReproductor1.Size = new System.Drawing.Size(268, 190);
            this.multiMediaReproductor1.TabIndex = 0;
            // 
            // PruebaReproductorMultimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multiMediaReproductor1);
            this.Name = "PruebaReproductorMultimedia";
            this.Text = "PruebaReproductorMultimedia";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextBox.MultiMediaReproductor multiMediaReproductor1;
    }
}