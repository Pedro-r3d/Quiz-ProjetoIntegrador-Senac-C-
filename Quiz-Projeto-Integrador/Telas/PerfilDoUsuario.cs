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
    public partial class PerfilDoUsuario : Form
    {

        public int usuarioLogado;
        public PerfilDoUsuario(int idUsuario) { 
            InitializeComponent();

            usuarioLogado = idUsuario;
        
        }

        private async void PerfilDoUsuario_Load(object sender, EventArgs e)
        {
            var usuario = await UsuarioRepositories.SelectPorId(usuarioLogado);

            lblPontos.Text = usuario.Pontos.ToString();
            lblRespostas.Text = usuario.QuantRespostas.ToString();
            lblAcertos.Text = usuario.Corretas.ToString();
            lblNickname.Text = usuario.Nickname;
            lblTema.Text = usuario.Tema;

            var conquista = await UsuarioRepositories.VerificarConquistas(usuarioLogado);

            if (conquista != null)
            {
                if (conquista.Conquista != "Perfect")
                {
                    pcbPerfect.Visible = false;
                }

                if (conquista.Conquista != "Preparado")
                {
                    pcbPreparado.Visible = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPontos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConquistas_Click(object sender, EventArgs e)
        {

        }

       
        private void lblNickname_Click(object sender, EventArgs e)
        {

        }
    }
}
