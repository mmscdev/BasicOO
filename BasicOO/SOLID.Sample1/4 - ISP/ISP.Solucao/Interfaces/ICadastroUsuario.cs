//ISP = Princípio da Segregação de Interface
namespace BasicOO.SOLID.ISP.Solucao.Interfaces
{
    public interface ICadastroUsuario
    {
        void ValidarDados();
        void Salvar();
        void EnviarEmail();
    }
}