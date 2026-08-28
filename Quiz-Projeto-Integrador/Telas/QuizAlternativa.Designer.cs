namespace Quiz_Projeto_Integrador.Telas
{
    partial class QuizAlternativa
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
            lblNickname = new Label();
            label1 = new Label();
            lblNivel = new Label();
            label2 = new Label();
            lblPontosTotais = new Label();
            button1 = new Button();
            label3 = new Label();
            lblValorPergunta = new Label();
            rb1 = new RadioButton();
            groupBox1 = new GroupBox();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb4 = new RadioButton();
            label4 = new Label();
            lblPerguntaAtual = new Label();
            lblPergunta = new Label();
            label5 = new Label();
            lblSequencia = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Font = new Font("Segoe UI", 15F);
            lblNickname.Location = new Point(12, 9);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(205, 41);
            lblNickname.TabIndex = 0;
            lblNickname.Text = "Nome usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 1;
            label1.Text = "Nivel:";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(64, 50);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(32, 25);
            lblNivel.TabIndex = 2;
            lblNivel.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(597, 20);
            label2.Name = "label2";
            label2.Size = new Size(198, 41);
            label2.TabIndex = 3;
            label2.Text = "Pontos totais:";
            // 
            // lblPontosTotais
            // 
            lblPontosTotais.AutoSize = true;
            lblPontosTotais.Location = new Point(671, 61);
            lblPontosTotais.Name = "lblPontosTotais";
            lblPontosTotais.Size = new Size(32, 25);
            lblPontosTotais.TabIndex = 4;
            lblPontosTotais.Text = "00";
            // 
            // button1
            // 
            button1.Location = new Point(660, 398);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 10;
            button1.Text = "Avançar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(279, 9);
            label3.Name = "label3";
            label3.Size = new Size(262, 41);
            label3.TabIndex = 11;
            label3.Text = "Valor da pergunta:";
            // 
            // lblValorPergunta
            // 
            lblValorPergunta.AutoSize = true;
            lblValorPergunta.Font = new Font("Segoe UI", 12F);
            lblValorPergunta.Location = new Point(363, 50);
            lblValorPergunta.Name = "lblValorPergunta";
            lblValorPergunta.Size = new Size(40, 32);
            lblValorPergunta.TabIndex = 12;
            lblValorPergunta.Text = "00";
            lblValorPergunta.Click += lblValorPergunta_Click;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(6, 18);
            rb1.MaximumSize = new Size(220, 90);
            rb1.MinimumSize = new Size(0, 90);
            rb1.Name = "rb1";
            rb1.Size = new Size(220, 90);
            rb1.TabIndex = 13;
            rb1.TabStop = true;
            rb1.Text = "Um espaço na memória utilizado para armazenar um valor";
            rb1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb3);
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb4);
            groupBox1.Controls.Add(rb1);
            groupBox1.Location = new Point(167, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 208);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(6, 109);
            rb3.MaximumSize = new Size(210, 90);
            rb3.MinimumSize = new Size(0, 90);
            rb3.Name = "rb3";
            rb3.Size = new Size(210, 90);
            rb3.TabIndex = 15;
            rb3.TabStop = true;
            rb3.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb3_CheckedChanged;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(241, 18);
            rb2.MaximumSize = new Size(205, 90);
            rb2.MinimumSize = new Size(0, 90);
            rb2.Name = "rb2";
            rb2.Size = new Size(205, 90);
            rb2.TabIndex = 14;
            rb2.TabStop = true;
            rb2.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb2_CheckedChanged;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(241, 108);
            rb4.MaximumSize = new Size(205, 90);
            rb4.MinimumSize = new Size(0, 90);
            rb4.Name = "rb4";
            rb4.Size = new Size(205, 90);
            rb4.TabIndex = 16;
            rb4.TabStop = true;
            rb4.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            rb4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 15;
            label4.Text = "Pergunta número:";
            // 
            // lblPerguntaAtual
            // 
            lblPerguntaAtual.AutoSize = true;
            lblPerguntaAtual.Location = new Point(74, 129);
            lblPerguntaAtual.Name = "lblPerguntaAtual";
            lblPerguntaAtual.Size = new Size(22, 25);
            lblPerguntaAtual.TabIndex = 16;
            lblPerguntaAtual.Text = "0";
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Segoe UI", 15F);
            lblPergunta.ImageAlign = ContentAlignment.MiddleLeft;
            lblPergunta.Location = new Point(199, 104);
            lblPergunta.MaximumSize = new Size(550, 140);
            lblPergunta.MinimumSize = new Size(100, 140);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.RightToLeft = RightToLeft.No;
            lblPergunta.Size = new Size(550, 140);
            lblPergunta.TabIndex = 5;
            lblPergunta.Text = "PERGUNTAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 167);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 17;
            label5.Text = "Sequencia de acertos:";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Location = new Point(74, 207);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(22, 25);
            lblSequencia.TabIndex = 18;
            lblSequencia.Text = "0";
            // 
            // QuizAlternativa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSequencia);
            Controls.Add(label5);
            Controls.Add(lblPerguntaAtual);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(lblValorPergunta);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(lblPergunta);
            Controls.Add(lblPontosTotais);
            Controls.Add(label2);
            Controls.Add(lblNivel);
            Controls.Add(label1);
            Controls.Add(lblNickname);
            Name = "QuizAlternativa";
            Text = "a";
            Load += QuizAlternativa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNickname;
        private Label label1;
        private Label lblNivel;
        private Label label2;
        private Label lblPontosTotais;
        private Button button1;
        private Label label3;
        private Label lblValorPergunta;
        private RadioButton rb1;
        private GroupBox groupBox1;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private Label label4;
        private Label lblPerguntaAtual;
        private Label lblPergunta;
        private Label label5;
        private Label lblSequencia;
    }
}