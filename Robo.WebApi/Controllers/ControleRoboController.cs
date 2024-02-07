using Microsoft.AspNetCore.Mvc;
using Robo.Application.Interfaces;
using Robo.ViewModel;

namespace Robo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControleRoboController : ControllerBase
    {
        private readonly IControleRoboService _controleRoboService;
        public ControleRoboController(IControleRoboService controleRoboService)
        {
            _controleRoboService = controleRoboService;
        }

        [HttpGet("obter-estado-inicial-robo")]
        public IActionResult ObterEstadoInicialRobo()
        {
            try
            {
                return Ok(_controleRoboService.ObterEstadoInicialRobo());
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost("acionar-robo")]
        public IActionResult AcionarRobo([FromBody] ControlaRoboViewModel controlaRoboVM)
        {
            try
            {
                return Ok(_controleRoboService.AcionarRobo(controlaRoboVM));
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}