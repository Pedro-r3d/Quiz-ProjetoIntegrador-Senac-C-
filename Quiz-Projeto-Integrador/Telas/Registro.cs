using Quiz_Projeto_Integrador.Banco;
using Quiz_Projeto_Integrador.Dto;
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
    public partial class Registro : Form
    {
        public int IdHistorico {  get; set; }

        public Registro(int idHistorico)
        {
            InitializeComponent();

            this.IdHistorico = idHistorico;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Registro_Load(object sender, EventArgs e)
        {
            var registro = await UsuarioRepositories.PegarRegistro(IdHistorico);
            dgvRegistro.DataSource = new BindingList<RegistroDto>((IList<RegistroDto>)registro.ToList());
            
            var teste = await UsuarioRepositories.PegarIdRegistro(IdHistorico);
            int corretasQuant = 0;
            foreach (var pergunta in registro)
            {
                if (pergunta.Correta == true)
                {
                    corretasQuant++;
                }

            }
            lblAcertos.Text = corretasQuant.ToString();


        }
    }
}
