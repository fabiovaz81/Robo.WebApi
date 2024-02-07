using Robo.Domain.Enum;

namespace Robo.ViewModel
{
    public class ControlaRoboViewModel
    {
        public EstadoRoboViewModel EstadoAtual { get; set; } = new EstadoRoboViewModel();
        public EstadoRoboViewModel EstadoNovo { get; set; } = new EstadoRoboViewModel();
        public TipoMovimento TipoMovimento { get; set; }
    }
}
