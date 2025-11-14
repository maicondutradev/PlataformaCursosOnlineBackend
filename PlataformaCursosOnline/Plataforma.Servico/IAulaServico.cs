using Plataforma.Dominio;

namespace Plataforma.Servico
{
    public interface IAulaServico
    {
        void Adicionar(Aula aula);
        void Atualizar(Aula aula);
        void Remover(int id);
    }
}