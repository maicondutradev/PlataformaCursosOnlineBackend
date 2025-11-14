using Microsoft.AspNetCore.Mvc;
using Plataforma.Dominio;
using Plataforma.Servico;

namespace Plataforma.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly ICursoServico _servico;

        public CursoController(ICursoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Curso curso)
        {
            try
            {
                _servico.CriarCurso(curso.Nome, curso.Descricao, curso.Preco, curso.ImagemUrl);
                return Ok(new { mensagem = "Curso criado com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servico.ListarCursos());
        }

        [HttpGet("{id}")]
        public ActionResult Obter(int id)
        {
            var curso = _servico.ObterPorId(id);

            if (curso == null)
                return NotFound();

            return Ok(curso);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Curso curso)
        {
            curso.Id = id;

            try
            {
                _servico.AtualizarCurso(curso);
                return Ok(new { mensagem = "Curso atualizado com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _servico.DeletarCurso(id);
            return NoContent();
        }
    }
}