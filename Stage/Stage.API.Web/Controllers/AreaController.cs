using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stage.API.DAL;
using Stage.API.Web.Data.Area;
using Stage.API.Web.Services;
using System.Collections.Generic;

namespace Stage.API.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AreaController : Controller
    {

        private AreaServices _areaService;

        public AreaController(AreaServices areaService)
        {
            _areaService = areaService;

        }


        // POST: AreasController/Create
        [HttpPost]
        public async Task<ActionResult> CriarArea([FromBody] CreateAreaDto areaDto)
        {
            try {
                ReadAreaDto area = _areaService.AdicionarArea(areaDto);
                return Ok(area);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> RecuperaAreaPorId(int id)
        {
            ReadAreaDto area = _areaService.RecuperaAreaPorId(id);
            if (area != null)
                return Ok(area);
            return NotFound();
        }

        [HttpGet("all")]
        public async Task<ActionResult> RecuperaTodasArea()
        {
            IEnumerable<ReadNoDetailAreaDto> areas = _areaService.RecuperaTodosArea();
            if (areas != null)
                foreach (ReadNoDetailAreaDto res in areas)                
                    Console.WriteLine(res.Id+","+ res.Nome);
                return Ok(Json(areas));
            return NotFound();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverAreaPorId(int id)
        {
            Result result = _areaService.RemoverAreaPorId(id);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaArea(int id, [FromBody] UpdateAreaDto cinemaDto)
        {
            Result result = _areaService.AtualizaArea(id, cinemaDto);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

    }
}
