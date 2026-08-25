namespace Quiz_Projeto_Integrador.Objetos
{
    public class Registro
    {
        public Registro(
            string pergunta,
            string tema,
            bool correta,
            int valor
            ) 
        {
            Pergunta = pergunta;
            Tema = tema;
            Correta = correta;
            Valor = valor;
        }
        public string Pergunta { get; set; }
        public string Tema { get; set; }
        public bool Correta { get; set; }
        public int Valor { get; set; }
    }
}
