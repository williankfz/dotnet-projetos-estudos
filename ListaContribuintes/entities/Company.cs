using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaContribuintes.entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company(string? name, double anualIncome, int numberOfEmployee) : base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double Tax()
        {
            double total = 0.0;
            if(NumberOfEmployee > 10)
            {
                total += AnualIncome * 0.14;
            }
            else
            {
                total += AnualIncome * 0.16;
            }

            return total;
        }
    }
}