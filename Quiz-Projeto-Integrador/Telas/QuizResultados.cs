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
    public partial class QuizResultados : Form
    {
        private int pontos_;
        private int acertos_;
        public QuizResultados(int pontos, int acertos)
        {
            InitializeComponent();
            pontos_ = pontos;
            acertos_ = acertos;
        }

        private void QuizResultados_Load(object sender, EventArgs e)
        {
            lblPontosGanhos.Text = pontos_.ToString();
            lblTotalAcertos.Text = acertos_.ToString();
        }

        private void lblPontosGanhos_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAcertos_Click(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
