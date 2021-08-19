using System;
using ByteBank;

namespace CriandoPropriasExceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException(double saldo, double valorSaque)
         : this("Tentativa de saque de " + valorSaque + " com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}