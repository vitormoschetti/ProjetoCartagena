namespace ProjetoCartagena
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboListarPartidas = new System.Windows.Forms.ComboBox();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnExibirHistorico = new System.Windows.Forms.Button();
            this.lstHistoricoPartida = new System.Windows.Forms.ListBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorJogador = new System.Windows.Forms.TextBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.cboSimbolo = new System.Windows.Forms.ComboBox();
            this.btnJogarFrente = new System.Windows.Forms.Button();
            this.btnJogarTras = new System.Windows.Forms.Button();
            this.btnPularJogador = new System.Windows.Forms.Button();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.lstMaoJogador = new System.Windows.Forms.ListBox();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lstVerificaVez = new System.Windows.Forms.ListBox();
            this.lstExibeTabuleiro = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar Partidas";
            // 
            // cboListarPartidas
            // 
            this.cboListarPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListarPartidas.FormattingEnabled = true;
            this.cboListarPartidas.Items.AddRange(new object[] {
            "Todas",
            "Jogando",
            "Aberta",
            "Encerrada"});
            this.cboListarPartidas.Location = new System.Drawing.Point(122, 32);
            this.cboListarPartidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboListarPartidas.Name = "cboListarPartidas";
            this.cboListarPartidas.Size = new System.Drawing.Size(73, 21);
            this.cboListarPartidas.TabIndex = 1;
            this.cboListarPartidas.SelectedIndexChanged += new System.EventHandler(this.cboListarPartidas_SelectedIndexChanged);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(33, 70);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(240, 147);
            this.lstPartidas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da Partida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(33, 251);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(240, 20);
            this.txtNomePartida.TabIndex = 5;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(33, 300);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(73, 20);
            this.txtSenhaPartida.TabIndex = 6;
            this.txtSenhaPartida.UseSystemPasswordChar = true;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(122, 297);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(72, 24);
            this.btnCriarPartida.TabIndex = 7;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnExibirHistorico
            // 
            this.btnExibirHistorico.Location = new System.Drawing.Point(33, 341);
            this.btnExibirHistorico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExibirHistorico.Name = "btnExibirHistorico";
            this.btnExibirHistorico.Size = new System.Drawing.Size(160, 20);
            this.btnExibirHistorico.TabIndex = 8;
            this.btnExibirHistorico.Text = "Exibir historico";
            this.btnExibirHistorico.UseVisualStyleBackColor = true;
            this.btnExibirHistorico.Click += new System.EventHandler(this.btnExibirHistorico_Click);
            // 
            // lstHistoricoPartida
            // 
            this.lstHistoricoPartida.FormattingEnabled = true;
            this.lstHistoricoPartida.Location = new System.Drawing.Point(0, 389);
            this.lstHistoricoPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstHistoricoPartida.Name = "lstHistoricoPartida";
            this.lstHistoricoPartida.Size = new System.Drawing.Size(498, 147);
            this.lstHistoricoPartida.TabIndex = 9;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(329, 30);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(98, 23);
            this.btnListarJogadores.TabIndex = 10;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(454, 32);
            this.txtIdPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(35, 20);
            this.txtIdPartida.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(329, 252);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(159, 20);
            this.txtNomeJogador.TabIndex = 15;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(327, 290);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(113, 24);
            this.btnEntrarPartida.TabIndex = 16;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Id Jogador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Senha Jogador";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(338, 342);
            this.txtIdJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdJogador.MaxLength = 20;
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(57, 20);
            this.txtIdJogador.TabIndex = 19;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(413, 342);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenhaJogador.MaxLength = 10;
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(76, 20);
            this.txtSenhaJogador.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 300);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cor do Jogador";
            // 
            // txtCorJogador
            // 
            this.txtCorJogador.Enabled = false;
            this.txtCorJogador.Location = new System.Drawing.Point(228, 322);
            this.txtCorJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorJogador.Name = "txtCorJogador";
            this.txtCorJogador.Size = new System.Drawing.Size(76, 20);
            this.txtCorJogador.TabIndex = 22;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(530, 27);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(159, 22);
            this.btnIniciarPartida.TabIndex = 23;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Posição";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Simbolo";
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(530, 101);
            this.txtPosicao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(58, 20);
            this.txtPosicao.TabIndex = 26;
            // 
            // cboSimbolo
            // 
            this.cboSimbolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSimbolo.FormattingEnabled = true;
            this.cboSimbolo.Items.AddRange(new object[] {
            "Esqueleto",
            "Chave",
            "Garrafa",
            "Pistola",
            "Tricornio",
            "Faca"});
            this.cboSimbolo.Location = new System.Drawing.Point(610, 101);
            this.cboSimbolo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSimbolo.Name = "cboSimbolo";
            this.cboSimbolo.Size = new System.Drawing.Size(80, 21);
            this.cboSimbolo.TabIndex = 27;
            // 
            // btnJogarFrente
            // 
            this.btnJogarFrente.Location = new System.Drawing.Point(530, 141);
            this.btnJogarFrente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJogarFrente.Name = "btnJogarFrente";
            this.btnJogarFrente.Size = new System.Drawing.Size(66, 67);
            this.btnJogarFrente.TabIndex = 28;
            this.btnJogarFrente.Text = "Jogar pra frente";
            this.btnJogarFrente.UseVisualStyleBackColor = true;
            this.btnJogarFrente.Click += new System.EventHandler(this.btnJogarFrente_Click);
            // 
            // btnJogarTras
            // 
            this.btnJogarTras.Location = new System.Drawing.Point(623, 141);
            this.btnJogarTras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJogarTras.Name = "btnJogarTras";
            this.btnJogarTras.Size = new System.Drawing.Size(65, 67);
            this.btnJogarTras.TabIndex = 29;
            this.btnJogarTras.Text = "Jogar pra tras";
            this.btnJogarTras.UseVisualStyleBackColor = true;
            this.btnJogarTras.Click += new System.EventHandler(this.btnJogarTras_Click);
            // 
            // btnPularJogador
            // 
            this.btnPularJogador.Location = new System.Drawing.Point(530, 227);
            this.btnPularJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPularJogador.Name = "btnPularJogador";
            this.btnPularJogador.Size = new System.Drawing.Size(158, 24);
            this.btnPularJogador.TabIndex = 30;
            this.btnPularJogador.Text = "Pular jogada";
            this.btnPularJogador.UseVisualStyleBackColor = true;
            this.btnPularJogador.Click += new System.EventHandler(this.btnPularJogador_Click);
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(530, 279);
            this.btnExibirMao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(158, 24);
            this.btnExibirMao.TabIndex = 31;
            this.btnExibirMao.Text = "Exibir Mão";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click);
            // 
            // lstMaoJogador
            // 
            this.lstMaoJogador.FormattingEnabled = true;
            this.lstMaoJogador.Location = new System.Drawing.Point(530, 322);
            this.lstMaoJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMaoJogador.Name = "lstMaoJogador";
            this.lstMaoJogador.Size = new System.Drawing.Size(159, 186);
            this.lstMaoJogador.TabIndex = 32;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(724, 20);
            this.btnVerificarVez.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(158, 24);
            this.btnVerificarVez.TabIndex = 33;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(1023, 20);
            this.btnExibirTabuleiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(158, 24);
            this.btnExibirTabuleiro.TabIndex = 35;
            this.btnExibirTabuleiro.Text = "Exibir Tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = true;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(1228, 513);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 37;
            this.lblVersao.Text = "Versao";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(327, 70);
            this.lstJogadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(159, 147);
            this.lstJogadores.TabIndex = 13;
            // 
            // lstVerificaVez
            // 
            this.lstVerificaVez.FormattingEnabled = true;
            this.lstVerificaVez.Location = new System.Drawing.Point(724, 62);
            this.lstVerificaVez.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstVerificaVez.Name = "lstVerificaVez";
            this.lstVerificaVez.Size = new System.Drawing.Size(253, 446);
            this.lstVerificaVez.TabIndex = 38;
            this.lstVerificaVez.SelectedIndexChanged += new System.EventHandler(this.lstVerificaVez_SelectedIndexChanged);
            // 
            // lstExibeTabuleiro
            // 
            this.lstExibeTabuleiro.FormattingEnabled = true;
            this.lstExibeTabuleiro.Location = new System.Drawing.Point(1023, 62);
            this.lstExibeTabuleiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstExibeTabuleiro.Name = "lstExibeTabuleiro";
            this.lstExibeTabuleiro.Size = new System.Drawing.Size(316, 446);
            this.lstExibeTabuleiro.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1203, 534);
            this.Controls.Add(this.lstExibeTabuleiro);
            this.Controls.Add(this.lstVerificaVez);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnExibirTabuleiro);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.lstMaoJogador);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.btnPularJogador);
            this.Controls.Add(this.btnJogarTras);
            this.Controls.Add(this.btnJogarFrente);
            this.Controls.Add(this.cboSimbolo);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtCorJogador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.lstHistoricoPartida);
            this.Controls.Add(this.btnExibirHistorico);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.cboListarPartidas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Cartagena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboListarPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnExibirHistorico;
        private System.Windows.Forms.ListBox lstHistoricoPartida;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorJogador;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.ComboBox cboSimbolo;
        private System.Windows.Forms.Button btnJogarFrente;
        private System.Windows.Forms.Button btnJogarTras;
        private System.Windows.Forms.Button btnPularJogador;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.ListBox lstMaoJogador;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.Button btnExibirTabuleiro;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.ListBox lstVerificaVez;
        private System.Windows.Forms.ListBox lstExibeTabuleiro;
    }
}

