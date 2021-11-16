//DIP = Princ�pio da Invers�o de Depend�ncia
namespace BasicOO.SOLID.DIP.Solucao.Interfaces
{
    public interface IEmailServices
    {
        bool IsValid(string email);
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}