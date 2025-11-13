using Plataforma.Dominio;
using Plataforma.Repositorio;

namespace Plataforma.Servico
{
    public class CursoServico : ICursoServico
    {
        private readonly ICursoRepositorio _repositorio;

        public CursoServico(ICursoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void CriarCurso(string nome, string descricao, decimal preco)
        {
            var curso = new Curso(nome, descricao, preco);
            _repositorio.Adicionar(curso);
        }

        public List<Curso> ListarCursos() => _repositorio.Listar();

        public Curso ObterPorId(int id)
        {
            return _repositorio.ObterPorId(id);
        }

        public void AtualizarCurso(Curso curso)
        {
            _repositorio.Atualizar(curso);
        }

        public void DeletarCurso(int id) => _repositorio.Remover(id);
    }
}