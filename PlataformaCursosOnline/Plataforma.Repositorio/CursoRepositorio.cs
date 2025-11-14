using Microsoft.EntityFrameworkCore;
using Plataforma.Dominio;

namespace Plataforma.Repositorio
{
    public class CursoRepositorio : ICursoRepositorio
    {
        private readonly PlataformaDbContext _context;

        public CursoRepositorio(PlataformaDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
        }

        public List<Curso> Listar()
        {
            return _context.Cursos.ToList();
        }

        public Curso ObterPorId(int id)
        {
            return _context.Cursos
                   .Include(c => c.Aulas)
                   .FirstOrDefault(c => c.Id == id);
        }
        public void Atualizar(Curso curso)
        {
            _context.Cursos.Update(curso);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            var curso = ObterPorId(id);
            if (curso != null)
            {
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
            }
        }
    }
}