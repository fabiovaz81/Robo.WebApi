namespace Robo.Domain.Entidades
{
    public class Movimento
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }

        public Movimento(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public Movimento(int id)
        {
            Id = id;
        }
    }
}
