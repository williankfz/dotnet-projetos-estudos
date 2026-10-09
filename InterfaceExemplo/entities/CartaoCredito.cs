using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceExemplo.services;

namespace InterfaceExemplo.entities
{
    public class CartaoCredito : IPagamento
    {
        public void Processar(decimal valor)
        {
            Console.WriteLine($"Pagando ${valor} no cartão de crédito");
        }
    }
}