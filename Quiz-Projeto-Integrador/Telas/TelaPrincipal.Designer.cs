namespace Quiz_Projeto_Integrador.Telas
{
    partial class TelaPrincipal
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
            btnQuiz = new Button();
            btnRaking = new Button();
            btnPerfil = new Button();
            btnHistorico = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pbPerfil = new PictureBox();
            pbQuiz = new PictureBox();
            btnSair = new Button();
            pictureBox4 = new PictureBox();
            btnTelaPergunta = new Button();
            lblAvisoAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuiz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnQuiz
            // 
            btnQuiz.BackColor = Color.FromArgb(133, 6, 235);
            btnQuiz.Font = new Font("Showcard Gothic", 12F);
            btnQuiz.Location = new Point(281, 12);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(212, 70);
            btnQuiz.TabIndex = 0;
            btnQuiz.Text = "Iniciar quiz";
            btnQuiz.UseVisualStyleBackColor = false;
            btnQuiz.Click += this.btnQuiz_Click;
            btnQuiz.MouseEnter += this.btnQuiz_MouseEnter;
            btnQuiz.MouseLeave += this.btnQuiz_MouseLeave;
            // 
            // btnRaking
            // 
            btnRaking.BackColor = Color.FromArgb(133, 6, 235);
            btnRaking.Font = new Font("Showcard Gothic", 12F);
            btnRaking.Location = new Point(281, 95);
            btnRaking.Name = "btnRaking";
            btnRaking.Size = new Size(212, 70);
            btnRaking.TabIndex = 1;
            btnRaking.Text = "Ranking";
            btnRaking.UseVisualStyleBackColor = false;
            btnRaking.Click += this.btnRaking_Click;
            btnRaking.MouseEnter += this.btnRaking_MouseEnter;
            btnRaking.MouseLeave += this.btnRaking_MouseLeave;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(133, 6, 235);
            btnPerfil.Font = new Font("Showcard Gothic", 12F);
            btnPerfil.Location = new Point(281, 272);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(212, 70);
            btnPerfil.TabIndex = 2;
            btnPerfil.Text = "Ver perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += this.btnPerfil_Click;
            btnPerfil.Enter += this.btnPerfil_Enter;
            btnPerfil.MouseEnter += this.btnPerfil_MouseEnter;
            btnPerfil.MouseLeave += this.btnPerfil_MouseLeave;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(133, 6, 235);
            btnHistorico.Font = new Font("Showcard Gothic", 12F);
            btnHistorico.Location = new Point(281, 179);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(212, 70);
            btnHistorico.TabIndex = 3;
            btnHistorico.Text = "Histórico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += this.btnHistorico_Click;
            btnHistorico.MouseEnter += this.btnHistorico_MouseEnter;
            btnHistorico.MouseLeave += this.btnHistorico_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ranking_glyph_board_icon_sports_260nw_2493578947_removebg_preview;
            pictureBox1.Location = new Point(492, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__1__removebg_preview;
            pictureBox2.Location = new Point(492, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pbPerfil
            // 
            pbPerfil.Image = Properties.Resources._7296447_user_icon_in_flat_style_person_icon_client_symbol_vetor_removebg_preview;
            pbPerfil.Location = new Point(499, 272);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(77, 70);
            pbPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbPerfil.TabIndex = 7;
            pbPerfil.TabStop = false;
            // 
            // pbQuiz
            // 
            pbQuiz.Image = Properties.Resources.images_removebg_preview__1_;
            pbQuiz.Location = new Point(499, 12);
            pbQuiz.Name = "pbQuiz";
            pbQuiz.Size = new Size(77, 70);
            pbQuiz.SizeMode = PictureBoxSizeMode.Zoom;
            pbQuiz.TabIndex = 9;
            pbQuiz.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 128, 128);
            btnSair.Font = new Font("Showcard Gothic", 12F);
            btnSair.Location = new Point(281, 368);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(212, 70);
            btnSair.TabIndex = 4;
            btnSair.Text = "Deslogar";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += this.btnSair_Click_1;
            btnSair.MouseEnter += this.btnSair_MouseEnter;
            btnSair.MouseLeave += this.btnSair_MouseLeave_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.images_removebg_preview;
            pictureBox4.Location = new Point(499, 368);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(77, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // btnTelaPergunta
            // 
            btnTelaPergunta.Location = new Point(47, 238);
            btnTelaPergunta.Name = "btnTelaPergunta";
            btnTelaPergunta.Size = new Size(188, 54);
            btnTelaPergunta.TabIndex = 10;
            btnTelaPergunta.Text = "Adicionar pergunta";
            btnTelaPergunta.UseVisualStyleBackColor = true;
            btnTelaPergunta.Visible = false;
            btnTelaPergunta.Click += this.btnTelaPergunta_Click;
            // 
            // lblAvisoAdmin
            // 
            lblAvisoAdmin.AutoSize = true;
            lblAvisoAdmin.ForeColor = Color.Red;
            lblAvisoAdmin.Location = new Point(29, 297);
            lblAvisoAdmin.Name = "lblAvisoAdmin";
            lblAvisoAdmin.Size = new Size(224, 25);
            lblAvisoAdmin.TabIndex = 11;
            lblAvisoAdmin.Text = "Função exclusiva para adm";
            lblAvisoAdmin.Visible = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 200, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(lblAvisoAdmin);
            Controls.Add(btnTelaPergunta);
            Controls.Add(pbQuiz);
            Controls.Add(pictureBox4);
            Controls.Add(pbPerfil);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnHistorico);
            Controls.Add(btnPerfil);
            Controls.Add(btnRaking);
            Controls.Add(btnQuiz);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaPrincipal";
            Text = " ";
            Load += this.TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuiz).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuiz;
        private Button btnRaking;
        private Button btnPerfil;
        private Button btnHistorico;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pbPerfil;
        private PictureBox pbQuiz;
        private Button btnSair;
        private PictureBox pictureBox4;
        private Button btnTelaPergunta;
        private Label lblAvisoAdmin;
    }
}