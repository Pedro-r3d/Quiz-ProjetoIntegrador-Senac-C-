namespace Quiz_Projeto_Integrador.Telas
{
    partial class ranking
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
            dgvUsuarios = new DataGridView();
            btnVerPerfil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(796, 366);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.Location = new Point(653, 375);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(135, 63);
            btnVerPerfil.TabIndex = 1;
            btnVerPerfil.Text = "Ver perfil";
            btnVerPerfil.UseVisualStyleBackColor = true;
            btnVerPerfil.Click += btnVerPerfil_Click;
            // 
            // ranking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerPerfil);
            Controls.Add(dgvUsuarios);
            Name = "ranking";
            ShowIcon = false;
            Text = "ranking";
            Load += ranking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnVerPerfil;
    }
}