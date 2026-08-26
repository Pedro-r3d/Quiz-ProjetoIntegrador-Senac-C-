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

        public TelaPrincipal(int idUsuario)
        {
            InitializeComponent();

            usuarioLogado = idUsuario;
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuizAlternativa(usuarioLogado).ShowDialog();
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
            new Historico().ShowDialog();
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
            btnQuiz.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void btnRaking_MouseLeave(object sender, EventArgs e)
        {
            btnRaking.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void btnHistorico_MouseLeave(object sender, EventArgs e)
        {
            btnHistorico.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.LightCoral;
        }
        private void btnSair_MouseLeave_1(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromKnownColor(KnownColor.Control);

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
