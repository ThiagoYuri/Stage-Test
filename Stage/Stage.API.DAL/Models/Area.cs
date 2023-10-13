namespace Stage.API.DAL.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Processo> Processos { get; set; }

    }
}