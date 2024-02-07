namespace Robo.Domain.Helpers
{
    public static class EnumHelper
    {
        public static bool ValorEhUmEnumValido<TEnum>(int valor) where TEnum : System.Enum
        {
            return System.Enum.IsDefined(typeof(TEnum), valor);
        }
    }
}
