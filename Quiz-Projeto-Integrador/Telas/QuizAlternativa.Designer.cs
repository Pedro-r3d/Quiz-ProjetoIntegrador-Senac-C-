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
            lblPergunta = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            button1 = new Button();
            label3 = new Label();
            lblValorPergunta = new Label();
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
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Segoe UI", 15F);
            lblPergunta.Location = new Point(324, 221);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(155, 41);
            lblPergunta.TabIndex = 5;
            lblPergunta.Text = "(Pergunta)";
            // 
            // btn1
            // 
            btn1.Location = new Point(236, 265);
            btn1.Name = "btn1";
            btn1.Size = new Size(141, 59);
            btn1.TabIndex = 6;
            btn1.Text = "Botao1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(419, 265);
            btn2.Name = "btn2";
            btn2.Size = new Size(145, 59);
            btn2.TabIndex = 7;
            btn2.Text = "Botao2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(236, 338);
            btn3.Name = "btn3";
            btn3.Size = new Size(141, 61);
            btn3.TabIndex = 8;
            btn3.Text = "Botao3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(419, 338);
            btn4.Name = "btn4";
            btn4.Size = new Size(145, 61);
            btn4.TabIndex = 9;
            btn4.Text = "Botao4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(660, 398);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 10;
            button1.Text = "Avançar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(3, 142);
            label3.Name = "label3";
            label3.Size = new Size(262, 41);
            label3.TabIndex = 11;
            label3.Text = "Valor da pergunta:";
            // 
            // lblValorPergunta
            // 
            lblValorPergunta.AutoSize = true;
            lblValorPergunta.Font = new Font("Segoe UI", 12F);
            lblValorPergunta.Location = new Point(84, 195);
            lblValorPergunta.Name = "lblValorPergunta";
            lblValorPergunta.Size = new Size(40, 32);
            lblValorPergunta.TabIndex = 12;
            lblValorPergunta.Text = "00";
            // 
            // QuizAlternativa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValorPergunta);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblPergunta);
            Controls.Add(lblPontosTotais);
            Controls.Add(label2);
            Controls.Add(lblNivel);
            Controls.Add(label1);
            Controls.Add(lblNickname);
            Name = "QuizAlternativa";
            Text = "Quiz";
            Load += QuizAlternativa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNickname;
        private Label label1;
        private Label lblNivel;
        private Label label2;
        private Label lblPontosTotais;
        private Label lblPergunta;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button button1;
        private Label label3;
        private Label lblValorPergunta;
    }
}