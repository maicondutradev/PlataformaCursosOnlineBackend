using Plataforma.Dominio;
using System.Linq;

namespace Plataforma.Repositorio
{
    public class AulaRepositorio : IAulaRepositorio
    {
        private readonly PlataformaDbContext _context;

        public AulaRepositorio(PlataformaDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Aula aula)
        {
            _context.Aulas.Add(aula);
            _context.SaveChanges();
        }
    }
}