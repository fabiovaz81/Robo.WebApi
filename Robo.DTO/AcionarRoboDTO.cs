using Robo.Domain.Enum;

namespace Robo.DTO
{
    public class AcionarRoboDTO
    {
        public TipoMovimento? TipoMovimento { get; set; }
        public MovimentoDTO? EstadoAtual { get; set; }
        public MovimentoDTO? NovoEstado { get; set; }
    }
}