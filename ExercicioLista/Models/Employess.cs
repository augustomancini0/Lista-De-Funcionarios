using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista.Models
{
    public class Employess
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Employess(int iD, string name, double salary)
        {
            ID = iD;
            Name = name;
            Salary = salary;
        }

     
        public void  IncreaseSalary(double percentage)
        {
             Salary += Salary *percentage / 100;
        }

       

    }
}
