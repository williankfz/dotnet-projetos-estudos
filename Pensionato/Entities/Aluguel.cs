using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pensionato.Entities
{
    public class Aluguel
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }

        public Aluguel(string? nome, string? email)
        {
            Nome = nome;
            Email = email;
        }
    }
}