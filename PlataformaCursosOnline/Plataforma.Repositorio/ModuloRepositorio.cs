using Plataforma.Dominio;

namespace Plataforma.Repositorio
{
    public class ModuloRepositorio : IModuloRepositorio
    {
        private readonly PlataformaDbContext _context;

        public ModuloRepositorio(PlataformaDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Modulo modulo)
        {
            _context.Modulos.Add(modulo);
            _context.SaveChanges();
        }
    }
}