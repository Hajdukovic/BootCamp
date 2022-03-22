using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        static void Print<H>(ref H element)
        {
            Console.WriteLine("Generic example value is: " + element);
        }

        static void Main(string[] args)
        {
            Builder worker1 = new Builder();
            worker1.Name = "Pero";
            worker1.Surname = "Perić";
            Builder worker2 = new Builder();
            worker2.Name = "Duro";
            worker2.Surname = "Mirkec";
            Manager boss1 = new Manager();
            boss1.Name = "Hrvoje";
            boss1.Surname = "Hajduković";

            List<Employee> employees = new List<Employee>();
            employees.Add(worker1);
            employees.Add(worker2);
            employees.Add(boss1);

            foreach (IWork employee in employees)
            {
                employee.Work(8);
            }

            foreach (Employee employee in employees)
            {
                employee.GetPaycheck();
                employee.PrintInfo();
            }

            // Generic test example
            string testNumberString = "0123";
            Print(ref testNumberString);
            int testNumberInt = 0123;
            Print(ref testNumberInt);

            Console.ReadLine();
        }
    }
}
