using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.entities
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string? Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string? titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string? titular, double saldo) : this(numero, titular)
        {
            Deposito(saldo);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}