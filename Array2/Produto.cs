using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Array2
{
    public class Produto
    {
        public string? Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string? nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}