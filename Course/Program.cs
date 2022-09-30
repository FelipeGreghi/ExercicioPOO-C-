using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter Values
            Console.WriteLine("Enter department's name : ");
            string department = Console.ReadLine();
            
            Console.WriteLine("Name : ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Level (Junio/MidLevel/Senior) : ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("Base salary : ");
            double baseSalary = double.Parse(Console.ReadLine());

            //Object insertion
            Department dept = new Department(department);
            Worker worker = new Worker(name, level,baseSalary, dept);

            //Loop Contracts
            Console.WriteLine("How many contracts to this Worker? ");
            int contractsNumber = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= contractsNumber; i++)
            {
                Console.WriteLine($"Enter #{i} contract data : ");
                Console.WriteLine("Date (DD/MM/YYYY) : ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour : ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hours)");
                int hours = int.Parse(Console.ReadLine());

                //Add Contracts to Worker
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            //Calculate Salary
            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY) : ");
            string income = Console.ReadLine();
            int month = int.Parse(income.Substring(0, 2));
            int year = int.Parse(income.Substring(3));
            

            //OutPut
            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department : " + worker.Department.Name);
            
            Console.WriteLine("Income for "+ income + " : $" + worker.Income(year,month));

        }
    }
}