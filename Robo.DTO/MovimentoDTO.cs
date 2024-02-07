using Robo.Domain.Enum;

namespace Robo.DTO
{
    public class MovimentoDTO
    {
        public MovimentoInclinacao IdMovimentoInclinacao { get; set; }
        public MovimentoRotacao IdMovimentoRotacao { get; set; }
        public MovimentoCotovelo IdMovimentoCotovelo { get; set; }
        public MovimentoPulso IdMovimentoPulso { get; set; }
    }
}
