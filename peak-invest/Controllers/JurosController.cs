using Microsoft.AspNetCore.Mvc;
using peak_invest.Application.Interfaces;
using peak_invest.Application.ViewModel;
using System;

namespace peak_invest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;

        public JurosController(IJurosService jurosService)
            
        {
            _jurosService = jurosService;
        }

        [HttpPost("calcula")]
        public IActionResult Get([FromQuery] CalculaJurosVm calculaJuros)
        {
            try
            {
                var result = _jurosService.CalculaJuros(calculaJuros);
                return Ok(result);
            }
            catch(Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}