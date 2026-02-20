namespace PruebasComponentes
{
    partial class PruebaValidateTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PruebaValidateTextBox));
            this.validateTextBox1 = new LabelTextBox.ValidateTextBox(this.components);
            this.SuspendLayout();
            // 
            // validateTextBox1
            // 
            this.validateTextBox1.Location = new System.Drawing.Point(13, 13);
            this.validateTextBox1.Multilinea = false;
            this.validateTextBox1.Name = "validateTextBox1";
            this.validateTextBox1.Size = new System.Drawing.Size(628, 40);
            this.validateTextBox1.TabIndex = 0;
            this.validateTextBox1.Texto = "22";
            this.validateTextBox1.Tipo = LabelTextBox.ValidateTextBox.eTipo.Textual;
            // 
            // PruebaValidateTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validateTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PruebaValidateTextBox";
            this.Text = "PruebaValidateTextBox";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextBox.ValidateTextBox validateTextBox1;
    }
}