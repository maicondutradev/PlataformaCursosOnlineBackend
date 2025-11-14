namespace Plataforma.Dominio
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public List<Modulo> Modulos { get; set; } = new List<Modulo>();
        public Curso(string nome, string descricao, decimal preco, string imagemUrl)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            ImagemUrl = imagemUrl;
        }

        public Curso() { }
    }
}