using Quiz_Projeto_Integrador.Banco;
using Quiz_Projeto_Integrador.Objetos;

namespace Quiz_Projeto_Integrador.Telas
{
    public partial class Historico : Form
    {
        public int usuarioLogado;

        public Historico(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void Historico_Load(object sender, EventArgs e)
        {
            
            var historico = await UsuarioRepositories.PegarHistorico(usuarioLogado);
            if (historico == null || !historico.Any()) {
                MessageBox.Show("Nenhum registro de jogo");
                btnSelecionar.Enabled = false;
                return;
            }
            dgvHistorico.DataSource = historico;
        }

        public async void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(dgvHistorico.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma partida");
                return;
            }
            int quizId = (int)dgvHistorico.SelectedCells[0].Value;
            var Registro = await UsuarioRepositories.PegarIdRegistro(quizId);
            int id = Registro.HistoricoId;
            this.Hide();
            new Registro(id).ShowDialog();
            this.Show();
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

