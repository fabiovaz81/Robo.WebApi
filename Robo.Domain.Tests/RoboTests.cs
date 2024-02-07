using Robo.Domain.Entidades;
using Robo.Domain.Enum;

namespace Robo.Domain.Tests
{
    [TestClass]
    public class RoboTests
    {
        [TestMethod]
        public void Construtor_DeveInicializarCabecaEBracosCorretamente()
        {
            // Arrange
            int idMovimentoRotacao = 1;
            int idMovimentoInclinacao = 2;
            int idMovimentoCotoveloDireito = 3;
            int idMovimentoPulsoDireito = 4;
            int idMovimentoCotoveloEsquerdo = 5;
            int idMovimentoPulsoEsquerdo = 6;

            // Act
            var robo = new Entidades.Robo(idMovimentoRotacao, idMovimentoInclinacao, idMovimentoCotoveloDireito, idMovimentoPulsoDireito, idMovimentoCotoveloEsquerdo, idMovimentoPulsoEsquerdo);

            // Assert
            Assert.IsNotNull(robo.Cabeca);
            Assert.IsNotNull(robo.Bracos);
            Assert.AreEqual(idMovimentoRotacao, robo.Cabeca.Rotacao.Id);
            Assert.AreEqual(idMovimentoInclinacao, robo.Cabeca.Inclinacao.Id);

            var bracosList = robo.Bracos as List<RoboBraco>;
            Assert.IsNotNull(bracosList);
            Assert.AreEqual(2, bracosList.Count);
            Assert.AreEqual(idMovimentoCotoveloDireito, bracosList[0].Cotovelo.Id);
            Assert.AreEqual(idMovimentoPulsoDireito, bracosList[0].Pulso.Id);
            Assert.AreEqual(Lado.Direito, bracosList[0].LadoBraco);
            Assert.AreEqual(idMovimentoCotoveloEsquerdo, bracosList[1].Cotovelo.Id);
            Assert.AreEqual(idMovimentoPulsoEsquerdo, bracosList[1].Pulso.Id);
            Assert.AreEqual(Lado.Esquerdo, bracosList[1].LadoBraco);
        }

        [TestMethod]
        public void ObterBracoPeloLado_DeveRetornarBracoCorrespondente()
        {
            // Arrange
            var robo = new Entidades.Robo(1, 2, 3, 4, 5, 6);

            // Act
            var bracoDireito = robo.ObterBracoPeloLado(Lado.Direito);
            var bracoEsquerdo = robo.ObterBracoPeloLado(Lado.Esquerdo);

            // Assert
            Assert.IsNotNull(bracoDireito);
            Assert.AreEqual(Lado.Direito, bracoDireito.LadoBraco);

            Assert.IsNotNull(bracoEsquerdo);
            Assert.AreEqual(Lado.Esquerdo, bracoEsquerdo.LadoBraco);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ObterBracoPeloLado_DeveLancarExcecaoSeLadoNaoExistir()
        {
            // Arrange
            var robo = new Entidades.Robo(1, 2, 3, 4, 5, 6);

            // Act
            var bracoInvalido = robo.ObterBracoPeloLado((Lado)10);
        }
    }
}