using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal sealed class Employee : Person
    {
        //public Employee(string firstname, string lastname, DateTime hiredate) : base(firstname, lastname)
        //{
        //    HireDate = hiredate;
        //}

        public double Salary { get; set; }

        public double Bonus { get; set; }

        public override double GetMonthlyIncome()
        {
            return Salary + Bonus;
        }

        public string GetNothing()
        {
            return nothing;
        }
    }
}