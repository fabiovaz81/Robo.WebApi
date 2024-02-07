using Robo.Domain.Entidades;
using Robo.Domain.Enum;

namespace Robo.Domain.Tests
{
    [TestClass]
    public class RoboCabecaTests
    {
        [TestMethod]
        public void AcionarMovimentoRotacao_ComInclinacaoParaCimaEProgressaoValida_DeveAlterarMovimentoRotacao()
        {
            // Arrange
            var roboCabeca = new RoboCabeca((int)MovimentoRotacao.EmRepouso, (int)MovimentoInclinacao.ParaCima);

            // Act
            roboCabeca.AcionarMovimentoRotacao((int)MovimentoRotacao.RotacaoPara45);

            // Assert
            Assert.AreEqual((int)MovimentoRotacao.RotacaoPara45, roboCabeca.Rotacao.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoRotacao_ComInclinacaoParaBaixo_DeveLancarExcecao()
        {
            // Arrange
            var roboCabeca = new RoboCabeca((int)MovimentoRotacao.EmRepouso, (int)MovimentoInclinacao.ParaBaixo);

            // Act
            roboCabeca.AcionarMovimentoRotacao((int)MovimentoRotacao.RotacaoPara45);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoRotacao_ComProgressaoInvalida_DeveLancarExcecao()
        {
            // Arrange
            var roboCabeca = new RoboCabeca((int)MovimentoRotacao.EmRepouso, (int)MovimentoInclinacao.ParaCima);

            // Act
            roboCabeca.AcionarMovimentoRotacao((int)MovimentoRotacao.RotacaoParaMenos90);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoRotacao_ComMovimentoInvalido_DeveLancarExcecao()
        {
            // Arrange
            var roboCabeca = new RoboCabeca((int)MovimentoRotacao.EmRepouso, (int)MovimentoInclinacao.ParaCima);

            // Act
            roboCabeca.AcionarMovimentoRotacao(100);
        }

        [TestMethod]
        public void AcionarMovimentoInclinacao_ComProgressaoValida_DeveAlterarMovimentoInclinacao()
        {
            // Arrange
            var roboCabeca = new RoboCabeca((int)MovimentoRotacao.EmRepouso, (int)MovimentoInclinacao.EmRepouso);

            // Act
            roboCabeca.AcionarMovimentoInclinacao((int)MovimentoInclinacao.ParaCima);

            // Assert
            Assert.AreEqual((int)MovimentoInclinacao.ParaCima, roboCabeca.Inclinacao.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoInclinacao_ComProgressaoInvalida_DeveLancarExcecao()
        {
            // Arrange
            var roboCabeca = new RoboCabeca((int)MovimentoRotacao.EmRepouso, (int)MovimentoInclinacao.ParaBaixo);

            // Act
            roboCabeca.AcionarMovimentoInclinacao((int)MovimentoInclinacao.ParaCima);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AcionarMovimentoInclinacao_ComMovimentoInvalido_DeveLancarExcecao()
        {
            // Arrange
            var roboCabeca = new RoboCabeca((int)MovimentoRotacao.EmRepouso, (int)MovimentoInclinacao.EmRepouso);

            // Act
            roboCabeca.AcionarMovimentoInclinacao(100);
        }
    }

}
