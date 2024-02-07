using Robo.Domain.Enum;
using Robo.Domain.Helpers;

namespace Robo.Domain.Entidades
{
    public class RoboBraco : Braco
    {
        public Lado LadoBraco { get; set; }

        public RoboBraco(int idMovimentoCotovelo, int idMovimentoPulso, Lado lado)
        {
            Cotovelo = new Movimento(idMovimentoCotovelo);
            Pulso = new Movimento(idMovimentoPulso);
            LadoBraco = lado;
        }

        public void AcionarMovimentoPulso(int idNovoMovimento)
        {
            ValidarMovimentoPulso(idNovoMovimento);

            Pulso.Id = idNovoMovimento;
        }

        public void ValidarMovimentoPulso(int idNovoMovimento)
        {
            if (Cotovelo.Id != (int)MovimentoCotovelo.FortementeContraido)
                throw new ArgumentException("Só é possível movimentar o pulso com o cotovelo fortemente contraído");

            if (!ValidarProgressaoHelper.ValidarProgressao(Pulso.Id, idNovoMovimento))
                throw new ArgumentException("Progressão inválida.");

            if (!EnumHelper.ValorEhUmEnumValido<MovimentoPulso>(idNovoMovimento))
                throw new ArgumentException("Movimento inválido.");
        }

        public void AcionarMovimentoCotovelo(int idNovoMovimento)
        {
            ValidarMovimentoCotovelo(idNovoMovimento);

            Cotovelo.Id = idNovoMovimento;
        }

        public void ValidarMovimentoCotovelo(int idNovoMovimento)
        {

            if (!ValidarProgressaoHelper.ValidarProgressao(Cotovelo.Id, idNovoMovimento))
                throw new ArgumentException("Progressão inválida.");

            if (!EnumHelper.ValorEhUmEnumValido<MovimentoCotovelo>(idNovoMovimento))
                throw new ArgumentException("Movimento inválido.");
        }
    }
}
