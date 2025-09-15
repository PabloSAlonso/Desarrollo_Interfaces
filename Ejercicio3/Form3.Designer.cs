namespace Ejercicio3
{
    partial class Form3
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblPremio = new System.Windows.Forms.Label();
            this.btnCredito = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.numSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(264, 54);
            this.num1.Name = "num1";
            this.num1.ReadOnly = true;
            this.num1.Size = new System.Drawing.Size(48, 20);
            this.num1.TabIndex = 0;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(183, 54);
            this.num3.Name = "num3";
            this.num3.ReadOnly = true;
            this.num3.Size = new System.Drawing.Size(48, 20);
            this.num3.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(103, 54);
            this.num2.Name = "num2";
            this.num2.ReadOnly = true;
            this.num2.Size = new System.Drawing.Size(48, 20);
            this.num2.TabIndex = 2;
            this.num2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(157, 134);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(100, 23);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "JUGAR!";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Location = new System.Drawing.Point(130, 100);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(160, 13);
            this.lblPremio.TabIndex = 4;
            this.lblPremio.Text = "Juega para conocer tu resultado";
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(455, 134);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(75, 23);
            this.btnCredito.TabIndex = 5;
            this.btnCredito.Text = "Crédito + 10";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(435, 60);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(95, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Credito Disponible:";
            // 
            // numSaldo
            // 
            this.numSaldo.AutoSize = true;
            this.numSaldo.Location = new System.Drawing.Point(537, 60);
            this.numSaldo.Name = "numSaldo";
            this.numSaldo.Size = new System.Drawing.Size(19, 13);
            this.numSaldo.TabIndex = 7;
            this.numSaldo.Text = "50";
            this.numSaldo.Click += new System.EventHandler(this.numSaldo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.lblPremio);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num1);
            this.Name = "Form3";
            this.Text = "Tragaperra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label numSaldo;
    }
}

