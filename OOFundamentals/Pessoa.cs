using System;
using System.Diagnostics.CodeAnalysis;

namespace OOFundamentals
{
    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(string nome,int id)
        {
            Nome = nome;
            MyProperty = id;
        }
        public int MyProperty { get; set; }
        public string Nome { get; set; }

        public bool Equals([AllowNull] Pessoa other)
        {
            return MyProperty == other.MyProperty;
        }
    }
}
