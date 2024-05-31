using System;

namespace _11210301_2
{
    internal class Program
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
            { get; set; }
            public int Salary
            {
                get { return salary; }
                set
                {
                    if (value > 28000) salary = value;
                    else salary = 28000;
                }
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.id = 1;
            emp.salary = 30000;
            Console.WriteLine(emp.salary);

            Employee2 emp2 = new Employee2();
            emp2.Id = 2;
            emp2.Salary = -123;                             //不合理
            Console.WriteLine(emp2.Id);
            Console.WriteLine(emp2.Salary);

            Console.ReadKey();
        }
    }
}
