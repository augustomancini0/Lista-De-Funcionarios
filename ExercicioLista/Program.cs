using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioLista.Models;

namespace ListaDeEmpregados
{
    class program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees do you will Registered? : ");
            int employess = int.Parse(Console.ReadLine());
            List<Employess> listOfEmployees = new List<Employess>();
            Console.WriteLine("");

            for (int i = 1; i < employess; i++)
            {
                Console.WriteLine("========================================");
                Console.WriteLine($"Employee #{i}");
                Console.Write("What is the employe's ID? :");
                int id = int.Parse(Console.ReadLine());
                Console.Write("What is the name of the Employee? :");
                string name = Console.ReadLine();
                Console.Write("Whats it his Salary? : ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listOfEmployees.Add(new Employess(id, name, salary));
            }

            Console.WriteLine("");
            Console.Write("Enter the id that will have a salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employess search = listOfEmployees.Find(x => x.ID == searchId);
            if (search != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                search.IncreaseSalary(percentage);
            }
            Console.WriteLine("");
           else
            {
                Console.WriteLine("Thats Id does no exists");
            }

            foreach (Employess obj in listOfEmployees)
            {
                 
                Console.WriteLine("Upadate list of employess :");
                Console.WriteLine($"ID: {obj.ID}");
                Console.WriteLine($"Name: {obj.Name}");
                Console.WriteLine($"Salary: {obj.Salary}");
            }
        }
    }
}