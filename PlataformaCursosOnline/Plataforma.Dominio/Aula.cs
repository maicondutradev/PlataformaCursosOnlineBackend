using System.Text.Json.Serialization;

namespace Plataforma.Dominio
{
    public class Aula
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? DescricaoCurta { get; set; }
        public string VideoUrl { get; set; } = string.Empty;
        public int ModuloId { get; set; }
        [JsonIgnore]
        public Modulo? Modulo { get; set; }
    }
}