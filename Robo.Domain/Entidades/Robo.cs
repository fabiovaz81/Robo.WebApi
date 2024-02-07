using Robo.Domain.Enum;

namespace Robo.Domain.Entidades
{
    public class Robo
    {
        public RoboCabeca Cabeca { get; set; }

        public IEnumerable<RoboBraco> Bracos { get; set; }

        public Robo(int idMovimentoRotacao, int idMovimentoInclinacao, int idMovimentoCotoveloDireito, int idMovimentoPulsoDireito, int idMovimentoCotoveloEsquerdo, int idMovimentoPulsoEsquerdo)
        {
            Cabeca = new RoboCabeca(idMovimentoRotacao, idMovimentoInclinacao);
            Bracos = new List<RoboBraco>
            {
                new RoboBraco(idMovimentoCotoveloDireito, idMovimentoPulsoDireito, Lado.Direito),

                new RoboBraco(idMovimentoCotoveloEsquerdo, idMovimentoPulsoEsquerdo, Lado.Esquerdo),
            };
        }

        public RoboBraco ObterBracoPeloLado(Lado lado)
        {
            var braco = Bracos.FirstOrDefault(braco => braco.LadoBraco == lado);

            if (braco is null)
                throw new ArgumentException("Braço não encontrado");

            return braco;
        }
    }
}
