using System;

namespace Banco
{
    public class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saca(double valor)
        {
            Saldo = Saldo - valor;
        }
    }
}