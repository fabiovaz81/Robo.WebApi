using Robo.Application.Interfaces;
using Robo.Domain.Entidades;

namespace Robo.Application.Services
{
    public class MovimentoRoboService : IMovimentoRoboService
    {
        public MovimentoRoboService()
        {

        }

        public MovimentoRobo CarregarMovimentosRobo()
        {
            try
            {
                return new MovimentoRobo();
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível carregar movimentos do robô");
            }
        }
    }
}
