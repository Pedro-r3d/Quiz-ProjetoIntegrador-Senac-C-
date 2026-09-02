namespace Quiz_Projeto_Integrador.Telas
{
    partial class Historico
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
            dgvHistorico = new DataGridView();
            btnSelecionar = new Button();
            btnVoltar = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(12, 86);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersWidth = 62;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(841, 332);
            dgvHistorico.TabIndex = 0;
            dgvHistorico.CellContentClick += dgvHistorico_CellContentClick;
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.FromArgb(133, 6, 235);
            btnSelecionar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecionar.Location = new Point(262, 433);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(144, 71);
            btnSelecionar.TabIndex = 1;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(133, 6, 235);
            btnVoltar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(429, 433);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(140, 71);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 30F);
            label1.Location = new Point(117, -7);
            label1.Name = "label1";
            label1.Size = new Size(736, 74);
            label1.TabIndex = 3;
            label1.Text = "HISTORICO DE PARTIDAS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__1__removebg_preview;
            pictureBox2.Location = new Point(12, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 200, 87);
            ClientSize = new Size(865, 507);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(btnSelecionar);
            Controls.Add(dgvHistorico);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Historico";
            Text = "Historico";
            Load += Historico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorico;
        private Button btnSelecionar;
        private Button btnVoltar;
        private Label label1;
        private PictureBox pictureBox2;
    }
}