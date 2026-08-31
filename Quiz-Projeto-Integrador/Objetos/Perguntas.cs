using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador.Objetos
{
    public class Perguntas
    {
        public Perguntas(string questao, string resposta, string tipo, string nivel, string tema, int pontos) 
        {
            Questao = questao;
            Resposta = resposta;
            Tipo = tipo;
            Nivel = nivel;
            Tema = tema;
            Pontos = pontos;
        }
        
        public string Questao { get; set; }
        public string Resposta { get; set; }
        public string Tipo { get; set; }
        public string Nivel { get; set; }            
        public string Tema { get; set; }
        public int Pontos { get; set; }
    }
}
