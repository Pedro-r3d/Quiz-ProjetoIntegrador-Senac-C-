using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador
{
    public class Usuario
    {
        public Usuario()
        {
        }
       
        public Usuario(
            string senha,
            string nickname,
            string nome,
            DateOnly dataDeNascimento)
        {
            Senha = senha;
            Nickname = nickname;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
        }


        public Usuario(
            int id,
            string nickname,
            string senha)
        { 
        Id = id;
        Senha = senha;
        Nickname = nickname;
        }

        public int Id { get; set; }
        public string Senha { get; set; } 
        public string Nickname { get; set;}
        public string Nome { get; set;}
        public DateOnly DataDeNascimento { get;set; }

        public bool SenhaCorreta(string senhaDigitada)
        {
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, this.Senha);
        }
    }
}
