using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240321物件導向2
{
    class Employee
    {
        public int id;
        public int salary;
    }
    class Employee2
    {
        private int id;
        private int salary;
        public int Id
        {
            get;set;
        }
        public int Salary
        {
            get { return salary; }
            set { if (value < 28000) value = 28000;
                salary = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.id = 1;
            emp.salary = -35000;
            Console.WriteLine(emp.salary);
            Employee2 emp2 = new Employee2();
            emp2.Id = 2;
            emp2.Salary = -30000;
            Console.WriteLine(emp2.Salary);
            Console.ReadKey ();
        }
    }
}
