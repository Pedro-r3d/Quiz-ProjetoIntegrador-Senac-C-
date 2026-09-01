namespace Quiz_Projeto_Integrador.Telas
{
    partial class AdicionarPergunta
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtAlternativaC = new TextBox();
            txtAlternativaA = new TextBox();
            txtAlternativaD = new TextBox();
            txtAlternativaB = new TextBox();
            txtQuestao = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtResposta = new TextBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            rbDificil = new RadioButton();
            rbMedio = new RadioButton();
            rbFacil = new RadioButton();
            label9 = new Label();
            nudPontos = new NumericUpDown();
            groupBox2 = new GroupBox();
            rbJava = new RadioButton();
            rbCsharp = new RadioButton();
            rbSql = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPontos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25F);
            label1.Location = new Point(175, -4);
            label1.Name = "label1";
            label1.Size = new Size(477, 62);
            label1.TabIndex = 0;
            label1.Text = "PERGUNTAS NOVAS";
            // 
            // txtAlternativaC
            // 
            txtAlternativaC.Location = new Point(289, 177);
            txtAlternativaC.Name = "txtAlternativaC";
            txtAlternativaC.Size = new Size(245, 31);
            txtAlternativaC.TabIndex = 1;
            // 
            // txtAlternativaA
            // 
            txtAlternativaA.Location = new Point(10, 178);
            txtAlternativaA.Name = "txtAlternativaA";
            txtAlternativaA.Size = new Size(245, 31);
            txtAlternativaA.TabIndex = 2;
            // 
            // txtAlternativaD
            // 
            txtAlternativaD.Location = new Point(289, 250);
            txtAlternativaD.Name = "txtAlternativaD";
            txtAlternativaD.Size = new Size(245, 31);
            txtAlternativaD.TabIndex = 3;
            // 
            // txtAlternativaB
            // 
            txtAlternativaB.Location = new Point(10, 253);
            txtAlternativaB.Name = "txtAlternativaB";
            txtAlternativaB.Size = new Size(245, 31);
            txtAlternativaB.TabIndex = 4;
            // 
            // txtQuestao
            // 
            txtQuestao.Location = new Point(165, 119);
            txtQuestao.Name = "txtQuestao";
            txtQuestao.Size = new Size(245, 31);
            txtQuestao.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 91);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 6;
            label2.Text = "Pergunta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 150);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 7;
            label3.Text = "Alternativa A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 225);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 8;
            label4.Text = "Alternativa B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 150);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 9;
            label5.Text = "Alternativa C";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 222);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 10;
            label6.Text = "Alternativa D";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 300);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 11;
            label7.Text = "Resposta";
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(175, 328);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(245, 31);
            txtResposta.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(628, 382);
            button1.Name = "button1";
            button1.Size = new Size(137, 56);
            button1.TabIndex = 13;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDificil);
            groupBox1.Controls.Add(rbMedio);
            groupBox1.Controls.Add(rbFacil);
            groupBox1.Location = new Point(552, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 126);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nivel";
            // 
            // rbDificil
            // 
            rbDificil.AutoSize = true;
            rbDificil.Location = new Point(142, 30);
            rbDificil.Name = "rbDificil";
            rbDificil.Size = new Size(80, 29);
            rbDificil.TabIndex = 2;
            rbDificil.TabStop = true;
            rbDificil.Text = "Dificil";
            rbDificil.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            rbMedio.AutoSize = true;
            rbMedio.Location = new Point(6, 79);
            rbMedio.Name = "rbMedio";
            rbMedio.Size = new Size(88, 29);
            rbMedio.TabIndex = 1;
            rbMedio.TabStop = true;
            rbMedio.Text = "Medio";
            rbMedio.UseVisualStyleBackColor = true;
            // 
            // rbFacil
            // 
            rbFacil.AutoSize = true;
            rbFacil.Location = new Point(6, 30);
            rbFacil.Name = "rbFacil";
            rbFacil.Size = new Size(70, 29);
            rbFacil.TabIndex = 0;
            rbFacil.TabStop = true;
            rbFacil.Text = "Facil";
            rbFacil.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(685, 317);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 17;
            label9.Text = "Pontos";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // nudPontos
            // 
            nudPontos.Location = new Point(676, 345);
            nudPontos.Name = "nudPontos";
            nudPontos.Size = new Size(88, 31);
            nudPontos.TabIndex = 18;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbJava);
            groupBox2.Controls.Add(rbCsharp);
            groupBox2.Controls.Add(rbSql);
            groupBox2.Location = new Point(552, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 106);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tema";
            // 
            // rbJava
            // 
            rbJava.AutoSize = true;
            rbJava.Location = new Point(142, 30);
            rbJava.Name = "rbJava";
            rbJava.Size = new Size(70, 29);
            rbJava.TabIndex = 2;
            rbJava.TabStop = true;
            rbJava.Text = "Java";
            rbJava.UseVisualStyleBackColor = true;
            // 
            // rbCsharp
            // 
            rbCsharp.AutoSize = true;
            rbCsharp.Location = new Point(6, 68);
            rbCsharp.Name = "rbCsharp";
            rbCsharp.Size = new Size(59, 29);
            rbCsharp.TabIndex = 1;
            rbCsharp.TabStop = true;
            rbCsharp.Text = "C#";
            rbCsharp.UseVisualStyleBackColor = true;
            rbCsharp.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbSql
            // 
            rbSql.AutoSize = true;
            rbSql.Location = new Point(6, 30);
            rbSql.Name = "rbSql";
            rbSql.Size = new Size(69, 29);
            rbSql.TabIndex = 0;
            rbSql.TabStop = true;
            rbSql.Text = "SQL";
            rbSql.UseVisualStyleBackColor = true;
            // 
            // AdicionarPergunta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 200, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(nudPontos);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(txtResposta);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtQuestao);
            Controls.Add(txtAlternativaB);
            Controls.Add(txtAlternativaD);
            Controls.Add(txtAlternativaA);
            Controls.Add(txtAlternativaC);
            Controls.Add(label1);
            Name = "AdicionarPergunta";
            Text = "AdicionarPergunta";
            Load += AdicionarPergunta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPontos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAlternativaC;
        private TextBox txtAlternativaA;
        private TextBox txtAlternativaD;
        private TextBox txtAlternativaB;
        private TextBox txtQuestao;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtResposta;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private RadioButton rbDificil;
        private RadioButton rbMedio;
        private RadioButton rbFacil;
        private Label label9;
        private NumericUpDown nudPontos;
        private GroupBox groupBox2;
        private RadioButton rbJava;
        private RadioButton rbCsharp;
        private RadioButton rbSql;
    }
}