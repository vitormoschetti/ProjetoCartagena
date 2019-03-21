using System;
using System.Windows.Forms;
using CartagenaServer;

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
            lblVersao.Text = "Versao " + Jogo.Versao;
            cboListarPartidas.SelectedIndex = 0;
            cboSimbolo.SelectedIndex = 0;
        }

        private void cboListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPartidas.Items.Clear();
            string status = cboListarPartidas.SelectedItem.ToString().Substring(0,1);
            string retornoPartidas = Jogo.ListarPartidas(status);
            retornoPartidas = retornoPartidas.Replace("\n", "");
            string[] partidas = retornoPartidas.Split('\r');
            foreach(string partida in partidas){
                lstPartidas.Items.Add(partida);
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
            
        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            lstJogadores.Items.Clear();
            string retornoJogadores = Jogo.ListarJogadores(Convert.ToInt32(txtIdPartida.Text));
            retornoJogadores = retornoJogadores.Replace("\n", "");
            string[] jogadores = retornoJogadores.Split('\r');
            foreach(string jogador in jogadores) {
                lstJogadores.Items.Add(jogador);
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string dadosDoJogador = Jogo.EntrarPartida(Convert.ToInt32(txtIdPartida.Text), txtNomeJogador.Text, txtSenhaPartida.Text);
            string[] valores = dadosDoJogador.Split(',');

            txtIdJogador.Text = valores[0];
            txtSenhaJogador.Text = valores[1];
            txtCorJogador.Text = valores[2];
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            txtIdPartida.Text = Jogo.IniciarPartida(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
   
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
