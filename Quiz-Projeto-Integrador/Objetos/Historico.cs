namespace Quiz_Projeto_Integrador.Objetos
{
    public class Historico
    {
        public Historico(
        int id,
        DateOnly dataDoQuiz,
        int pontos
            ) 
        {
            Id = id;
            DataDoQuiz = dataDoQuiz;
            Pontos = pontos;
        }
        public int Id { get; set; }
        public DateOnly DataDoQuiz { get; set; }
        public int Pontos { get; set; }
    }
}
