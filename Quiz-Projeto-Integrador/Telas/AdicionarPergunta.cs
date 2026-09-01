using Quiz_Projeto_Integrador.Banco;
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
    public partial class AdicionarPergunta : Form
    {
        public AdicionarPergunta()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string questao = txtQuestao.Text;
            string resposta = txtResposta.Text;
            string nivel = rbDificil.Checked ? "Dificil" : rbMedio.Checked ? "Medio" : "Facil";
            string tema = rbCsharp.Checked ? "C#" : rbJava.Checked ? "Java" : "SQL";
            int pontos = (int)nudPontos.Value;

            int perguntaId = await UsuarioRepositories.AdicionarPergunta(
            questao,
            resposta,
            nivel,
            tema,
            pontos);

            await UsuarioRepositories.AdicionarAlternativas(
                perguntaId,
                txtAlternativaA.Text,
                txtAlternativaB.Text,
                txtAlternativaC.Text,
                txtAlternativaD.Text
                );
            MessageBox.Show("Adicionado com sucesso");
            this.Close();
        }

        private void AdicionarPergunta_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
