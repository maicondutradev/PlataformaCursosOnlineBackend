using Plataforma.Dominio;

namespace Plataforma.Repositorio
{
    public interface ICursoRepositorio
    {
        void Adicionar(Curso curso);
        List<Curso> Listar();
        Curso ObterPorId(int id);
        void Atualizar(Curso curso);
        void Remover(int id);
    }
}