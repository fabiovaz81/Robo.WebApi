namespace Robo.Domain.Helpers
{
    public static class ValidarProgressaoHelper
    {
        public static bool ValidarProgressao(int estadoAtual, int novoEstado)
        {
            return Math.Abs(novoEstado - estadoAtual) == 1;
        }
    }
}
