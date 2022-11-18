using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovni
{
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
            cmbpla.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            string planetaOrigem = cmbpla.Text;
            int maxTripulantes = (int)txbtrip.Value;
            int maxAbduzidos = (int)txbabdu.Value;

            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes,
                maxAbduzidos, planetaOrigem);

            Gerenciador gerenciador = new Gerenciador(ovni);
            gerenciador.ShowDialog();


        }
    }
}
