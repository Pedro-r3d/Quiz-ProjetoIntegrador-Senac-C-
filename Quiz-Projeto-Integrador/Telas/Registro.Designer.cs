namespace Quiz_Projeto_Integrador.Telas
{
    partial class Registro
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
            dgvRegistro = new DataGridView();
            lblQuiz = new Label();
            label1 = new Label();
            lblAcertos = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistro
            // 
            dgvRegistro.AllowUserToAddRows = false;
            dgvRegistro.AllowUserToDeleteRows = false;
            dgvRegistro.AllowUserToResizeColumns = false;
            dgvRegistro.AllowUserToResizeRows = false;
            dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistro.Location = new Point(159, 12);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.ReadOnly = true;
            dgvRegistro.RowHeadersWidth = 62;
            dgvRegistro.Size = new Size(629, 426);
            dgvRegistro.TabIndex = 0;
            // 
            // lblQuiz
            // 
            lblQuiz.AutoSize = true;
            lblQuiz.Font = new Font("Segoe UI", 15F);
            lblQuiz.Location = new Point(12, 9);
            lblQuiz.Name = "lblQuiz";
            lblQuiz.Size = new Size(127, 41);
            lblQuiz.TabIndex = 1;
            lblQuiz.Text = "Quiz N.°";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(102, 36);
            label1.TabIndex = 2;
            label1.Text = "Acertos";
            // 
            // lblAcertos
            // 
            lblAcertos.AutoSize = true;
            lblAcertos.Font = new Font("Segoe UI", 18F);
            lblAcertos.Location = new Point(12, 120);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(93, 48);
            lblAcertos.TabIndex = 3;
            lblAcertos.Text = "X/10";
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(12, 365);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(124, 73);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(lblAcertos);
            Controls.Add(label1);
            Controls.Add(lblQuiz);
            Controls.Add(dgvRegistro);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegistro;
        private Label lblQuiz;
        private Label label1;
        private Label lblAcertos;
        private Button btnVoltar;
    }
}