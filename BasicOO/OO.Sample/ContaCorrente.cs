namespace OO.Sample
{
    public class ContaCorrente : Conta
    {
        private decimal taxaMovimento;
        public ContaCorrente() : base(30000)
        {
            SetTaxaMovimento(0.1m);
        }

        public decimal TaxaMovimento { get => taxaMovimento; set => taxaMovimento = value; }

        public void SetTaxaMovimento(decimal valor)
        {
            TaxaMovimento = valor;
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + (this.taxaMovimento * valor));
        }
        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
}
