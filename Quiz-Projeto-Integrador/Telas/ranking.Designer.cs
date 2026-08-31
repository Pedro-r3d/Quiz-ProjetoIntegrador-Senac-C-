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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 92);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(880, 347);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.BackColor = Color.FromArgb(133, 6, 235);
            btnVerPerfil.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerPerfil.Location = new Point(700, 445);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(192, 63);
            btnVerPerfil.TabIndex = 1;
            btnVerPerfil.Text = "Ver perfil";
            btnVerPerfil.UseVisualStyleBackColor = false;
            btnVerPerfil.Click += btnVerPerfil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ranking_glyph_board_icon_sports_260nw_2493578947_removebg_preview;
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 30F);
            label1.Location = new Point(316, -4);
            label1.Name = "label1";
            label1.Size = new Size(293, 74);
            label1.TabIndex = 7;
            label1.Text = "RANKING";
            // 
            // ranking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 200, 87);
            ClientSize = new Size(904, 513);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnVerPerfil);
            Controls.Add(dgvUsuarios);
            Name = "ranking";
            ShowIcon = false;
            Text = "ranking";
            Load += ranking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnVerPerfil;
        private PictureBox pictureBox1;
        private Label label1;
    }
}