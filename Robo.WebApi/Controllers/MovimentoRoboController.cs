using Microsoft.AspNetCore.Mvc;
using Robo.Application.Interfaces;

namespace Robo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentoRoboController : ControllerBase
    {
        private IMovimentoRoboService _movimentoRoboService;
        public MovimentoRoboController(IMovimentoRoboService movimentoRoboService)
        {
            _movimentoRoboService = movimentoRoboService;
        }


        [HttpGet("carregar-movimentos-robo")]
        public IActionResult CarregarMovimentosRobo()
        {
            try
            {
                return Ok(_movimentoRoboService.CarregarMovimentosRobo());
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }
    }
}
