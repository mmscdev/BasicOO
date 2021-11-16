namespace OO.Sample
{
    public class ContaPoupança : Conta, ITributo
    {
        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }

        public decimal CalcularTributo()
        {
            return base.Saldo * 0.02m;
        }
    }
}
