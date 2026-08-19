using Dapper;
using Quiz_Projeto_Integrador.Dto;
using Quiz_Projeto_Integrador.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Projeto_Integrador.Banco
{
    public class UsuarioRepositories
    {
        private static ConexaoBanco ConexaoBanco = new ConexaoBanco();

        public static async Task Adicionar(Usuario usuario)
        {
            // conectar com o banco e inserir funcionario 

            await ConexaoBanco.CriarConexao().QueryAsync(
                 @"
                    INSERT INTO usuario (Nome, Nickname, Senha, DataDeNascimento)
                    VALUES (@Nome, @Nickname, @Senha, @DataDeNascimento)
                ",
                   new
                   {
                       usuario.Nome,
                       usuario.Nickname,
                       usuario.Senha,
                       DataDeNascimento = usuario.DataDeNascimento.ToDateTime(TimeOnly.MinValue)
                   }
                 );
        }

<<<<<<< HEAD
        public static async Task<IEnumerable<Usuario>> ObterRanking()
=======
        public static async Task<IEnumerable<UsuarioRankingDto>> ObterRanking()
>>>>>>> 48cef0e2519159dba52fd23f4e3444e81388cc0c
        {
            var usuarios = await ConexaoBanco.CriarConexao().QueryAsync<UsuarioRankingDto>(
                @"
                    select u.nickname, h.pontos, count(r.correta or null) AS corretas, count(r.correta) AS quantRespostas, r.tema, count(r.*) as frequencia
                    from usuario u 
                    inner join historico h
                    on u.id = h.usuarioid
                    inner join registro r
                    on h.id = r.historicoid
                    group by u.nickname, h.pontos, r.tema
                    order by frequencia desc     
                 ");

            return usuarios;
        }
   
        public static async Task<Usuario> ObterNickSenha(string nickname, string senha)
        {
            var usuario = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Usuario>(
                @"
                    SELECT
                      Id,
                      Nickname,
                      Senha
                    FROM
                      usuario
                    WHERE
                      Nickname = @Nickname 
                 ",
                new
                {
                    Nickname = nickname,
                    Senha = senha
                });
            return usuario;
        }

        public static async Task<bool> ExisteNickname(string nickname)
        {
            var conexao = ConexaoBanco.CriarConexao();

            int quantidade = await conexao.ExecuteScalarAsync<int>(
                @"
                  SELECT COUNT(1)
                  FROM usuario
                  WHERE Nickname = @Nickname
                 ",
                new
                {
                    Nickname = nickname,
                });
            return quantidade > 0;
        }
        public static async Task<int?> SelectIdLogin(string nickname, string senha)
        {
            var idUsuario = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<int?>(

                @"
                  SELECT Id
                  FROM usuario
                  WHERE Nickname = @Nickname AND Senha = @Senha
                 ",
                     new
                     {
                         Nickname = nickname,
                         Senha = senha
                     }
                    ); return idUsuario;
        }
        public static async Task<Usuario?> SelectPorId(int idUsuario)
        {
            var usuario = await ConexaoBanco.CriarConexao()
                .QueryFirstOrDefaultAsync<Usuario>(
                    @"

            SELECT  
                   Senha, 
                   Nickname,
                   Nome,
                   DataDeNascimento
            FROM usuario
            WHERE Id = @IdUsuario
            ",
                    new
                    {
                        IdUsuario = idUsuario
                    }
                );

            return usuario;

        }


    }
}
