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
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Projeto_Integrador.Telas
{

    public partial class QuizAlternativa : Form
    {
        private int usuarioLogado;
        private int historicoId;
        private bool ehTreino_;


        public QuizAlternativa(int idUsuario, bool ehTreino)
        {
            InitializeComponent();

            ehTreino_ = ehTreino;

            usuarioLogado = idUsuario;
        }
        private List<Alternativas> perguntas;
        private int perguntaAtual = 0;
        private int pontos = 0;
        private int sequencia = 0;
        private int acertos = 0;
        private string nicknameUsuario;

        string respostaEscolhida = "";
        bool correta;


        public async Task MostrarPergunta()
        {

            if (ehTreino_ && perguntaAtual >= perguntas.Count)
            {

                MessageBox.Show("Quiz finalizado. reiniciando...");
                perguntaAtual = 0;

            }

            if (!ehTreino_ && perguntaAtual >= 10)
            {
                new QuizResultados(pontos, acertos).ShowDialog();
                this.Close();
                return;

            }
            var pergunta = perguntas[perguntaAtual];



            lblPergunta.Text = pergunta.Questao;
            lblPontosTotais.Text = pontos.ToString();
            lblPerguntaAtual.Text = (perguntaAtual + 1).ToString();
            lblValorPergunta.Text = pergunta.Pontos.ToString();
            lblSequencia.Text = (sequencia + 1).ToString();
            lblNickname.Text = nicknameUsuario;

            if (ehTreino_)
            {
                lblPontosTotais.Text = "";
                lblValorPergunta.Text = "";
                lblSequencia.Text = "";
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label5.Text = "";
                btnSair.Visible = true;

                if (lblPerguntaAtual.Text == "8")
                {
                    await UsuarioRepositories.DesbloquearConquista(usuarioLogado, "Preparado");
                }
            }

            rb1.Text = pergunta.EscolhaA;
            rb2.Text = pergunta.EscolhaB;
            rb3.Text = pergunta.EscolhaC;
            rb4.Text = pergunta.EscolhaD;
        }
        private async void QuizAlternativa_Load(object sender, EventArgs e)
        {
            var usuario = await UsuarioRepositories.SelectPorId(usuarioLogado);

            nicknameUsuario = usuario.Nickname;

            perguntas = (await UsuarioRepositories.PegarPerguntaAlternativas()).ToList();

            perguntaAtual = 0;
            if (!ehTreino_)
            {
                historicoId = await UsuarioRepositories.CriarHistorico(usuarioLogado);
            }
            await MostrarPergunta();

        }

        public async void button1_Click(object sender, EventArgs e)
        {


            var pergunta = perguntas[perguntaAtual];



            respostaEscolhida = "";

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

            correta = respostaEscolhida == pergunta.Resposta;

            if (!ehTreino_)
            {
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

                if (acertos == 10)
                {
                    await UsuarioRepositories.DesbloquearConquista(usuarioLogado, "Perfect");
                }

                await UsuarioRepositories.AdicionarRegistro(historicoId, pergunta.Questao, pergunta.Tema, correta, pergunta.Pontos);
                perguntaAtual++;
                await MostrarPergunta();
            }
            else
            {
                if (!correta)
                {
                    perguntaAtual = 0;
                }
                else
                {
                    perguntaAtual++;
                }
            }
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPergunta_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

