using BasicOO.SOLID.DIP.Solucao.Interfaces;

//DIP = Princípio da Inversão de Dependência
namespace BasicOO.SOLID.DIP.Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}