using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaContratos.entities
{
    public class Department
    {
        public string? Name { get; set; }

        public Department(string? name)
        {
            Name = name;
        }
    }
}