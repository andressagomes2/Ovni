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
    public partial class Gerenciador : Form
    {
        BibliotecaOVNI.OVNI ovni;
        public Gerenciador(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();

            this.ovni = ovni ;
            AtualizarInterface();

           
        }

        private void AtualizarInterface()
        {
            grbtrip.Visible = ovni.Situacao;
            grbpla.Visible = ovni.Situacao;
            grbestatic.Visible = ovni.Situacao;
            grbabdu.Visible = ovni.Situacao;

            btnDesligar.Visible = ovni.Situacao;
            btnligar.Visible = !ovni.Situacao;

            lblgentrip.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblgenpla.Text = "Planeta Atual: " + ovni.PlanetaAtual;
            lblgenabdu.Text = "Abduzidos: " + ovni.QtdAbduzidos;


        }


        private void btnligar_Click(object sender, EventArgs e)
        {
            ovni.Ligar();
            AtualizarInterface();

        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            ovni.Desligar();
            AtualizarInterface();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(!ovni.AdicionarTripulante())
            {
                MessageBox.Show("Número maximo atingido!", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInterface();
        }

        private void btnaddabdu_Click(object sender, EventArgs e)
        {
            if (!ovni.Abduzir())
            {
                MessageBox.Show("Número maximo atingido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInterface();

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (!ovni.RemoverTripulante())
            {
                MessageBox.Show("Erro");
            }
            AtualizarInterface();
        }
       

        private void btnremoveab_Click(object sender, EventArgs e)
        {
            if (!ovni.Desabduzir())
            {
                MessageBox.Show( "Erro");
            }
            AtualizarInterface();
           
        }

        private void cmbpla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ovni.RetornarAoPlanetaDeOrigem())
            {
                MessageBox.Show("Erro");
            }
            AtualizarInterface();
        }

        private void cmbpla_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!ovni.MudarPlaneta(cmbpla.Text))
            {
                MessageBox.Show( "Erro");
            }
            AtualizarInterface();
        }
    }

    
}
