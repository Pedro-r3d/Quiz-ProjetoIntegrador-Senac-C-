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
            dataGridView1 = new DataGridView();
            btnSelecionar = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(796, 351);
            dataGridView1.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Font = new Font("Segoe UI", 12F);
            btnSelecionar.Location = new Point(262, 360);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(140, 83);
            btnSelecionar.TabIndex = 1;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.Location = new Point(408, 360);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(140, 83);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnSelecionar);
            Controls.Add(dataGridView1);
            Name = "Historico";
            Text = "Historico";
            Load += Historico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSelecionar;
        private Button btnVoltar;
    }
}