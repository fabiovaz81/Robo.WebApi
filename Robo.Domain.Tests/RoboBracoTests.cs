using Robo.Domain.Entidades;
using Robo.Domain.Enum;

namespace Robo.Domain.Tests
{
    [TestClass]
    public class RoboBracoTests
    {
        [TestMethod]
        public void AcionarMovimentoPulso_ComCotoveloFortementeContraidoEProgressaoValida_DeveAlterarMovimentoPulso()
        {
            // Arrange
            var roboBraco = new RoboBraco((int)MovimentoCotovelo.FortementeContraido, (int)MovimentoPulso.EmRepouso, Lado.Direito);

            // Act
            roboBraco.AcionarMovimentoPulso((int)MovimentoPulso.RotacaoPara45);

            // Assert
            Assert.AreEqual((int)MovimentoPulso.RotacaoPara45, roboBraco.Pulso.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoPulso_ComCotoveloNaoFortementeContraido_DeveLancarExcecao()
        {
            // Arrange
            var roboBraco = new RoboBraco((int)MovimentoCotovelo.Contraido, (int)MovimentoPulso.EmRepouso, Lado.Direito);

            // Act
            roboBraco.AcionarMovimentoPulso((int)MovimentoPulso.RotacaoPara45);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoPulso_ComProgressaoInvalida_DeveLancarExcecao()
        {
            // Arrange
            var roboBraco = new RoboBraco((int)MovimentoCotovelo.FortementeContraido, (int)MovimentoPulso.EmRepouso, Lado.Direito);

            // Act
            roboBraco.AcionarMovimentoPulso((int)MovimentoPulso.RotacaoParaMenos90);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoPulso_ComMovimentoInvalido_DeveLancarExcecao()
        {
            // Arrange
            var roboBraco = new RoboBraco((int)MovimentoCotovelo.FortementeContraido, (int)MovimentoPulso.EmRepouso, Lado.Direito);

            // Act
            roboBraco.AcionarMovimentoPulso(100);
        }

        [TestMethod]
        public void AcionarMovimentoCotovelo_ComProgressaoValida_DeveAlterarMovimentoCotovelo()
        {
            // Arrange
            var roboBraco = new RoboBraco((int)MovimentoCotovelo.EmRepouso, (int)MovimentoPulso.EmRepouso, Lado.Direito);

            // Act
            roboBraco.AcionarMovimentoCotovelo((int)MovimentoCotovelo.LevementeContraido);

            // Assert
            Assert.AreEqual((int)MovimentoCotovelo.LevementeContraido, roboBraco.Cotovelo.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoCotovelo_ComProgressaoInvalida_DeveLancarExcecao()
        {
            // Arrange
            var roboBraco = new RoboBraco((int)MovimentoCotovelo.EmRepouso, (int)MovimentoPulso.EmRepouso, Lado.Direito);

            // Act
            roboBraco.AcionarMovimentoCotovelo((int)MovimentoCotovelo.FortementeContraido);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoCotovelo_ComMovimentoInvalido_DeveLancarExcecao()
        {
            // Arrange
            var roboBraco = new RoboBraco((int)MovimentoCotovelo.EmRepouso, (int)MovimentoPulso.EmRepouso, Lado.Direito);

            // Act
            roboBraco.AcionarMovimentoCotovelo(100);
        }
    }

}
