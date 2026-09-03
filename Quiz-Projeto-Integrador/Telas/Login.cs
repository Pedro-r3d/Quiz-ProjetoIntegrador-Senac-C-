using BCrypt.Net;
using Quiz_Projeto_Integrador.Banco;
using Quiz_Projeto_Integrador.Objetos;

namespace Quiz_Projeto_Integrador.Telas
{

    public partial class Login : Form
    {
        private bool ehAdmin = false;
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

            if (txtLogarSenha.Text == "" || txtLogarNick.Text == "")
            {
                MessageBox.Show("Informações não preenchidas");
                return;
            }

            if (txtLogarNick.Text == "Admin" && txtLogarSenha.Text == "senha")
            {
                ehAdmin = true;
                MessageBox.Show("Bem vindo administrador");
                this.Hide();
                new TelaPrincipal(-1, ehAdmin).ShowDialog();
                this.Close();
                return;
            }
            var usuario = await UsuarioRepositories.ObterNickSenha(nick, senha);

            if (usuario == null || !usuario.SenhaCorreta(senha))
            {
                MessageBox.Show("Usuario ou senha incorretos");
                return;
            }
            int idUsuario = usuario.Id;

            
                this.Hide();
                new TelaPrincipal(idUsuario, ehAdmin).ShowDialog();
                this.Close();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
