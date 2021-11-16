namespace OO.Sample
{
    public class Relatorio
    {
        public decimal SaldoGeral { get; private set; }
        public decimal TributoGeral { get; private set; }
        public void SomarTributos(ITributo conta)
        {
            this.TributoGeral += conta.CalcularTributo();
        }

        //Exemplos de polimorfismo
        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }
        public void SomarValor(decimal valor)
        {
            this.SaldoGeral += valor;
        }
        public void SomarValor(decimal valor, decimal valor2)
        {
            this.SaldoGeral += valor + valor2;
        }
    }
}
