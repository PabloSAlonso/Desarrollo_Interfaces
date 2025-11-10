namespace Ejercicio3
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnImagenNueva = new System.Windows.Forms.Button();
            this.chBoxModal = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnImagenNueva
            // 
            this.btnImagenNueva.Location = new System.Drawing.Point(73, 60);
            this.btnImagenNueva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImagenNueva.Name = "btnImagenNueva";
            this.btnImagenNueva.Size = new System.Drawing.Size(116, 35);
            this.btnImagenNueva.TabIndex = 0;
            this.btnImagenNueva.Text = "Nueva Imagen";
            this.btnImagenNueva.UseVisualStyleBackColor = true;
            this.btnImagenNueva.Click += new System.EventHandler(this.btnImagenNueva_Click);
            // 
            // chBoxModal
            // 
            this.chBoxModal.AutoSize = true;
            this.chBoxModal.Location = new System.Drawing.Point(207, 70);
            this.chBoxModal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBoxModal.Name = "chBoxModal";
            this.chBoxModal.Size = new System.Drawing.Size(55, 17);
            this.chBoxModal.TabIndex = 1;
            this.chBoxModal.Text = "Modal";
            this.chBoxModal.UseVisualStyleBackColor = true;
            this.chBoxModal.CheckedChanged += new System.EventHandler(this.chBoxModal_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.chBoxModal);
            this.Controls.Add(this.btnImagenNueva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "Visor de Imagenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagenNueva;
        private System.Windows.Forms.CheckBox chBoxModal;
        private System.Windows.Forms.Timer timer1;
    }
}

