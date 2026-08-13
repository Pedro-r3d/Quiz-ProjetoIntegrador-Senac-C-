using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Quiz_Projeto_Integrador.Banco
{
    internal class ConexaoBanco
    {
        public IDbConnection CriarConexao()
        {
            return new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=admin; Trust Server Certificate=true");
        }
    }
}
