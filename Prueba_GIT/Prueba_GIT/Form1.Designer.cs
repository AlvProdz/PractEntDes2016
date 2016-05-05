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
            this.CampoQuetal = new System.Windows.Forms.TextBox();
            this.Campo1 = new System.Windows.Forms.TextBox();
            this.Campo2 = new System.Windows.Forms.TextBox();
            this.CampoResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // CampoQuetal
            // 
            this.CampoQuetal.Location = new System.Drawing.Point(26, 81);
            this.CampoQuetal.Name = "CampoQuetal";
            this.CampoQuetal.Size = new System.Drawing.Size(207, 20);
            this.CampoQuetal.TabIndex = 2;
            // 
            // Campo1
            // 
            this.Campo1.Location = new System.Drawing.Point(26, 148);
            this.Campo1.Name = "Campo1";
            this.Campo1.Size = new System.Drawing.Size(100, 20);
            this.Campo1.TabIndex = 3;
            // 
            // Campo2
            // 
            this.Campo2.Location = new System.Drawing.Point(168, 147);
            this.Campo2.Name = "Campo2";
            this.Campo2.Size = new System.Drawing.Size(100, 20);
            this.Campo2.TabIndex = 4;
            // 
            // CampoResult
            // 
            this.CampoResult.Location = new System.Drawing.Point(379, 147);
            this.CampoResult.Name = "CampoResult";
            this.CampoResult.Size = new System.Drawing.Size(100, 20);
            this.CampoResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado:";
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(26, 190);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 7;
            this.Suma.Text = "Sumar";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(107, 190);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 23);
            this.Resta.TabIndex = 8;
            this.Resta.Text = "Restar";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Multiplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CampoResult);
            this.Controls.Add(this.Campo2);
            this.Controls.Add(this.Campo1);
            this.Controls.Add(this.CampoQuetal);
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
        private System.Windows.Forms.TextBox CampoQuetal;
        private System.Windows.Forms.TextBox Campo1;
        private System.Windows.Forms.TextBox Campo2;
        private System.Windows.Forms.TextBox CampoResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button button1;
    }
}

