using Plataforma.Dominio;
using Plataforma.Repositorio;
using System;

namespace Plataforma.Servico
{
    public class AulaServico : IAulaServico
    {
        private readonly IAulaRepositorio _aulaRepositorio;

        public AulaServico(IAulaRepositorio aulaRepositorio)
        {
            _aulaRepositorio = aulaRepositorio;
        }

        public void Adicionar(Aula aula)
        {
            if (string.IsNullOrWhiteSpace(aula.Nome))
                throw new Exception("O nome da aula é obrigatório.");

            if (string.IsNullOrWhiteSpace(aula.VideoUrl))
                throw new Exception("A URL do vídeo é obrigatória.");

            if (aula.CursoId <= 0)
                throw new Exception("A aula deve estar associada a um curso válido.");

            _aulaRepositorio.Adicionar(aula);
        }
    }
}