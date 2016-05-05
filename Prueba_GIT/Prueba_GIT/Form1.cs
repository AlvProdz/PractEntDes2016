using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CampoHola_TextChanged(object sender, EventArgs e)
        {

        }

        private void Boton_DecirHola_Click(object sender, EventArgs e)
        {
            CampoHola.Text = "Hola Mundo";
            CampoQuetal.Text = "¿Qué tal estás?";
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            int suma = 0;

            suma = Convert.ToInt32(Campo1.Text) + Convert.ToInt32(Campo2.Text);

            CampoResult.Text = Convert.ToString(suma);
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            int resta = 0;

            resta = Convert.ToInt32(Campo1.Text) - Convert.ToInt32(Campo2.Text);

            CampoResult.Text = Convert.ToString(resta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int multiplicacion = 0;

            multiplicacion = Convert.ToInt32(Campo1.Text) * Convert.ToInt32(Campo2.Text);

            CampoResult.Text = Convert.ToString(multiplicacion);
        }
    }
}
