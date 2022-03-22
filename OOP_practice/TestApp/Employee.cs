using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    // Abstract class, can't be used, must be inherited
    public abstract class Employee
    {
        // Attributes
        public string Name { get; set; }
        public string Surname { get; set; }
        protected double Balance=0;
        protected int WorkingHours = 0;

        // Methods
        public abstract void GetPaycheck();
        public double GetBalance()
        {
            return this.Balance;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Employee " + this.Name + " " + this.Surname + " has this much on account: " + this.Balance);
        }
    }
}
