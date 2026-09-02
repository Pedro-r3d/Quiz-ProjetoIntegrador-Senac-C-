namespace Quiz_Projeto_Integrador.Telas
{
    partial class QuizModos
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
            btnModoNormal = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 30F);
            label1.Location = new Point(267, 61);
            label1.Name = "label1";
            label1.Size = new Size(235, 74);
            label1.TabIndex = 0;
            label1.Text = "MODOS";
            // 
            // btnModoNormal
            // 
            btnModoNormal.BackColor = Color.FromArgb(133, 6, 235);
            btnModoNormal.Font = new Font("Showcard Gothic", 12F);
            btnModoNormal.Location = new Point(114, 208);
            btnModoNormal.Name = "btnModoNormal";
            btnModoNormal.Size = new Size(193, 72);
            btnModoNormal.TabIndex = 1;
            btnModoNormal.Text = "Modo normal";
            btnModoNormal.UseVisualStyleBackColor = false;
            btnModoNormal.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(133, 6, 235);
            button2.Font = new Font("Showcard Gothic", 12F);
            button2.Location = new Point(457, 208);
            button2.Name = "button2";
            button2.Size = new Size(193, 72);
            button2.TabIndex = 2;
            button2.Text = "Modo treino";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 311);
            label2.Name = "label2";
            label2.Size = new Size(272, 25);
            label2.TabIndex = 3;
            label2.Text = "Modo normal com 10 perguntas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 286);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "INFO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(526, 286);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 5;
            label4.Text = "INFO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 311);
            label5.Name = "label5";
            label5.Size = new Size(356, 25);
            label5.TabIndex = 6;
            label5.Text = "Modo treino se errar volta desde o começo";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Showcard Gothic", 12F);
            button1.Location = new Point(300, 368);
            button1.Name = "button1";
            button1.Size = new Size(172, 70);
            button1.TabIndex = 7;
            button1.Text = "Retornar ao menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // QuizModos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 200, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btnModoNormal);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QuizModos";
            Text = "QuizModos";
            Load += QuizModos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnModoNormal;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}