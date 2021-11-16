using System;

namespace OO.Sample
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 10;
            if (a > 40)
                Console.WriteLine(a);
            ContaCorrente cc = new ContaCorrente();
            ContaPoupança cp = new ContaPoupança();
            cc.Depositar(1000);
            cp.Depositar(1000);
            cc.Depositar(200);
            cp.Depositar(200);
            var rel = new Relatorio();
            rel.Somar(cc);
            rel.Somar(cp);
            rel.SomarTributos(cp);
            Console.WriteLine(cp.Saldo);
            Console.WriteLine(rel.SaldoGeral);
            Console.WriteLine(rel.TributoGeral);
            Console.Read();
        }
    }
}

