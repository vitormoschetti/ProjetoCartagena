using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CartagenaServer;

namespace ProjetoCartagena
{
    public partial class Form1 : Form
    {
        Partida partida;
        Jogador nossoJogador;
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
            partida = new Partida();
        }

        private void cboListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cboListarPartidas.SelectedItem.ToString().Substring(0, 1);
            string retornoPartidas = Jogo.ListarPartidas(status);
            retornoPartidas = retornoPartidas.Replace("\n", "");
            string[] jogos = retornoPartidas.Split('\r');
            lstPartidas.Items.Clear();
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
                string retorno = Jogo.ExibirHistorico(Convert.ToInt32(txtIdPartida.Text));
                retorno = retorno.Replace("\n", "");
                string[] historico = retorno.Split('\r');
                string textoExibido = "";
                for (int i = 0; i < historico.Length - 1; i++)
                {
                    string[] linha = historico[i].Split(',');
                    foreach (Jogador j in partida.jogadores) {
                        if(j.id == Convert.ToInt32(linha[0]))
                        {
                            textoExibido = j.nome + " na sua " + linha[1] + "jagada jogou um " + editarNome(linha[2]) + " e foi da posicao " + linha[3] + " para a " + linha[4];
                        }
                    }    
                    lstHistoricoPartida.Items.Add(textoExibido);
                }
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
                //Ultima linha esta retornando a porra de um espaço em branco, ai tem que fazer essa gambiarra pra funcionar, foda viu
                for (int i = 0; i < jogadores.Length - 1; i++)
                {
                    string[] dadosJogador = jogadores[i].Split(',');
                    Jogador j = new Jogador(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], dadosJogador[2]);
                    partida.jogadores.Add(j);
                    lstJogadores.Items.Add(jogadores[i]);
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
                partida = new Partida(Convert.ToInt32(txtIdPartida.Text), txtNomePartida.Text, txtSenhaPartida.Text);

                txtIdJogador.Text = valores[0];
                txtSenhaJogador.Text = valores[1];
                txtCorJogador.Text = valores[2];
                nossoJogador = new Jogador(Convert.ToInt32(valores[0]), valores[1], valores[2], txtNomeJogador.Text);
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
                verificaVez = verificaVez.Replace("\n", "");
                string[] posicoes = verificaVez.Split('\r');
                lstVerificaVez.Items.Clear();
                //Ultima linha esta retornando a porra de um espaço em branco, ai tem que fazer essa gambiarra pra funcionar, foda viu
                for (int i = 0; i < posicoes.Length - 1; i++)
                {
                    string[] linha = posicoes[i].Split(',');
                    string textoExibido = "";
                    //Verifica se é a primeira linha
                    if (!(posicoes[i].Equals(posicoes[0])))
                    {
                        foreach (Jogador j in partida.jogadores)
                        {
                            if (j.id == Convert.ToInt32(linha[1]))
                            {
                                textoExibido = "O jogador " + j.nome + " tem " + linha[2] + " bonecos na casa " + linha[0];
                            }
                        }
                    } else
                    {
                        foreach (Jogador j in partida.jogadores)
                        {
                            if (j.id == Convert.ToInt32(linha[1])) {
                                textoExibido = "Esta na vez do " + j.nome + " ele esta na " + linha[2] + " jogada";
                            }
                        }

                    }
                    lstVerificaVez.Items.Add(textoExibido);
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
                tabuleiro = tabuleiro.Replace("\n", "");
                string[] posicoes = tabuleiro.Split('\r');
                lstExibeTabuleiro.Items.Clear();
                string textoExibido = "";
                for (int i = 1; i < posicoes.Length - 2; i++)
                {
                    string[] linha = posicoes[i].Split(',');
                    textoExibido = "Na posiçao " + linha[0] + " temos um(a) " + editarNome(linha[1]);
                    lstExibeTabuleiro.Items.Add(textoExibido);
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

        private void lstVerificaVez_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}