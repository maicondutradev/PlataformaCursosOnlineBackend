using Plataforma.Dominio;

namespace Plataforma.Servico
{
    public interface ICursoServico
    {
        void CriarCurso(string nome, string descricao, decimal preco);
        List<Curso> ListarCursos();
        Curso ObterPorId(int id);
        void AtualizarCurso(Curso curso);
        void DeletarCurso(int id);
    }
}