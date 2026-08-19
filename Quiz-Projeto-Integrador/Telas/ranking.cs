using Quiz_Projeto_Integrador.Banco;
using Quiz_Projeto_Integrador.Dto;
using Quiz_Projeto_Integrador.Objetos;
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
    public partial class ranking : Form
    {
        public int usuarioLogado;

        public ranking(int idUsuarioPerfil)
        {

            InitializeComponent();
            usuarioLogado = idUsuarioPerfil;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void ranking_Load(object sender, EventArgs e)
        {
            var usuarios = await UsuarioRepositories.ObterRanking();

            dgvUsuarios.DataSource = new BindingList<
                UsuarioRankingDto>((IList<
                    UsuarioRankingDto>)usuarios.ToList());

            dgvUsuarios.SelectionChanged -= dgvUsuarios_SelectionChanged;

            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                if (row.Cells["Id"].Value != null &&
           Convert.ToInt32(row.Cells["Id"].Value) == usuarioLogado)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }

            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;

        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            
        
            }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            new PerfilDoUsuario(usuarioLogado).ShowDialog();
            this.Show();
        }
    }
}
