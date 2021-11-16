//DIP = Princípio da Inversão de Dependência
namespace BasicOO.SOLID.DIP.Problema
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}