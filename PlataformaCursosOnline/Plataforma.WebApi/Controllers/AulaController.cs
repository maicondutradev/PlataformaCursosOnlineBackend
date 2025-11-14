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
        [HttpPut("{id}")]
        public IActionResult AtualizarAula(int id, [FromBody] Aula aula)
        {
            if (id != aula.Id)
            {
                return BadRequest(new { erro = "ID da rota difere do ID do objeto." });
            }

            try
            {
                _servico.Atualizar(aula);
                return Ok(aula);
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverAula(int id)
        {
            try
            {
                _servico.Remover(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }
    }
}