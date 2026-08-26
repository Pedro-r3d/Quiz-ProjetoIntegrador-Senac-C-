using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador.Dto
{
    public class RegistroDto
    {
        public string Pergunta { get; set; }
        public string Tema { get; set; }
        public bool Correta { get; set; }
        public int Valor { get; set; }
    }
}
