using Microsoft.AspNetCore.Mvc;
using Plataforma.Dominio;
using Plataforma.Servico;
using System;

namespace Plataforma.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuloController : ControllerBase
    {
        private readonly IModuloServico _servico;

        public ModuloController(IModuloServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult AdicionarModulo([FromBody] Modulo modulo)
        {
            try
            {
                _servico.Adicionar(modulo);

                return Ok(modulo);
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}