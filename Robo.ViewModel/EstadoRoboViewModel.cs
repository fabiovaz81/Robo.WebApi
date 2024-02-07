using Robo.Domain.Enum;

namespace Robo.ViewModel
{
    public class EstadoRoboViewModel
    {
        public MovimentoInclinacao IdMovimentoInclinacao { get; set; }
        public MovimentoRotacao IdMovimentoRotacao { get; set; }
        public MovimentoCotovelo IdMovimentoCotoveloDireito { get; set; }
        public MovimentoPulso IdMovimentoPulsoDireito { get; set; }
        public MovimentoCotovelo IdMovimentoCotoveloEsquerdo{ get; set; }
        public MovimentoPulso IdMovimentoPulsoEsquerdo{ get; set; }

        public EstadoRoboViewModel(MovimentoInclinacao idMovimentoInclinacao, MovimentoRotacao idMovimentoRotacao, MovimentoCotovelo idMovimentoCotovelo, MovimentoPulso idMovimentoPulso)
        {
            IdMovimentoInclinacao = idMovimentoInclinacao;
            IdMovimentoRotacao = idMovimentoRotacao;
            IdMovimentoCotoveloEsquerdo = idMovimentoCotovelo;
            IdMovimentoPulsoEsquerdo = idMovimentoPulso;
            IdMovimentoCotoveloDireito = idMovimentoCotovelo;
            IdMovimentoPulsoDireito = idMovimentoPulso;
        }

        public EstadoRoboViewModel()
        {
            
        }
    }
}