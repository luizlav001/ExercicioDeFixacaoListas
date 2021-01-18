using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Emplyoee> list = new List<Emplyoee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Emplyoee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Emplyoee emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist! ");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach(Emplyoee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
