using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stage.API.DAL;
using Stage.API.Web.Data.Processo;
using Stage.API.Web.Services;

namespace Stage.API.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessoController : Controller
    {

        private ProcessoServices _processoService;

        public ProcessoController(ProcessoServices processoService)
        {
            _processoService = processoService;

        }


        // POST: ProcessosController/Create
        [HttpPost]
        public async Task<ActionResult> CriarProcesso([FromBody] CreateProcessoDto processoDto)
        {
            try {
                ReadProcessoDto processo = _processoService.AdicionarProcesso(processoDto);
                return Ok(processo);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> RecuperaProcessoPorId(int id)
        {
            ReadProcessoDto processo = _processoService.RecuperaProcessoPorId(id);
            if (processo != null)
                return Ok(processo);
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverProcessoPorId(int id)
        {
            Result result = _processoService.RemoverProcessoPorId(id);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaProcesso(int id, [FromBody] UpdateProcessoDto cinemaDto)
        {
            Result result = _processoService.AtualizaProcesso(id, cinemaDto);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

    }
}
