using Robo.Domain.Constantes;
using Robo.Domain.Enum;

namespace Robo.Domain.Entidades
{
    public class MovimentoRobo
    {
        public List<Movimento>? MovimentosCotovelo { get; set; }
        public List<Movimento>? MovimentosPulso { get; set; }
        public List<Movimento>? MovimentosRotacao { get; set; }
        public List<Movimento>? MovimentosInclinacao { get; set; }


        public MovimentoRobo() => InicializarMovimentos();

        public void InicializarMovimentos()
        {
            InicializarMovimentosBraco();
            InicializarMovimentosCabeca();
        }

        public void InicializarMovimentosBraco()
        {
            InicializarCotovelo();
            InicializarPulso();
        }

        public void InicializarMovimentosCabeca()
        {
            InicializarRotacao();
            IniciliazarInclinacao();
        }

        public void InicializarCotovelo()
        {
            MovimentosCotovelo = new List<Movimento>
            {
                new Movimento((int)MovimentoCotovelo.EmRepouso, DescricaoMovimentoCotovelo.EmRepouso),
                new Movimento((int)MovimentoCotovelo.LevementeContraido, DescricaoMovimentoCotovelo.LevementeContraido),
                new Movimento((int)MovimentoCotovelo.Contraido, DescricaoMovimentoCotovelo.Contraido),
                new Movimento((int)MovimentoCotovelo.FortementeContraido, DescricaoMovimentoCotovelo.FortementeContraido)
            };
        }

        public void InicializarPulso()
        {
            MovimentosPulso = new List<Movimento>{
                new Movimento((int)MovimentoPulso.RotacaoParaMenos90, DescricaoMovimentoPulso.RotacaoParaMenos90),
                new Movimento((int)MovimentoPulso.RotacaoParaMenos45, DescricaoMovimentoPulso.RotacaoParaMenos45),
                new Movimento((int)MovimentoPulso.EmRepouso, DescricaoMovimentoPulso.EmRepouso),
                new Movimento((int)MovimentoPulso.RotacaoPara45, DescricaoMovimentoPulso.RotacaoPara45),
                new Movimento((int)MovimentoPulso.RotacaoPara90, DescricaoMovimentoPulso.RotacaoPara90),
                new Movimento((int)MovimentoPulso.RotacaoPara135, DescricaoMovimentoPulso.RotacaoPara135),
                new Movimento((int)MovimentoPulso.RotacaoPara180, DescricaoMovimentoPulso.RotacaoPara180),
            };
        }

        public void InicializarRotacao()
        {
            MovimentosRotacao = new List<Movimento>
            {
                new Movimento((int)MovimentoRotacao.RotacaoParaMenos90, DescricaoMovimentoRotacao.RotacaoParaMenos90),
                new Movimento((int)MovimentoRotacao.RotacaoParaMenos45, DescricaoMovimentoRotacao.RotacaoParaMenos45),
                new Movimento((int)MovimentoRotacao.EmRepouso, DescricaoMovimentoRotacao.EmRepouso),
                new Movimento((int)MovimentoRotacao.RotacaoPara45, DescricaoMovimentoRotacao.RotacaoPara45),
                new Movimento((int)MovimentoRotacao.RotacaoPara90, DescricaoMovimentoRotacao.RotacaoPara90),

            };
        }

        public void IniciliazarInclinacao()
        {
            MovimentosInclinacao = new List<Movimento>
            {
                new Movimento((int)MovimentoInclinacao.ParaCima, DescricaoMovimentoInclinacao.ParaCima),
                new Movimento((int)MovimentoInclinacao.EmRepouso, DescricaoMovimentoInclinacao.EmRepouso),
                new Movimento((int)MovimentoInclinacao.ParaBaixo, DescricaoMovimentoInclinacao.ParaBaixo),
            };
        }
    }
}
