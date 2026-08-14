namespace Quiz_Projeto_Integrador.Telas
{
    partial class Login
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
            lblLogarNick = new Label();
            txtLogarNick = new TextBox();
            label1 = new Label();
            txtLogarSenha = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblLogarNick
            // 
            lblLogarNick.AutoSize = true;
            lblLogarNick.Font = new Font("Segoe UI", 15F);
            lblLogarNick.Location = new Point(308, 108);
            lblLogarNick.Name = "lblLogarNick";
            lblLogarNick.Size = new Size(150, 41);
            lblLogarNick.TabIndex = 0;
            lblLogarNick.Text = "Nickname";
            // 
            // txtLogarNick
            // 
            txtLogarNick.Location = new Point(290, 152);
            txtLogarNick.Name = "txtLogarNick";
            txtLogarNick.Size = new Size(184, 31);
            txtLogarNick.TabIndex = 1;
            txtLogarNick.TextChanged += txtLogarNick_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(328, 202);
            label1.Name = "label1";
            label1.Size = new Size(99, 41);
            label1.TabIndex = 2;
            label1.Text = "Senha";
            // 
            // txtLogarSenha
            // 
            txtLogarSenha.Location = new Point(290, 246);
            txtLogarSenha.Name = "txtLogarSenha";
            txtLogarSenha.Size = new Size(184, 31);
            txtLogarSenha.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(328, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Logar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtLogarSenha);
            Controls.Add(label1);
            Controls.Add(txtLogarNick);
            Controls.Add(lblLogarNick);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogarNick;
        private TextBox txtLogarNick;
        private Label label1;
        private TextBox txtLogarSenha;
        private Button btnLogin;
    }
}