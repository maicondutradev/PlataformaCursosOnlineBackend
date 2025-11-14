using Plataforma.Dominio;
using Plataforma.Repositorio;
using System;

namespace Plataforma.Servico
{
    public class ModuloServico : IModuloServico
    {
        private readonly IModuloRepositorio _moduloRepositorio;

        public ModuloServico(IModuloRepositorio moduloRepositorio)
        {
            _moduloRepositorio = moduloRepositorio;
        }

        public void Adicionar(Modulo modulo)
        {
            if (string.IsNullOrWhiteSpace(modulo.Nome))
                throw new Exception("O nome do módulo é obrigatório.");

            if (modulo.CursoId <= 0)
                throw new Exception("O módulo deve estar associado a um curso válido.");

            _moduloRepositorio.Adicionar(modulo);
        }
    }
}