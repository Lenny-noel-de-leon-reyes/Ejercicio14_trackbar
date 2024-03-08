using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9_trackbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trk_tamaño_Scroll(object sender, EventArgs e)
        {
            int Valor;
            Valor = trk_tamaño.Value;

            lblTamaño.Font = new Font(lblTamaño.Font.FontFamily, Valor);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
