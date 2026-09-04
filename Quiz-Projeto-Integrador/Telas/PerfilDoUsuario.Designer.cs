namespace Quiz_Projeto_Integrador.Telas
{
    partial class PerfilDoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPerguntasRespondidas = new Label();
            txtAcertos = new Label();
            lblPontuacao = new Label();
            lblNickname = new Label();
            lblPontos = new Label();
            lblRespostas = new Label();
            lblAcertos = new Label();
            lblNivel = new Label();
            lblNivelNumber = new Label();
            lblTemasAcertados = new Label();
            lblConquistas = new Label();
            label3 = new Label();
            lblTema = new Label();
            pcbPreparado = new PictureBox();
            pcbPerfect = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbPreparado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPerfect).BeginInit();
            SuspendLayout();
            // 
            // lblPerguntasRespondidas
            // 
            lblPerguntasRespondidas.AutoSize = true;
            lblPerguntasRespondidas.Font = new Font("Segoe UI", 12F);
            lblPerguntasRespondidas.Location = new Point(13, 90);
            lblPerguntasRespondidas.Name = "lblPerguntasRespondidas";
            lblPerguntasRespondidas.Size = new Size(260, 32);
            lblPerguntasRespondidas.TabIndex = 3;
            lblPerguntasRespondidas.Text = "Perguntas respondidas:";
            lblPerguntasRespondidas.Click += label1_Click;
            // 
            // txtAcertos
            // 
            txtAcertos.AutoSize = true;
            txtAcertos.Font = new Font("Segoe UI", 12F);
            txtAcertos.Location = new Point(13, 125);
            txtAcertos.Name = "txtAcertos";
            txtAcertos.Size = new Size(231, 32);
            txtAcertos.TabIndex = 7;
            txtAcertos.Text = "Perguntas acertadas:";
            // 
            // lblPontuacao
            // 
            lblPontuacao.AutoSize = true;
            lblPontuacao.Font = new Font("Segoe UI", 12F);
            lblPontuacao.Location = new Point(13, 55);
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Size = new Size(130, 32);
            lblPontuacao.TabIndex = 5;
            lblPontuacao.Text = "Pontuação:";
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Font = new Font("Segoe UI", 12F);
            lblNickname.Location = new Point(15, 20);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(121, 32);
            lblNickname.TabIndex = 9;
            lblNickname.Text = "Nickname";
            lblNickname.Click += lblNickname_Click;
            // 
            // lblPontos
            // 
            lblPontos.AutoSize = true;
            lblPontos.Font = new Font("Segoe UI", 12F);
            lblPontos.Location = new Point(149, 55);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(40, 32);
            lblPontos.TabIndex = 10;
            lblPontos.Text = "00";
            // 
            // lblRespostas
            // 
            lblRespostas.AutoSize = true;
            lblRespostas.Font = new Font("Segoe UI", 12F);
            lblRespostas.Location = new Point(279, 90);
            lblRespostas.Name = "lblRespostas";
            lblRespostas.Size = new Size(40, 32);
            lblRespostas.TabIndex = 11;
            lblRespostas.Text = "00";
            // 
            // lblAcertos
            // 
            lblAcertos.AutoSize = true;
            lblAcertos.Font = new Font("Segoe UI", 12F);
            lblAcertos.Location = new Point(250, 125);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(40, 32);
            lblAcertos.TabIndex = 12;
            lblAcertos.Text = "00";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI", 12F);
            lblNivel.Location = new Point(615, 9);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(74, 32);
            lblNivel.TabIndex = 13;
            lblNivel.Text = "Nivel:";
            // 
            // lblNivelNumber
            // 
            lblNivelNumber.AutoSize = true;
            lblNivelNumber.Font = new Font("Segoe UI", 12F);
            lblNivelNumber.Location = new Point(695, 9);
            lblNivelNumber.Name = "lblNivelNumber";
            lblNivelNumber.Size = new Size(40, 32);
            lblNivelNumber.TabIndex = 14;
            lblNivelNumber.Text = "00";
            // 
            // lblTemasAcertados
            // 
            lblTemasAcertados.AutoSize = true;
            lblTemasAcertados.Font = new Font("Segoe UI", 12F);
            lblTemasAcertados.Location = new Point(12, 317);
            lblTemasAcertados.Name = "lblTemasAcertados";
            lblTemasAcertados.Size = new Size(251, 32);
            lblTemasAcertados.TabIndex = 15;
            lblTemasAcertados.Text = "Temas mais acertados:";
            // 
            // lblConquistas
            // 
            lblConquistas.AutoSize = true;
            lblConquistas.Font = new Font("Segoe UI", 14F);
            lblConquistas.Location = new Point(563, 261);
            lblConquistas.Name = "lblConquistas";
            lblConquistas.Size = new Size(158, 38);
            lblConquistas.TabIndex = 16;
            lblConquistas.Text = "Conquistas:";
            lblConquistas.Click += lblConquistas_Click;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 21;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.BackColor = SystemColors.ActiveCaption;
            lblTema.Font = new Font("Segoe UI", 14F);
            lblTema.Location = new Point(18, 359);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(82, 38);
            lblTema.TabIndex = 20;
            lblTema.Text = "Tema";
            // 
            // pcbPreparado
            // 
            pcbPreparado.Image = Properties.Resources._12491;
            pcbPreparado.Location = new Point(648, 317);
            pcbPreparado.Name = "pcbPreparado";
            pcbPreparado.Size = new Size(87, 94);
            pcbPreparado.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPreparado.TabIndex = 23;
            pcbPreparado.TabStop = false;
            pcbPreparado.Visible = false;
            pcbPreparado.Click += pcbPreparado_Click;
            // 
            // pcbPerfect
            // 
            pcbPerfect.Image = Properties.Resources.image_removebg_preview;
            pcbPerfect.InitialImage = Properties.Resources.image_removebg_preview2;
            pcbPerfect.Location = new Point(537, 276);
            pcbPerfect.Name = "pcbPerfect";
            pcbPerfect.Size = new Size(105, 135);
            pcbPerfect.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPerfect.TabIndex = 24;
            pcbPerfect.TabStop = false;
            pcbPerfect.Visible = false;
            // 
            // PerfilDoUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConquistas);
            Controls.Add(pcbPerfect);
            Controls.Add(pcbPreparado);
            Controls.Add(lblTema);
            Controls.Add(label3);
            Controls.Add(lblTemasAcertados);
            Controls.Add(lblNivelNumber);
            Controls.Add(lblNivel);
            Controls.Add(lblAcertos);
            Controls.Add(lblRespostas);
            Controls.Add(lblPontos);
            Controls.Add(lblNickname);
            Controls.Add(lblPontuacao);
            Controls.Add(txtAcertos);
            Controls.Add(lblPerguntasRespondidas);
            Name = "PerfilDoUsuario";
            Text = "Perfil do usuário";
            Load += PerfilDoUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pcbPreparado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPerfect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPerguntasRespondidas;
        private Label txtAcertos;
        private Label lblPontuacao;
        private Label lblNickname;
        private Label lblPontos;
        private Label lblRespostas;
        private Label lblAcertos;
        private Label lblNivel;
        private Label lblNivelNumber;
        private Label lblTemasAcertados;
        private Label lblConquistas;
        private Label label3;
        private Label lblTema;
        private PictureBox pcbPreparado;
        private PictureBox pcbPerfect;
    }
}