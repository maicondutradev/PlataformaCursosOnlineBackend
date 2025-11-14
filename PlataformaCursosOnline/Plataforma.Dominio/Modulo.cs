using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Plataforma.Dominio
{
    public class Modulo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int CursoId { get; set; }
        [JsonIgnore]
        public Curso? Curso { get; set; }
        public List<Aula> Aulas { get; set; } = new List<Aula>();
    }
}