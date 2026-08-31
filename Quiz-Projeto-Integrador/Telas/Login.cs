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

            var usuario = await UsuarioRepositories.ObterNickSenha(nick, senha);

            if (txtLogarSenha.Text == "" || txtLogarNick.Text == "")
            {
                MessageBox.Show("Informações não preenchidas");
                return;
            }
         
            if (usuario == null || !usuario.SenhaCorreta(senha))
            {
                MessageBox.Show("Usuario ou senha incorretos");
                return;
            }

            if (usuario.SenhaCorreta(senha))
            {
                int idUsuario = usuario.Id;
                this.Hide();
                new TelaPrincipal(idUsuario).ShowDialog();
                this.Show();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
