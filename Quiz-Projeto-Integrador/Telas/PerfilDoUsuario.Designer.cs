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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblPerguntasRespondidas
            // 
            lblPerguntasRespondidas.AutoSize = true;
            lblPerguntasRespondidas.Location = new Point(13, 90);
            lblPerguntasRespondidas.Name = "lblPerguntasRespondidas";
            lblPerguntasRespondidas.Size = new Size(197, 25);
            lblPerguntasRespondidas.TabIndex = 3;
            lblPerguntasRespondidas.Text = "Perguntas respondidas:";
            lblPerguntasRespondidas.Click += label1_Click;
            // 
            // txtAcertos
            // 
            txtAcertos.AutoSize = true;
            txtAcertos.Location = new Point(13, 125);
            txtAcertos.Name = "txtAcertos";
            txtAcertos.Size = new Size(174, 25);
            txtAcertos.TabIndex = 7;
            txtAcertos.Text = "Perguntas acertadas:";
            // 
            // lblPontuacao
            // 
            lblPontuacao.AutoSize = true;
            lblPontuacao.Location = new Point(13, 55);
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Size = new Size(99, 25);
            lblPontuacao.TabIndex = 5;
            lblPontuacao.Text = "Pontuação:";
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Location = new Point(13, 20);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(90, 25);
            lblNickname.TabIndex = 9;
            lblNickname.Text = "Nickname";
            // 
            // lblPontos
            // 
            lblPontos.AutoSize = true;
            lblPontos.Location = new Point(111, 55);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(32, 25);
            lblPontos.TabIndex = 10;
            lblPontos.Text = "00";
            // 
            // lblRespostas
            // 
            lblRespostas.AutoSize = true;
            lblRespostas.Location = new Point(216, 90);
            lblRespostas.Name = "lblRespostas";
            lblRespostas.Size = new Size(32, 25);
            lblRespostas.TabIndex = 11;
            lblRespostas.Text = "00";
            // 
            // lblAcertos
            // 
            lblAcertos.AutoSize = true;
            lblAcertos.Location = new Point(193, 125);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(32, 25);
            lblAcertos.TabIndex = 12;
            lblAcertos.Text = "00";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(615, 20);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(55, 25);
            lblNivel.TabIndex = 13;
            lblNivel.Text = "Nivel:";
            // 
            // lblNivelNumber
            // 
            lblNivelNumber.AutoSize = true;
            lblNivelNumber.Location = new Point(672, 20);
            lblNivelNumber.Name = "lblNivelNumber";
            lblNivelNumber.Size = new Size(32, 25);
            lblNivelNumber.TabIndex = 14;
            lblNivelNumber.Text = "00";
            // 
            // lblTemasAcertados
            // 
            lblTemasAcertados.AutoSize = true;
            lblTemasAcertados.Location = new Point(12, 346);
            lblTemasAcertados.Name = "lblTemasAcertados";
            lblTemasAcertados.Size = new Size(189, 25);
            lblTemasAcertados.TabIndex = 15;
            lblTemasAcertados.Text = "Temas mais acertados:";
            // 
            // lblConquistas
            // 
            lblConquistas.AutoSize = true;
            lblConquistas.Location = new Point(582, 346);
            lblConquistas.Name = "lblConquistas";
            lblConquistas.Size = new Size(104, 25);
            lblConquistas.TabIndex = 16;
            lblConquistas.Text = "Conquistas:";
            lblConquistas.Click += lblConquistas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(562, 371);
            label1.Name = "label1";
            label1.Size = new Size(36, 25);
            label1.TabIndex = 17;
            label1.Text = "ccc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(653, 371);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 18;
            label2.Text = "ccc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(15, 371);
            label4.Name = "label4";
            label4.Size = new Size(172, 25);
            label4.TabIndex = 20;
            label4.Text = "cccccccccccccccccccc";
            // 
            // PerfilDoUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblConquistas);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}