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
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuizAlternativa().ShowDialog();
            this.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

            this.Hide();
            new PerfilDoUsuario().ShowDialog();
            this.Show();
        }

        private void btnRaking_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {

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

     
    }
}
