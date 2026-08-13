using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador
{
    public class Usuario
    {
        public Usuario(
            string senha,
            string nickname,
            string nome,
            DateTime dataDeNascimento) 
        { 
        Senha = senha;
        Nickname = nickname;
        Nome = nome;
        DataDeNascimento = dataDeNascimento;
        
        }
        public string Senha { get; set; } 
        public string Nickname { get; set;}
        public string Nome { get; set;}
        public DateTime DataDeNascimento { get;set; }

    }
}
