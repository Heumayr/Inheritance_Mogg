using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Worker : Person
    {
        //public Worker(string firstname, string lastname) : base(firstname, lastname)
        //{
        //}

        public double DailyWage { get; set; }

        public override string Fullname => $"{base.Fullname} | W"; //base greift auf Oberklasse zu

        public override double GetMonthlyIncome()
        {
            return DailyWage * 21;
        }
    }
}