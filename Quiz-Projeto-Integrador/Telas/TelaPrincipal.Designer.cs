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
            SuspendLayout();
            // 
            // btnQuiz
            // 
            btnQuiz.Location = new Point(281, 68);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(212, 70);
            btnQuiz.TabIndex = 0;
            btnQuiz.Text = "Iniciar quiz";
            btnQuiz.UseVisualStyleBackColor = true;
            btnQuiz.Click += btnQuiz_Click;
            // 
            // btnRaking
            // 
            btnRaking.Location = new Point(281, 144);
            btnRaking.Name = "btnRaking";
            btnRaking.Size = new Size(212, 70);
            btnRaking.TabIndex = 1;
            btnRaking.Text = "Ranking";
            btnRaking.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            btnPerfil.Location = new Point(281, 296);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(212, 70);
            btnPerfil.TabIndex = 2;
            btnPerfil.Text = "Ver perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.Location = new Point(281, 220);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(212, 70);
            btnHistorico.TabIndex = 3;
            btnHistorico.Text = "Histórico";
            btnHistorico.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHistorico);
            Controls.Add(btnPerfil);
            Controls.Add(btnRaking);
            Controls.Add(btnQuiz);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnQuiz;
        private Button btnRaking;
        private Button btnPerfil;
        private Button btnHistorico;
    }
}