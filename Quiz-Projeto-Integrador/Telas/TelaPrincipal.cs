using Quiz_Projeto_Integrador.Banco;
using Quiz_Projeto_Integrador.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Projeto_Integrador.Telas
{
    public partial class TelaPrincipal : Form
    {
        public int usuarioLogado;
        bool EhAdmin = false;

        public TelaPrincipal(int idUsuario, bool ehAdmin)
        {
            InitializeComponent();

            EhAdmin = ehAdmin;
            usuarioLogado = idUsuario;

        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuizModos(usuarioLogado).ShowDialog();
            this.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

            this.Hide();
            new PerfilDoUsuario(usuarioLogado).ShowDialog();
            this.Show();
        }

        private void btnRaking_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ranking(usuarioLogado).ShowDialog();
            this.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Historico(usuarioLogado).ShowDialog();
            this.Show();
        }
        private void btnQuiz_MouseEnter(object sender, EventArgs e)
        {
            btnQuiz.BackColor = Color.LightGreen;
        }

        private void btnPerfil_Enter(object sender, EventArgs e)
        {

        }

        private void btnRaking_MouseEnter(object sender, EventArgs e)
        {
            btnRaking.BackColor = Color.LightGreen;

        }

        private void btnPerfil_MouseEnter(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.LightGreen;
        }

        private void btnHistorico_MouseEnter(object sender, EventArgs e)
        {
            btnHistorico.BackColor = Color.LightGreen;
        }

        private void btnQuiz_MouseLeave(object sender, EventArgs e)
        {
            btnQuiz.BackColor = Color.FromArgb(133, 6, 235);
        }

        private void btnRaking_MouseLeave(object sender, EventArgs e)
        {
            btnRaking.BackColor = Color.FromArgb(133, 6, 235);
        }

        private void btnHistorico_MouseLeave(object sender, EventArgs e)
        {
            btnHistorico.BackColor = Color.FromArgb(133, 6, 235);
        }

        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(133, 6, 235);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            EhAdmin = false;
            this.Close();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.Red;
        }
        private void btnSair_MouseLeave_1(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(255, 128, 128);

        }

        private async Task TelaPrincipal_Load(object sender, EventArgs e)
        {
            if (EhAdmin)
            {
                btnTelaPergunta.Visible = true;
                lblAvisoAdmin.Visible = true;
                btnPerfil.Visible = false;
                pbPerfil.Visible = false;
                pbQuiz.Visible = false;
                btnQuiz.Visible = false;
            }
            else if (!EhAdmin)
            {
                btnTelaPergunta.Visible = false;
                lblAvisoAdmin.Visible = false;
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTelaPergunta_Click(object sender, EventArgs e)
        {
            new AdicionarPergunta().Show();
        }
    }
}
