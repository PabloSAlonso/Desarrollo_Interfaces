namespace PruebasComponentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelTextBox1 = new LabelTextBox.LabelTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(237, 85);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.Separacion = 60;
            this.labelTextBox1.Size = new System.Drawing.Size(295, 20);
            this.labelTextBox1.TabIndex = 2;
            this.labelTextBox1.TextLbl = "label1";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.labelTextBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Pruebas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private LabelTextBox.LabelTextBox labelTextBox1;
    }
}

