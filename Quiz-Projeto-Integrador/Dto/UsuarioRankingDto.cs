using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador.Dto
{
    public class UsuarioRankingDto
    {
        public  UsuarioRankingDto(
            string nickname,
            int pontos,
            int corretas,
            int quantRespostas,
            string tema,
            int frequencia          
            ) 
        { 
        Nickname = nickname;
        Pontos = pontos;
        Corretas = corretas;
        QuantRespostas = quantRespostas;
        Tema = tema;
        Frequencia = frequencia;
        }

        public string Nickname { get; set; }
        public int Pontos { get; set; }
        public int Corretas { get; set; }
        public int QuantRespostas { get; set; }      
        public string Tema { get; set; }
        public int Frequencia { get; set; }


        
    }
}
