using BasicOO.SOLID.ISP.Solucao.Interfaces;

//ISP = Princípio da Segregação de Interface
namespace BasicOO.SOLID.ISP.Solucao
{
    public class CadastroProduto : ICadastroProduto
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void Salvar()
        {
            // Insert tabela Produto
        }
    }
}