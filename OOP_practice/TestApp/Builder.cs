using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestApp
{
    public class Builder : Employee, IWork
    {
        public override void GetPaycheck()
        {
            this.Balance = (double)this.WorkingHours * 29.30;
            Console.WriteLine($"{this.Name} {this.Surname} just got paid!");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Worker " + this.Name + " " + this.Surname + " has this much on account: " + this.Balance + "$");
        }

        public void Work(int mHours)
        {
            this.WorkingHours += mHours;
        }
    }
}
