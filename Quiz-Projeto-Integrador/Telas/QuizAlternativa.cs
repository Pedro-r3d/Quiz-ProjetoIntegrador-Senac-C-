using Quiz_Projeto_Integrador.Banco;
using Quiz_Projeto_Integrador.Dto;
using Quiz_Projeto_Integrador.Objetos;
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
        private int usuarioLogado;
        private int historicoId;
       


        public QuizAlternativa(int idUsuario)
        {
            InitializeComponent();

            usuarioLogado = idUsuario;
        }
        private List<Alternativas> perguntas;
        private int perguntaAtual = 0;
        private int pontos = 0;
        private int sequencia = 0;
        private int acertos = 0;

        private void MostrarPergunta()
        {
            if (perguntaAtual == 10)
            {
                new QuizResultados(pontos,acertos).ShowDialog();
                this.Close();
                return;
            }
            var pergunta = perguntas[perguntaAtual];

            lblPergunta.Text = pergunta.Questao;
            lblPontosTotais.Text = pontos.ToString();
            lblPerguntaAtual.Text = (perguntaAtual + 1).ToString();
            lblValorPergunta.Text = pergunta.Pontos.ToString();
            lblSequencia.Text = sequencia.ToString();



            rb1.Text = pergunta.EscolhaA;
            rb2.Text = pergunta.EscolhaB;
            rb3.Text = pergunta.EscolhaC;
            rb4.Text = pergunta.EscolhaD;

        }
        private async void QuizAlternativa_Load(object sender, EventArgs e)
        {

            perguntas = await UsuarioRepositories.PegarPerguntaAlternativas();
            perguntaAtual = 0;
            historicoId = await UsuarioRepositories.CriarHistorico(usuarioLogado);

            MostrarPergunta();
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            var pergunta = perguntas[perguntaAtual];

            string respostaEscolhida = "";

            if (rb1.Checked)
            {
                respostaEscolhida = rb1.Text;
            }
            else if (rb2.Checked)
            {
                respostaEscolhida = rb2.Text;
            }
            else if (rb3.Checked)
            {
                respostaEscolhida = rb3.Text;
            }
            else if (rb4.Checked)
            {
                respostaEscolhida = rb4.Text;
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa.");
                return;
            }

            bool correta = respostaEscolhida == pergunta.Resposta;
            if (correta)
            {
                pontos += pergunta.Pontos;
                await UsuarioRepositories.AdicionarPontos(historicoId, pergunta.Pontos);
                sequencia++;
                acertos++;
            }
            else
            {
                sequencia = 0;
            }

            await UsuarioRepositories.AdicionarRegistro(historicoId, pergunta.Questao, pergunta.Tema, correta, pergunta.Pontos);


            perguntaAtual++;

            MostrarPergunta();
        }

        private void lblValorPergunta_Click(object sender, EventArgs e)
        {

        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

