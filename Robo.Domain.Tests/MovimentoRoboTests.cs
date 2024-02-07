using Robo.Domain.Entidades;

namespace Robo.Domain.Tests
{
    [TestClass]
    public class MovimentoRoboTests
    {
        [TestMethod]
        public void InicializarMovimentos_DeveInicializarMovimentosBracoECabecaCorretamente()
        {
            // Arrange
            var movimentoRobo = new MovimentoRobo();

            // Act
            movimentoRobo.InicializarMovimentos();

            // Assert
            Assert.IsNotNull(movimentoRobo.MovimentosCotovelo);
            Assert.IsNotNull(movimentoRobo.MovimentosPulso);
            Assert.IsNotNull(movimentoRobo.MovimentosRotacao);
            Assert.IsNotNull(movimentoRobo.MovimentosInclinacao);

            Assert.AreEqual(4, movimentoRobo.MovimentosCotovelo.Count);
            Assert.AreEqual(7, movimentoRobo.MovimentosPulso.Count);
            Assert.AreEqual(5, movimentoRobo.MovimentosRotacao.Count);
            Assert.AreEqual(3, movimentoRobo.MovimentosInclinacao.Count);
        }

        [TestMethod]
        public void InicializarCotovelo_DeveInicializarMovimentosCotoveloCorretamente()
        {
            // Arrange
            var movimentoRobo = new MovimentoRobo();

            // Act
            movimentoRobo.InicializarCotovelo();

            // Assert
            Assert.IsNotNull(movimentoRobo.MovimentosCotovelo);
            Assert.AreEqual(4, movimentoRobo.MovimentosCotovelo.Count);
            Assert.IsTrue(movimentoRobo.MovimentosCotovelo.All(m => m.Id > 0));
        }

        [TestMethod]
        public void InicializarPulso_DeveInicializarMovimentosPulsoCorretamente()
        {
            // Arrange
            var movimentoRobo = new MovimentoRobo();

            // Act
            movimentoRobo.InicializarPulso();

            // Assert
            Assert.IsNotNull(movimentoRobo.MovimentosPulso);
            Assert.AreEqual(7, movimentoRobo.MovimentosPulso.Count);
            Assert.IsTrue(movimentoRobo.MovimentosPulso.All(m => m.Id > 0));
        }

        [TestMethod]
        public void InicializarRotacao_DeveInicializarMovimentosRotacaoCorretamente()
        {
            // Arrange
            var movimentoRobo = new MovimentoRobo();

            // Act
            movimentoRobo.InicializarRotacao();

            // Assert
            Assert.IsNotNull(movimentoRobo.MovimentosRotacao);
            Assert.AreEqual(5, movimentoRobo.MovimentosRotacao.Count);
            Assert.IsTrue(movimentoRobo.MovimentosRotacao.All(m => m.Id > 0));
        }

        [TestMethod]
        public void IniciliazarInclinacao_DeveInicializarMovimentosInclinacaoCorretamente()
        {
            // Arrange
            var movimentoRobo = new MovimentoRobo();

            // Act
            movimentoRobo.IniciliazarInclinacao();

            // Assert
            Assert.IsNotNull(movimentoRobo.MovimentosInclinacao);
            Assert.AreEqual(3, movimentoRobo.MovimentosInclinacao.Count);
            Assert.IsTrue(movimentoRobo.MovimentosInclinacao.All(m => m.Id > 0));
        }
    }
}