﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace third
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double x) {
            Saldo = Saldo + x;
        }

        public void Saque(double x)
        {
            Saldo = Saldo - x -5;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
                
        }

    }
}
