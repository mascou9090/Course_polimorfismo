using Course_polimorfismo.Entites;
using System;
using System.Globalization;

namespace Course_polimorfismo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of Employees:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)?");
                char letterAux = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameAux = Console.ReadLine();
                Console.Write("Hours: ");
                int hoursAux = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHourAux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (letterAux == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalChargeAux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourceEmployee(nameAux, hoursAux,valuePerHourAux, additionalChargeAux));
                }
                else
                {
                    list.Add(new Employee(nameAux, hoursAux, valuePerHourAux);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments:");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}