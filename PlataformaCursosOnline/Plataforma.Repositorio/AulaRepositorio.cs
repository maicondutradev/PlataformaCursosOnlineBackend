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
        public Aula ObterPorId(int id)
        {
            return _context.Aulas.Find(id);
        }

        public void Atualizar(Aula aula)
        {
            _context.Aulas.Update(aula);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var aula = ObterPorId(id);
            if (aula != null)
            {
                _context.Aulas.Remove(aula);
                _context.SaveChanges();
            }
        }
    }
}