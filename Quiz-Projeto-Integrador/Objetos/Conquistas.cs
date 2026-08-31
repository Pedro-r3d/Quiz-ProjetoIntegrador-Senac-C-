using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador.Objetos
{
    public class Conquistas
    {
        public Conquistas(
            int id,
            bool disciplina,
            bool perfect,
            bool preparado
            )
        {
            Id = id;
            Disciplina = disciplina;
            Perfect = perfect;
            Preparado = preparado;
        }

        public int Id { get; set; }
        public bool Disciplina { get; set; }
        public bool Perfect { get; set; }
        public bool Preparado { get; set; }
    }
}
