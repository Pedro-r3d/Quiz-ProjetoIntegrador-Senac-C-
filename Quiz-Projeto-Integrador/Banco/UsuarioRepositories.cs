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
        
        public static async Task<IEnumerable<UsuarioRankingDto>> ObterRanking()
        {
            var usuarios = await ConexaoBanco.CriarConexao().QueryAsync<UsuarioRankingDto>(
                @"
                    select u.id, u.nickname,COALESCE((SELECT SUM(h2.pontos) FROM historico h2 WHERE h2.usuarioid = u.id), 0) AS pontos, count(r.id) FILTER ( WHERE r.correta = TRUE) AS corretas, count(r.id) AS quantRespostas, (

                    SELECT r2.tema
                    FROM registro r2
                    inner join historico h2
                        ON h2.id = r2.Historicoid
                    WHERE h2.usuarioid = u.id   
                    GROUP BY r2.tema
                    ORDER BY
                        COUNT(*) FILTER (
                        WHERE r2.correta = TRUE 
                            ) DESC,
                        COUNT(*) DESC
                        LIMIT 1
) AS tema
                    FROM usuario u 
                    LEFT join historico h
                    on u.id = h.usuarioid
                    LEFT join registro r
                    on h.id = r.historicoid
                    group by u.id, u.nickname
                    order by pontos desc     
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
        public static async Task<UsuarioRankingDto?> SelectPorId(int idUsuario)
        {
            var usuario = await ConexaoBanco.CriarConexao()
                .QueryFirstOrDefaultAsync<UsuarioRankingDto>(
                    @"
                     select u.id, u.nickname,COALESCE((SELECT SUM(h2.pontos) FROM historico h2 WHERE h2.usuarioid = u.id), 0) AS pontos, count(r.id) FILTER ( WHERE r.correta = TRUE) AS corretas, count(r.id) AS quantRespostas, (

                    SELECT r2.tema
                    FROM registro r2
                    inner join historico h2
                        ON h2.id = r2.Historicoid
                    WHERE h2.usuarioid = u.id   
                    GROUP BY r2.tema
                    ORDER BY
                        COUNT(*) FILTER (
                        WHERE r2.correta = TRUE 
                            ) DESC,
                        COUNT(*) DESC
                        LIMIT 1
) AS tema
                    FROM usuario u 
                    LEFT join historico h
                    on u.id = h.usuarioid
                    LEFT join registro r
                    on h.id = r.historicoid
                    WHERE u.id = @idUsuario
                    group by u.id, u.nickname
                    order by pontos desc     
            ",
                    new
                    {
                        IdUsuario = idUsuario
                    }
                );

            return usuario;

        }

        public static async Task<List<Alternativas>> PegarPerguntaAlternativas()
        {
            var pergunta = await ConexaoBanco.CriarConexao().
                QueryAsync<Alternativas>(
                @"
                SELECT p.Resposta, p.Questao, p.Pontos,p.Tema, a.EscolhaA, a.EscolhaB, a.EscolhaC, a.EscolhaD
                FROM
                Alternativas a
                INNER JOIN Pergunta p
                ON a.PerguntaId = p.Id
                "
                );
            return (List<Alternativas>)pergunta;
        }


        public static async Task<IEnumerable<Historico>> PegarHistorico(int idUsuario)
        {
            var historico = await ConexaoBanco.CriarConexao().QueryAsync<Historico>(
                @"
                SELECT 
                    h.Id,  
                    h.DataDoQuiz, 
                    h.Pontos
                FROM
                    Historico h
                INNER JOIN Usuario u
                ON u.id = h.UsuarioId
                WHERE u.id = @idUsuario
                ",
                new
                {
                    IdUsuario = idUsuario
                });
            return historico;
        }

        public static async Task<int> CriarHistorico(int usuarioId)        {
            var historicoId = await ConexaoBanco.CriarConexao()
                .QuerySingleAsync<int>(
                    @"
            INSERT INTO Historico
                (UsuarioId, DataDoQuiz, Pontos)
            VALUES
                (@UsuarioId, @DataDoQuiz, 0)
            RETURNING Id
            ",
                    new
                    {
                        UsuarioId = usuarioId,
                        DataDoQuiz = DateTime.Now.Date,
                        Pontos = 0
                    });
            return historicoId;
        }
    
        public static async Task AdicionarRegistro(int historicoId, string pergunta, string tema, bool correta, int valor)
        {
            await ConexaoBanco.CriarConexao().ExecuteAsync(
                @"
              
                     INSERT INTO Registro
                            (HistoricoId, Pergunta, Tema, Correta, Valor)
                     VALUES 
                            (@HistoricoId, @Pergunta, @Tema, @Correta, @Valor)
                    ",
                new
                {
                    HistoricoId = historicoId,
                    Pergunta = pergunta,
                    Tema = tema,
                    Correta = correta,
                    Valor = valor
                }
                );
        }

        public static async Task AdicionarPontos(int historicoId, int pontos)
        {
           var perguntas = await ConexaoBanco.CriarConexao().ExecuteAsync(
                @"
                 UPDATE Historico
                 SET Pontos = Pontos + @Pontos
                 WHERE Id = @HistoricoId
                 ",
        new
        {
            HistoricoId = historicoId,
            Pontos = pontos
        }
        
    );
          
        }


        public static async Task<Registro>PegarIdRegistro(int quizId)
        {
            var registroInfo = await ConexaoBanco.CriarConexao().QueryFirstOrDefaultAsync<Registro>(
                @"
                SELECT
                    Id,
                    HistoricoId,
                    Pergunta,
                    Tema,
                    Correta,
                    Valor
                FROM
                    Registro
                WHERE
                    HistoricoId = @quizId
                ",
                new
                {
                    QuizId = quizId
                }
                );
            return registroInfo;
        }


        public static async Task<IEnumerable<RegistroDto>>PegarRegistro(int id)
        {
            var registro = await ConexaoBanco.CriarConexao().QueryAsync<RegistroDto>(
                @"
                SELECT
                    Id,
                    HistoricoId,
                    Pergunta,
                    Tema,
                    Correta,
                    Valor
                FROM
                    Registro
                WHERE
                    HistoricoId = @Id
                ",
                new
                {
                    Id = id
                }
                );
            return registro;
        }
    }
}
