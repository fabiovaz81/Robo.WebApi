using Robo.ViewModel;

namespace Robo.Application.Interfaces
{
    public interface IControleRoboService
    {
        EstadoRoboViewModel AcionarRobo(ControlaRoboViewModel controlaRoboVM);
        EstadoRoboViewModel ObterEstadoInicialRobo();
    }
}
