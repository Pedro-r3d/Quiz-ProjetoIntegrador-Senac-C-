namespace Quiz_Projeto_Integrador.Telas
{
    partial class Cadastrar
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtNickname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            label5 = new Label();
            btnCadastrar = new Button();
            dtpDataDeNascimento = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Nome do usuario";
            label1.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(229, 31);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 108);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 2;
            label2.Text = "Nickname";
            label2.Click += label2_Click;
            // 
            // txtNickname
            // 
            txtNickname.Location = new Point(22, 143);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(229, 31);
            txtNickname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 196);
            label3.Name = "label3";
            label3.Size = new Size(227, 32);
            label3.TabIndex = 4;
            label3.Text = "Data de nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 288);
            label4.Name = "label4";
            label4.Size = new Size(80, 32);
            label4.TabIndex = 6;
            label4.Text = "Senha";
            label4.Click += label4_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(24, 323);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(229, 31);
            txtSenha.TabIndex = 7;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(24, 392);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(229, 31);
            txtConfirmarSenha.TabIndex = 9;
            txtConfirmarSenha.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 357);
            label5.Name = "label5";
            label5.Size = new Size(190, 32);
            label5.TabIndex = 8;
            label5.Text = "Confirmar senha";
            label5.Click += label5_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(543, 372);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(166, 66);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dtpDataDeNascimento
            // 
            dtpDataDeNascimento.Location = new Point(24, 231);
            dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            dtpDataDeNascimento.Size = new Size(229, 31);
            dtpDataDeNascimento.TabIndex = 11;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 450);
            Controls.Add(dtpDataDeNascimento);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(label5);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNickname);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cadastrar";
            Text = "Cadastro usuario";
            Load += Cadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtNickname;
        private Label label3;
        private Label label4;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Label label5;
        private Button btnCadastrar;
        private DateTimePicker dtpDataDeNascimento;
    }
}