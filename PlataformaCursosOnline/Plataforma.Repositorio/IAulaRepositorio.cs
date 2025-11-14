using Plataforma.Dominio;

namespace Plataforma.Repositorio
{
    public interface IAulaRepositorio
    {
        void Adicionar(Aula aula);
        Aula ObterPorId(int id);
        void Atualizar(Aula aula);
        void Remover(int id);
    }
}