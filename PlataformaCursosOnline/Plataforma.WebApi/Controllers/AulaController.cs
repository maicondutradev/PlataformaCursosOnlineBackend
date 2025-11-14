using Microsoft.AspNetCore.Mvc;
using Plataforma.Dominio;
using Plataforma.Servico;
using System;

namespace Plataforma.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AulaController : ControllerBase
    {
        private readonly IAulaServico _servico;

        public AulaController(IAulaServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult AdicionarAula([FromBody] Aula aula)
        {
            try
            {
                _servico.Adicionar(aula);

                return Ok(aula);
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}