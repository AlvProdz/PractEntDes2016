namespace Prueba_GIT
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
            this.CampoHola = new System.Windows.Forms.TextBox();
            this.Boton_DecirHola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CampoHola
            // 
            this.CampoHola.Location = new System.Drawing.Point(26, 41);
            this.CampoHola.Name = "CampoHola";
            this.CampoHola.Size = new System.Drawing.Size(207, 20);
            this.CampoHola.TabIndex = 0;
            this.CampoHola.TextChanged += new System.EventHandler(this.CampoHola_TextChanged);
            // 
            // Boton_DecirHola
            // 
            this.Boton_DecirHola.Location = new System.Drawing.Point(321, 37);
            this.Boton_DecirHola.Name = "Boton_DecirHola";
            this.Boton_DecirHola.Size = new System.Drawing.Size(75, 23);
            this.Boton_DecirHola.TabIndex = 1;
            this.Boton_DecirHola.Text = "Decir Hola";
            this.Boton_DecirHola.UseVisualStyleBackColor = true;
            this.Boton_DecirHola.Click += new System.EventHandler(this.Boton_DecirHola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 236);
            this.Controls.Add(this.Boton_DecirHola);
            this.Controls.Add(this.CampoHola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CampoHola;
        private System.Windows.Forms.Button Boton_DecirHola;
    }
}

