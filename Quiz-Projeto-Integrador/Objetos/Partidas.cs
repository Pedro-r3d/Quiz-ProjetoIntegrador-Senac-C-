using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador.Objetos
{
    public class Partidas
    {

        public Partidas(
        int idPergunta,
        string questao,
        string tipo,
        string nivel,
        string tema,
        int pontos
            )
        {
            IdPergunta = idPergunta;
            Questao = questao;
            Tipo = tipo;
            Nivel = nivel;
            Tema = tema;
            Pontos = pontos;
        }
        public int IdPergunta { get; set; }
        public string Questao { get; set; }
        public string Tipo { get; set; }
        public string Nivel { get; set; }
        public string Tema { get; set; }
        public int Pontos { get; set; }
               

    }
}