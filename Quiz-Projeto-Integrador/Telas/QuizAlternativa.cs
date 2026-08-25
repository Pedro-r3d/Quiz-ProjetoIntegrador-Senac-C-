using Quiz_Projeto_Integrador.Banco;
using Quiz_Projeto_Integrador.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Projeto_Integrador.Telas
{
    public partial class QuizAlternativa : Form
    {
        public QuizAlternativa()
        {
            InitializeComponent();


        }
        private List<Alternativas> perguntas;
        private int perguntaAtual = 1;
        private int pontos = 0;

        private void MostrarPergunta()
        {
            var pergunta = perguntas[perguntaAtual];

            lblPergunta.Text = pergunta.Pergunta;
        }
        private void QuizAlternativa_Load(object sender, EventArgs e)
        {

        }
    }
}

