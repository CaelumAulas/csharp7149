﻿using System;

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

        public virtual void Deposita(double valor)
        {
            Saldo = Saldo + valor;
        }

        public virtual void Saca(double valor)
        {
            Saldo = Saldo - valor;
        }
    }
}