using Quiz_Projeto_Integrador.Banco;
using Quiz_Projeto_Integrador.Objetos;

namespace Quiz_Projeto_Integrador.Telas
{
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void Historico_Load(object sender, EventArgs e)
        {
            var historico = await UsuarioRepositories.PegarHistorico();
            dgvHistorico.DataSource = historico;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }
    }
}
    

