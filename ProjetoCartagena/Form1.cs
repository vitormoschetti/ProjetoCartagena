using System;
using System.Windows.Forms;

namespace ProjetoCartagena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            lblVersao.Text = "Versao " + CartagenaServer.Jogo.Versao;
            cboListarPartidas.SelectedIndex = 0;
            cboSimbolo.SelectedIndex = 0;
        }

        private void cboListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cboListarPartidas.SelectedText.ToString();
            Console.Write(status);

         //   status = status.Substring(0, 1);
            string jogadore = CartagenaServer.Jogo.ListarPartidas(status);
            Console.Write(status);
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {

        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

        }

        private void btnJogarFrente_Click(object sender, EventArgs e)
        {

        }

        private void btnJogarTras_Click(object sender, EventArgs e)
        {

        }

        private void btnPularJogador_Click(object sender, EventArgs e)
        {

        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {

        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {

        }
    }
}
