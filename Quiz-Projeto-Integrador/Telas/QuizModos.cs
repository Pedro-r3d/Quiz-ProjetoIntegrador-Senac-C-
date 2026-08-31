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
    public partial class QuizModos : Form
    {
        private int usuarioLogado;
        private bool ehTreino;
        public QuizModos(int idUsuario)
        {
            InitializeComponent();

            usuarioLogado = idUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new QuizAlternativa(usuarioLogado,false).ShowDialog();
        }

        private void QuizModos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new QuizAlternativa(usuarioLogado,true).ShowDialog();
        }
    }
}
