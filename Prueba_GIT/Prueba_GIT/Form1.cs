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
        }
    }
}
