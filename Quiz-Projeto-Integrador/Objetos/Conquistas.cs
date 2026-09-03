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
            int usuarioId,
            string conquista
            )
        {
            Id = id;
            UsuarioId = usuarioId;
            Conquista = conquista;
        }
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Conquista { get; set; }
    }
}
