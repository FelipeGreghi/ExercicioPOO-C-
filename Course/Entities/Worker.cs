﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Worker
    {
        //Auto Properties
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //Constructors
        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary,Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Methods
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum +=  contract.TotalValue();
                }
            }
            return sum;

        }

        //ToString
        public override string ToString()
        {
            return "Nome : " + Name 
                   + " Department : " + Department;
        }
    }
}
