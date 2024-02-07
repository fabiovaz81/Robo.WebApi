using Robo.Application.Interfaces;
using Robo.Domain.Enum;
using Robo.ViewModel;

namespace Robo.Application.Services
{
    public class ControleRoboService : IControleRoboService
    {
        public ControleRoboService()
        {

        }

        public EstadoRoboViewModel ObterEstadoInicialRobo()
        {
            try
            {
                var estadoInicialRobo = new EstadoRoboViewModel(MovimentoInclinacao.EmRepouso, MovimentoRotacao.EmRepouso, MovimentoCotovelo.EmRepouso, MovimentoPulso.EmRepouso);

                return estadoInicialRobo;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível obter o estado inicial do robô");
            }
        }

        public EstadoRoboViewModel AcionarRobo(ControlaRoboViewModel controlaRoboVM)
        {
            try
            {
                var robo = new Domain.Entidades.Robo(
                        (int)controlaRoboVM.EstadoAtual.IdMovimentoRotacao,
                        (int)controlaRoboVM.EstadoAtual.IdMovimentoInclinacao,
                        (int)controlaRoboVM.EstadoAtual.IdMovimentoCotoveloDireito,
                        (int)controlaRoboVM.EstadoAtual.IdMovimentoPulsoDireito,
                        (int)controlaRoboVM.EstadoAtual.IdMovimentoCotoveloEsquerdo,
                        (int)controlaRoboVM.EstadoAtual.IdMovimentoPulsoEsquerdo
                        );
                RealizarMovimentoRobo(controlaRoboVM.TipoMovimento, controlaRoboVM.EstadoNovo, robo);
                
                return controlaRoboVM.EstadoNovo;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private Domain.Entidades.Robo RealizarMovimentoRobo(TipoMovimento tipoMovimento, EstadoRoboViewModel novoEstadoVM, Domain.Entidades.Robo robo)
        {
            switch (tipoMovimento)
            {
                case TipoMovimento.CotoveloEsquerdo:
                    robo.ObterBracoPeloLado(Lado.Esquerdo).AcionarMovimentoCotovelo((int)novoEstadoVM.IdMovimentoCotoveloEsquerdo);
                    break;

                case TipoMovimento.PulsoEsquerdo:
                    robo.ObterBracoPeloLado(Lado.Esquerdo).AcionarMovimentoPulso((int)novoEstadoVM.IdMovimentoPulsoEsquerdo);
                    break;

                case TipoMovimento.CotoveloDireito:
                    robo.ObterBracoPeloLado(Lado.Direito).AcionarMovimentoCotovelo((int)novoEstadoVM.IdMovimentoPulsoDireito);
                    break;

                case TipoMovimento.PulsoDireito:
                    robo.ObterBracoPeloLado(Lado.Direito).AcionarMovimentoPulso((int)novoEstadoVM.IdMovimentoPulsoDireito);
                    break;

                case TipoMovimento.RotacaoCabeca:
                    robo.Cabeca.AcionarMovimentoRotacao((int)novoEstadoVM.IdMovimentoRotacao);
                    break;

                case TipoMovimento.InclinacaoCabeca:
                    robo.Cabeca.AcionarMovimentoInclinacao((int)novoEstadoVM.IdMovimentoInclinacao);
                    break;
                default:
                    throw new ArgumentException("Tipo do movimento inválido");
            }

            return robo;
        }
    }
}
