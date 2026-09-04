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
            btnSair = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNickname.Location = new Point(-2, 11);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(248, 37);
            lblNickname.TabIndex = 0;
            lblNickname.Text = "Nome usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 1;
            label1.Text = "lvl:";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Showcard Gothic", 12F);
            lblNivel.ForeColor = Color.Red;
            lblNivel.Location = new Point(64, 50);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(41, 30);
            lblNivel.TabIndex = 2;
            lblNivel.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F);
            label2.Location = new Point(800, 15);
            label2.Name = "label2";
            label2.Size = new Size(203, 30);
            label2.TabIndex = 3;
            label2.Text = "Pontos totais:";
            // 
            // lblPontosTotais
            // 
            lblPontosTotais.AutoSize = true;
            lblPontosTotais.Font = new Font("Showcard Gothic", 15F);
            lblPontosTotais.ForeColor = Color.Red;
            lblPontosTotais.Location = new Point(874, 50);
            lblPontosTotais.Name = "lblPontosTotais";
            lblPontosTotais.Size = new Size(53, 37);
            lblPontosTotais.TabIndex = 4;
            lblPontosTotais.Text = "00";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(133, 6, 235);
            button1.Font = new Font("Showcard Gothic", 12F);
            button1.Location = new Point(853, 447);
            button1.Name = "button1";
            button1.Size = new Size(160, 77);
            button1.TabIndex = 10;
            button1.Text = "Avançar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 13);
            label3.Name = "label3";
            label3.Size = new Size(330, 37);
            label3.TabIndex = 11;
            label3.Text = "Valor da pergunta:";
            // 
            // lblValorPergunta
            // 
            lblValorPergunta.AutoSize = true;
            lblValorPergunta.Font = new Font("Showcard Gothic", 15F);
            lblValorPergunta.ForeColor = Color.Red;
            lblValorPergunta.Location = new Point(497, 50);
            lblValorPergunta.Name = "lblValorPergunta";
            lblValorPergunta.Size = new Size(53, 37);
            lblValorPergunta.TabIndex = 12;
            lblValorPergunta.Text = "00";
            lblValorPergunta.Click += lblValorPergunta_Click;
            // 
            // rb1
            // 
            rb1.Location = new Point(16, 35);
            rb1.Name = "rb1";
            rb1.Size = new Size(285, 112);
            rb1.TabIndex = 13;
            rb1.TabStop = true;
            rb1.Text = "Qual comando SQL é utilizado para consultar dados de uma tabela?";
            rb1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb3);
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb4);
            groupBox1.Controls.Add(rb1);
            groupBox1.Font = new Font("Bernard MT Condensed", 12F);
            groupBox1.Location = new Point(270, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 257);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rb3
            // 
            rb3.Font = new Font("Bernard MT Condensed", 12F);
            rb3.Location = new Point(16, 151);
            rb3.MaximumSize = new Size(300, 170);
            rb3.MinimumSize = new Size(0, 100);
            rb3.Name = "rb3";
            rb3.Size = new Size(285, 100);
            rb3.TabIndex = 15;
            rb3.TabStop = true;
            rb3.Text = "Qual comando SQL é utilizado para consultar dados de uma tabela?";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb3_CheckedChanged;
            // 
            // rb2
            // 
            rb2.Location = new Point(307, 20);
            rb2.MaximumSize = new Size(300, 200);
            rb2.MinimumSize = new Size(120, 100);
            rb2.Name = "rb2";
            rb2.Size = new Size(264, 128);
            rb2.TabIndex = 14;
            rb2.TabStop = true;
            rb2.Text = "Qual comando SQL é utilizado para consultar dados de uma tabela?";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb2_CheckedChanged;
            // 
            // rb4
            // 
            rb4.Location = new Point(307, 151);
            rb4.MaximumSize = new Size(300, 200);
            rb4.MinimumSize = new Size(0, 100);
            rb4.Name = "rb4";
            rb4.Size = new Size(264, 100);
            rb4.TabIndex = 16;
            rb4.TabStop = true;
            rb4.Text = "Qual comando SQL é utilizado para consultar dados de uma tabela?";
            rb4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 11F);
            label4.Location = new Point(-2, 255);
            label4.Name = "label4";
            label4.Size = new Size(227, 28);
            label4.TabIndex = 15;
            label4.Text = "Pergunta número:";
            label4.Click += label4_Click;
            // 
            // lblPerguntaAtual
            // 
            lblPerguntaAtual.AutoSize = true;
            lblPerguntaAtual.Font = new Font("Showcard Gothic", 12F);
            lblPerguntaAtual.ForeColor = SystemColors.ButtonShadow;
            lblPerguntaAtual.Location = new Point(72, 278);
            lblPerguntaAtual.Name = "lblPerguntaAtual";
            lblPerguntaAtual.Size = new Size(27, 30);
            lblPerguntaAtual.TabIndex = 16;
            lblPerguntaAtual.Text = "0";
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.BackColor = Color.FromArgb(64, 64, 64);
            lblPergunta.Font = new Font("Snap ITC", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta.ForeColor = Color.FromArgb(250, 245, 1);
            lblPergunta.Location = new Point(297, 104);
            lblPergunta.MaximumSize = new Size(550, 300);
            lblPergunta.MinimumSize = new Size(100, 140);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.RightToLeft = RightToLeft.No;
            lblPergunta.Size = new Size(529, 140);
            lblPergunta.TabIndex = 5;
            lblPergunta.Text = "PERGUNTAAAAAAAAAAAAAAAAAAAAAAAA";
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            lblPergunta.Click += lblPergunta_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10F);
            label5.Location = new Point(-2, 318);
            label5.Name = "label5";
            label5.Size = new Size(245, 26);
            label5.TabIndex = 17;
            label5.Text = "Sequencia de acertos:";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Font = new Font("Showcard Gothic", 12F);
            lblSequencia.ForeColor = Color.FromArgb(29, 134, 38);
            lblSequencia.Location = new Point(72, 346);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(27, 30);
            lblSequencia.TabIndex = 18;
            lblSequencia.Text = "0";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 128, 128);
            btnSair.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(12, 447);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(162, 77);
            btnSair.TabIndex = 19;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Visible = false;
            btnSair.Click += btnSair_Click_1;
            // 
            // QuizAlternativa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 200, 87);
            ClientSize = new Size(1025, 536);
            Controls.Add(btnSair);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QuizAlternativa";
            Text = "Quiz";
            Load += QuizAlternativa_Load;
            groupBox1.ResumeLayout(false);
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
        private Button btnSair;
    }
}