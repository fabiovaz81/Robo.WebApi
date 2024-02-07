using Robo.Domain.Constantes;
using Robo.Domain.Entidades;
using Robo.Domain.Enum;

namespace Robo.Domain.Tests
{
    [TestClass]
    public class MovimentoTests
    {
        [TestMethod]
        public void Construtor_ComDescricao_DeveInicializarPropriedadesCorretamente()
        {
            // Arrange
            int id = (int)MovimentoPulso.EmRepouso;
            string descricao = DescricaoMovimentoPulso.EmRepouso;

            // Act
            var movimento = new Movimento(id, descricao);

            // Assert
            Assert.AreEqual(id, movimento.Id);
            Assert.AreEqual(descricao, movimento.Descricao);
        }

        [TestMethod]
        public void Construtor_SemDescricao_DeveInicializarPropriedadeIdCorretamente()
        {
            // Arrange
            int id = (int)MovimentoCotovelo.Contraido;

            // Act
            var movimento = new Movimento(id);

            // Assert
            Assert.AreEqual(id, movimento.Id);
            Assert.IsNull(movimento.Descricao);
        }
    }

}
