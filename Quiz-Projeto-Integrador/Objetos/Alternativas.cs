using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador.Objetos
{
    public class Alternativas
    {
        public int Id { get; set; }
        public string Pontos {  get; set; }
        public string PerguntaId { get; set; }
        public string Correta { get; set; }
        public string EscolhaA { get; set; }
        public string EscolhaB { get; set; }
        public string EscolhaC { get; set; }
        public string EscolhaD { get; set; }
    }
}
