namespace Quiz_Projeto_Integrador.Telas
{
    partial class QuizResultados
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
            label2 = new Label();
            label3 = new Label();
            btnContinuar = new Button();
            lblPontosGanhos = new Label();
            lblTotalAcertos = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(245, 43);
            label1.Name = "label1";
            label1.Size = new Size(286, 54);
            label1.TabIndex = 0;
            label1.Text = "Quiz finalizado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(97, 122);
            label2.Name = "label2";
            label2.Size = new Size(216, 41);
            label2.TabIndex = 1;
            label2.Text = "Pontos ganhos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F);
            label3.Location = new Point(454, 127);
            label3.Name = "label3";
            label3.Size = new Size(227, 36);
            label3.TabIndex = 2;
            label3.Text = "Total de acertos";
            // 
            // btnContinuar
            // 
            btnContinuar.Font = new Font("Microsoft Sans Serif", 12F);
            btnContinuar.Location = new Point(294, 295);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(171, 53);
            btnContinuar.TabIndex = 3;
            btnContinuar.Text = "Prosseguir";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // lblPontosGanhos
            // 
            lblPontosGanhos.AutoSize = true;
            lblPontosGanhos.Font = new Font("Microsoft Sans Serif", 12F);
            lblPontosGanhos.Location = new Point(178, 180);
            lblPontosGanhos.Name = "lblPontosGanhos";
            lblPontosGanhos.Size = new Size(26, 29);
            lblPontosGanhos.TabIndex = 4;
            lblPontosGanhos.Text = "0";
            lblPontosGanhos.Click += lblPontosGanhos_Click;
            // 
            // lblTotalAcertos
            // 
            lblTotalAcertos.AutoSize = true;
            lblTotalAcertos.Font = new Font("Microsoft Sans Serif", 12F);
            lblTotalAcertos.Location = new Point(546, 181);
            lblTotalAcertos.Name = "lblTotalAcertos";
            lblTotalAcertos.Size = new Size(26, 29);
            lblTotalAcertos.TabIndex = 5;
            lblTotalAcertos.Text = "3";
            lblTotalAcertos.Click += lblTotalAcertos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(578, 181);
            label4.Name = "label4";
            label4.Size = new Size(52, 29);
            label4.TabIndex = 6;
            label4.Text = "/ 10";
            // 
            // QuizResultados
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 360);
            Controls.Add(label4);
            Controls.Add(lblTotalAcertos);
            Controls.Add(lblPontosGanhos);
            Controls.Add(btnContinuar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuizResultados";
            Text = "QuizResultados";
            Load += QuizResultados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnContinuar;
        private Label lblPontosGanhos;
        private Label lblTotalAcertos;
        private Label label4;
    }
}