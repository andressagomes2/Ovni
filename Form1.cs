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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Activated(object sender, EventArgs e)
        {
            Inicializador janela = new Inicializador();
            janela.ShowDialog();
            Application.Exit();
        }
    }
}
