using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceExemplo.services;

namespace InterfaceExemplo.entities
{
    public class Pix : IPagamento
    {
        public void Processar(decimal valor)
        {
            Console.WriteLine($"Pagando R$ {valor} via Pix...");
        }
    }
}