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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }




        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Guardar informações
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string nickname = txtNickname.Text;

       //Verificar se campos foram preenchidos
            if (txtNome.Text == "" || txtSenha.Text == "" || txtNickname.Text == "")
            {
                MessageBox.Show("Informações não preenchidas", "Cadastro não realizado", MessageBoxButtons.OK);
                return;
            } 
        
        // Verificar se senha e confirmar senha são iguais
            if(txtConfirmarSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("Senhas diferentes", "Confirmar senha diferente", MessageBoxButtons.OK);
                return;
            }

         // caso nada esteja errado, manda pro banco de dados
            else
            {
                DateTime dataDeNascimento = dtpDataDeNascimento.Value;
                var usuario = new Usuario(senha, nickname, nome, dataDeNascimento);

                await UsuarioRepositories.Adicionar(usuario);
                MessageBox.Show("Cadastro realizado", "Nova conta criada", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
