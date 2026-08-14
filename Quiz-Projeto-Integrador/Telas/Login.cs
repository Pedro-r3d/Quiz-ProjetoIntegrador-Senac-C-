using BCrypt.Net;
using Quiz_Projeto_Integrador.Banco;

namespace Quiz_Projeto_Integrador.Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtLogarNick_TextChanged(object sender, EventArgs e)
        {

        }

        public async void button1_Click(object sender, EventArgs e)
        {
            string nick = txtLogarNick.Text;
            string senha = txtLogarSenha.Text;

            string senhaCrypt = BCrypt.Net.BCrypt.HashPassword(senha, workFactor: 12);

            var usuario = await UsuarioRepositories.ObterNickSenha(nick, senha);


            if (usuario.SenhaCorreta(senhaCrypt))
            {
                this.Hide();
                new TelaPrincipal().ShowDialog();
                this.Show();
            } else { MessageBox.Show("Erro"); }
        }
    }
}
