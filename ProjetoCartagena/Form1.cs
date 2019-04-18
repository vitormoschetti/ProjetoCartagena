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
            partida.jogadores = new List<Jogador>();
        }
        private void cboListarPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cboListarPartidas.SelectedItem.ToString().Substring(0, 1);
            string retornoPartidas = Jogo.ListarPartidas(status);
            string[] jogos = editarRetorno(retornoPartidas);
            lstPartidas.Items.Clear();
            foreach (string jogo in jogos)
            {
                lstPartidas.Items.Add(jogo);
            }
        }



        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            try
            {
                lstHistoricoPartida.Items.Clear();
                string retorno = Jogo.ExibirHistorico(Convert.ToInt32(txtIdPartida.Text));
                string[] historico = editarRetorno(retorno);
                string textoExibido = "";
                for (int i = 0; i < historico.Length - 1; i++)
                {
                    string[] linha = historico[i].Split(',');
                    foreach (Jogador j in partida.jogadores)
                    {
                        if (j.id == Convert.ToInt32(linha[0]))
                        {
                            if (!linha[2].Equals(""))
                                textoExibido = j.nome + " na sua " + linha[1] + " jogada jogou um " + editarNome(linha[2]) + " e foi da posicao " + linha[3] + " para a " + linha[4];
                            else
                                textoExibido = j.nome + " na sua " + linha[1] + " jogada retornou da posicao " + linha[3] + " para a " + linha[4];
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
                string[] jogadores = editarRetorno(retornoJogadores);
                partida.jogadores = new List<Jogador>();
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
            try
            {
                string dadosDoJogador = Jogo.EntrarPartida(Convert.ToInt32(txtIdPartida.Text), txtNomeJogador.Text, txtSenhaPartida.Text);
                string[] valores = dadosDoJogador.Split(',');
                partida = new Partida(Convert.ToInt32(txtIdPartida.Text), txtNomePartida.Text, txtSenhaPartida.Text);

                txtIdJogador.Text = valores[0];
                txtSenhaJogador.Text = valores[1];
                txtCorJogador.Text = valores[2];
                nossoJogador = new Jogador(Convert.ToInt32(valores[0]), valores[1], valores[2], txtNomeJogador.Text);

                VerificaSeAPartidaIniciou.Enabled = true;
                //Listar os jogadores apos entrar na partida
            }
            catch (FormatException)
            {

                MessageBox.Show("ERRO!!! Verifique os campos ID partida, Nome do Jogador e Senha partida", "ERRO");
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Jogo.IniciarPartida(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
            //Exibir mao, tabuleiro e verificar vez
        }
        private void btnJogarFrente_Click(object sender, EventArgs e)
        {
            try
            {
                Jogo.Jogar(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text, Convert.ToInt32(txtPosicao.Text), cboSimbolo.Text.Substring(0, 1));
                //Exibir historico, verificar vez e exibir mao
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
                //Exibir historico, verificar vez e exibir mao

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
                //Exibir historico e verificar vez

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
                string[] cartas = editarRetorno(mao);
                lstMaoJogador.Items.Clear();
                foreach (string carta in cartas)
                {
                    string[] linha = carta.Split(',');
                    if (linha.Length > 1)
                    {
                        nossoJogador.cartas.Add(linha[0]);
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
                string[] posicoes = editarRetorno(verificaVez);
                lstVerificaVez.Items.Clear();
                btnListarJogadores_Click(sender, e);
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
                                textoExibido = "O jogador " + j.nome + " tem " + linha[2] + " pirata(s) na casa " + linha[0];

                                j.posicao.Add(Convert.ToInt32(linha[0]));

                            }
                        }

                    }
                    else
                    {
                        foreach (Jogador j in partida.jogadores)
                        {
                            if (j.id == Convert.ToInt32(linha[1]))
                            {
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
                string[] posicoes = editarRetorno(tabuleiro);
                lstExibeTabuleiro.Items.Clear();
                string textoExibido = "";
                for (int i = 1; i < posicoes.Length - 2; i++)
                {
                    string[] linha = posicoes[i].Split(',');

                    textoExibido = "Na posiçao " + linha[0] + " tem um(a) " + editarNome(linha[1]);
                    lstExibeTabuleiro.Items.Add(textoExibido);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO!!! Verifique os campos ID da partida", "ERRO");
            }
        }

        private void VerificaSeAPartidaIniciou_Tick(object sender, EventArgs e)
        {
            String partidas = Jogo.ListarPartidas("J");
            String[] dados = editarRetorno(partidas);
            foreach (String linha in dados)
            {
                String[] id = linha.Split(',');
                if (id[0].Equals(partida.id.ToString()))
                {
                    VerificaSeAPartidaIniciou.Enabled = false;
                    VerificaVez.Enabled = true;
                }
            }
        }

        private void VerificaVez_Tick(object sender, EventArgs e)
        {
            string verificaVez = Jogo.VerificarVez(Convert.ToInt32(partida.id.ToString()));
            string[] posicoes = editarRetorno(verificaVez);
            String[] id = posicoes[0].Split(',');
            if (Convert.ToInt32(id[1]) == nossoJogador.id)
            {
                string jogada = null;
                if (nossoJogador.cartas.Contains("E"))
                {
                    jogada = "E";
                }
                else if (nossoJogador.cartas.Contains("T"))
                {
                    jogada = "T";
                }
                else if (nossoJogador.cartas.Contains("F"))
                {
                    jogada = "F";
                }
                else if (nossoJogador.cartas.Contains("C"))
                {
                    jogada = "C";
                }
                else if (nossoJogador.cartas.Contains("P"))
                {
                    jogada = "P";
                }
                else if (nossoJogador.cartas.Contains("G"))
                {
                    jogada = "G";
                }

                btnExibirMao_Click(sender, e);
                btnVerificarVez_Click(sender, e);
                Jogo.Jogar(nossoJogador.id, nossoJogador.senha, 0, jogada);
                nossoJogador.cartas.Remove(jogada);
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
        private string[] editarRetorno(string text)
        {
            return text.Replace("\n", "").Split('\r');
        }
    }
}