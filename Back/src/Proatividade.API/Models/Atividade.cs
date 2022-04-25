namespace Proatividade.API.Models
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public PrioridadeEnum Priroridade { get; set; }

        public Atividade()
        { }

        public Atividade(int id)
        {
            Id = id;
        }
    }
}