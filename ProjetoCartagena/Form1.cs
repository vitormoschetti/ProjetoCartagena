using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CartagenaServer;

namespace ProjetoCartagena
{
    public partial class Form1 : Form
    {
        List<Partida> partidas;
        List<Jogador> Jogadores;
        public Form1()
        {
            InitializeComponent();
            inicializar();
            partidas = new List<Partida>();
            Jogadores = new List<Jogador>();
        }

        private void inicializar()
        {
            lblVersao.Text = "Versao " + Jogo.Versao;
            cboListarPartidas.SelectedIndex = 0;
            cboSimbolo.SelectedIndex = 0;
        }

        private void cboListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cboListarPartidas.SelectedItem.ToString().Substring(0, 1);
            string retornoPartidas = Jogo.ListarPartidas(status);
            retornoPartidas = retornoPartidas.Replace("\n", "");
            string[] jogos = retornoPartidas.Split('\r');
            lstPartidas.Items.Clear();
            Partida partida = new Partida();
            foreach (string jogo in jogos)
            {
                lstPartidas.Items.Add(jogo);
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);

        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            try
            {
                lstHistoricoPartida.Items.Clear();
                lstHistoricoPartida.Items.Add(Jogo.ExibirHistorico(Convert.ToInt32(txtIdPartida.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID partida", "ERRO");
            }
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            try
            {
                string retornoJogadores = Jogo.ListarJogadores(Convert.ToInt32(txtIdPartida.Text));
                retornoJogadores = retornoJogadores.Replace("\n", "");
                string[] jogadores = retornoJogadores.Split('\r');
                lstJogadores.Items.Clear();
                foreach (string jogador in jogadores)
                {
                    lstJogadores.Items.Add(jogador);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID partida", "ERRO");
            }
            
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            try {
                string dadosDoJogador = Jogo.EntrarPartida(Convert.ToInt32(txtIdPartida.Text), txtNomeJogador.Text, txtSenhaPartida.Text);
                string[] valores = dadosDoJogador.Split(',');

                txtIdJogador.Text = valores[0];
                txtSenhaJogador.Text = valores[1];
                txtCorJogador.Text = valores[2];
            } catch(FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID partida, Nome do Jogador e Senha partida", "ERRO");
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Jogo.IniciarPartida(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
        }
        private void btnJogarFrente_Click(object sender, EventArgs e)
        {
            try
            {
                Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtPosicao.Text), cboSimbolo.Text.Substring(0, 1));
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID jogador, Senha Jogador, Simbolo e Posicao", "ERRO");
            }
        }

        private void btnJogarTras_Click(object sender, EventArgs e)
        {
            try
            {
                Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtPosicao.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID jogador, Senha Jogador e Posicao", "ERRO");
            }
        }

        private void btnPularJogador_Click(object sender, EventArgs e)
        {
            try
            {
                Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID jogador e Senha", "ERRO");
            }
            
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
            try
            {
                string mao = Jogo.ConsultarMao(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
                mao = mao.Replace("\n", "");
                string[] cartas = mao.Split('\r');
                lstMaoJogador.Items.Clear();
                foreach (string carta in cartas)
                {
                    string[] linha = carta.Split(',');
                    if (linha.Length > 1)
                    {
                        linha[0] = editarNome(linha[0]);
                        lstMaoJogador.Items.Add("Voce tem " + linha[1] + " cartas de " + linha[0]);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID jogador e Senha", "ERRO");
            }
            
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {

            try
            {
                string verificaVez = Jogo.VerificarVez(Convert.ToInt32(txtIdPartida.Text));
                MessageBox.Show(verificaVez);
                verificaVez = verificaVez.Replace("\n", "");
                string[] posicoes = verificaVez.Split('\r');
                lstVerificarVez.Items.Clear();
                for (int i = 0; i < posicoes.Length; i++)
                {
                    string[] linha = posicoes[i].Split(',');
                    if (i < posicoes.Length - 1)
                    {

                        ListViewItem listView = new ListViewItem(linha);
                        lstVerificarVez.Items.Add(listView);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID da partida", "ERRO");
            }
           
        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            try
            {
                string tabuleiro = Jogo.ExibirTabuleiro(Convert.ToInt32(txtIdPartida.Text));
                MessageBox.Show(tabuleiro);
                tabuleiro = tabuleiro.Replace("\n", "");
                string[] posicoes = tabuleiro.Split('\r');
                lstTabuleiro.Items.Clear();
                for (int i = 0; i < posicoes.Length; i++)
                {
                    string[] linha = posicoes[i].Split(',');
                    if (i > 0 && i < posicoes.Length - 1)
                    {
                        linha[1] = editarNome("" + linha[1]);
                    }
                    ListViewItem listView = new ListViewItem(linha);
                    lstTabuleiro.Items.Add(listView);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID da partida", "ERRO");
            }
            
        }
    

        private string editarNome(string v)
        {
            if (v.Equals("F"))
            {
                return v.Replace("F", "Faca");
            }
            if (v.Equals("E"))
            {
                return v.Replace("E", "Esqueleto");
            }
            if (v.Equals("C"))
            {
                return v.Replace("C", "Chave");
            }
            if (v.Equals("P"))
            {
                return v.Replace("P", "Pistola");
            }
            if (v.Equals("T"))
            {
                return v.Replace("T", "Tricornio");
            }
            if (v.Equals("G"))
            {
                return v.Replace("G", "Garrafa");
            }

            return "";
        }
    }
}