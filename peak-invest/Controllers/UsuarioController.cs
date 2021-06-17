using Microsoft.AspNetCore.Mvc;
using peak_invest.Application.Interfaces;
using System;

namespace peak_invest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var result = _usuarioService.GetNomeUsuario(id);
                return Ok(result);

            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}