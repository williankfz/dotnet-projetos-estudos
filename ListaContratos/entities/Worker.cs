using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaContratos.entities.Enums;

namespace ListaContratos.entities
{
    public class Worker
    {
        public string? Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department? Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string? name, WorkerLevel level, double baseSalary, Department? department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void Add(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void Remove(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double total = BaseSalary;
            foreach(var item in Contracts)
            {
                if(item.Date.Year == year && item.Date.Month == month)
                {
                    total += item.TotalValue();
                }
            }
            return total;
        }
    }
}