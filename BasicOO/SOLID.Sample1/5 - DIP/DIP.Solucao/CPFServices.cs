using BasicOO.SOLID.DIP.Solucao.Interfaces;

//DIP = Princ�pio da Invers�o de Depend�ncia
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