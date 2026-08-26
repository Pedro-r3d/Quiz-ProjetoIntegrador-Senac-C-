namespace Quiz_Projeto_Integrador.Objetos
{
    public class Registro
    {
        public Registro(
            int id,
            int historicoId,
            string pergunta,
            string tema,
            bool correta,
            int valor
            ) 
        {
            Id = id;
            HistoricoId = historicoId;
            Pergunta = pergunta;
            Tema = tema;
            Correta = correta;
            Valor = valor;
        }
        public int Id { get; set; }
        public int HistoricoId { get; set; }
        public string Pergunta { get; set; }
        public string Tema { get; set; }
        public bool Correta { get; set; }
        public int Valor { get; set; }

    }
}
