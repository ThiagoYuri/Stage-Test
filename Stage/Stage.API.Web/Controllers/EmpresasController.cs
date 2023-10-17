﻿using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stage.API.DAL;
using Stage.API.Web.Data.Empresa;
using Stage.API.Web.Services;

namespace Stage.API.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : Controller
    {

        private EmpresaServices _empresaService;

        public EmpresaController(EmpresaServices empresaService)
        {
            _empresaService = empresaService;

        }


        // POST: EmpresasController/Create
        [HttpPost]
        public async Task<ActionResult> CriarEmpresa([FromBody] CreateEmpresaDto empresaDto)
        {
            try {
                ReadEmpresaDto empresa = _empresaService.AdicionarEmpresa(empresaDto);
                return Ok(empresa);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> RecuperaEmpresaPorId(int id)
        {
            ReadEmpresaDto empresa = _empresaService.RecuperaEmpresaPorId(id);
            if (empresa != null)
                return Ok(empresa);
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverEmpresaPorId(int id)
        {
            Result result = _empresaService.RemoverEmpresaPorId(id);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEmpresa(int id, [FromBody] UpdateEmpresaDto cinemaDto)
        {
            Result result = _empresaService.AtualizaEmpresa(id, cinemaDto);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

    }
}
