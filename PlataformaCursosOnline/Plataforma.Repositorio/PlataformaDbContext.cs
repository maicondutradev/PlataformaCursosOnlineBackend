using Microsoft.EntityFrameworkCore;
using Plataforma.Dominio;

namespace Plataforma.Repositorio
{
    public class PlataformaDbContext : DbContext
    {
        public PlataformaDbContext(DbContextOptions<PlataformaDbContext> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
    }
}