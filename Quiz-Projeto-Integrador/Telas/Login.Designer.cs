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
            label2 = new Label();
            SuspendLayout();
            // 
            // lblLogarNick
            // 
            lblLogarNick.AutoSize = true;
            lblLogarNick.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogarNick.Location = new Point(303, 144);
            lblLogarNick.Name = "lblLogarNick";
            lblLogarNick.Size = new Size(166, 41);
            lblLogarNick.TabIndex = 0;
            lblLogarNick.Text = "Nickname";
            // 
            // txtLogarNick
            // 
            txtLogarNick.Location = new Point(294, 188);
            txtLogarNick.Name = "txtLogarNick";
            txtLogarNick.Size = new Size(184, 31);
            txtLogarNick.TabIndex = 1;
            txtLogarNick.TextChanged += txtLogarNick_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 238);
            label1.Name = "label1";
            label1.Size = new Size(107, 41);
            label1.TabIndex = 2;
            label1.Text = "Senha";
            // 
            // txtLogarSenha
            // 
            txtLogarSenha.Location = new Point(294, 282);
            txtLogarSenha.Name = "txtLogarSenha";
            txtLogarSenha.Size = new Size(184, 31);
            txtLogarSenha.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(318, 352);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Logar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 30F);
            label2.Location = new Point(285, 30);
            label2.Name = "label2";
            label2.Size = new Size(206, 74);
            label2.TabIndex = 5;
            label2.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 200, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtLogarSenha);
            Controls.Add(label1);
            Controls.Add(txtLogarNick);
            Controls.Add(lblLogarNick);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogarNick;
        private TextBox txtLogarNick;
        private Label label1;
        private TextBox txtLogarSenha;
        private Button btnLogin;
        private Label label2;
    }
}