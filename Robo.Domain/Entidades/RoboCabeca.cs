using Robo.Domain.Enum;
using Robo.Domain.Helpers;

namespace Robo.Domain.Entidades
{
    public class RoboCabeca
    {
        public Movimento Rotacao { get; set; }

        public Movimento Inclinacao { get; set; }

        public RoboCabeca(int idRotacao, int idInclinacao)
        {
            Rotacao = new Movimento(idRotacao);
            Inclinacao = new Movimento(idInclinacao);
        }

        public void AcionarMovimentoRotacao(int idNovoMovimento)
        {
            ValidarMovimentoRotacao(idNovoMovimento);

            Rotacao.Id = idNovoMovimento;
        }

        public void ValidarMovimentoRotacao(int idNovoMovimento)
        {
            if (Inclinacao.Id == (int)MovimentoInclinacao.ParaBaixo)
                throw new ArgumentException("Não é possível rotacionar a cabeça com a inclinação da cabeça para baixo");

            if (!ValidarProgressaoHelper.ValidarProgressao(Rotacao.Id, idNovoMovimento))
                throw new ArgumentException("Progressão inválida.");

            if (!EnumHelper.ValorEhUmEnumValido<MovimentoRotacao>(idNovoMovimento))
                throw new ArgumentException("Movimento inválido.");
        }

        public void AcionarMovimentoInclinacao(int idNovoMovimento)
        {
            ValidarMovimentoInclinacao(idNovoMovimento);

            Inclinacao.Id = idNovoMovimento;
        }

        public void ValidarMovimentoInclinacao(int idNovoMovimento)
        {
            if (!ValidarProgressaoHelper.ValidarProgressao(Inclinacao.Id, idNovoMovimento))
                throw new ArgumentException("Progressão inválida.");

            if (!EnumHelper.ValorEhUmEnumValido<MovimentoInclinacao>(idNovoMovimento))
                throw new ArgumentException("Movimento inválido.");
        }
    }
}
