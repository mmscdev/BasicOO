//LSP = Princípio Da Substituição de Liskov
namespace BasicOO.SOLID.LSP.Solucao
{
    public class Retangulo : Paralelogramo
    {
        public Retangulo(int altura, int largura)
            :base(altura,largura)
        {

        }
    }
}