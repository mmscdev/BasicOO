namespace OO.Sample
{
    public abstract class Conta
    {
        public Conta()
        {
            limite = 1000;
        }
        public Conta(decimal _limite)
        {
            limite = _limite;

        }
        private int agencia;
        public int Agencia
        {
            get { return agencia; }
            private set
            {
                if (value > 0)
                    agencia = value;
            }
        }

        private int numeroConta;
        public int NumeroConta { get => numeroConta; protected set => numeroConta = value; }

        private decimal saldo;
        public decimal Saldo { get => saldo;protected set => saldo = value; }
                
        public decimal Limite { get => limite; protected set => limite = value; }

        decimal limite;
        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public abstract void Depositar(decimal valor);
    }
}
