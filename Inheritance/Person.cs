using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Person //abstract nicht instanzierbar
    {
        private string privateNothing = "private"; // nur in dieser Klasse
        protected string nothing = "Hallo"; // innerhalb der Vererbungshirachie --> private

        public string SocialSecurityNumber { get; set; } = string.Empty;

        public string Firstname { get; set; } = string.Empty;

        public string Lastname { get; set; } = string.Empty;

        public virtual string Fullname => $"{Firstname} {Lastname}";

        public DateTime HireDate { get; set; }

        //public Person(string firstname, string lastname)
        //{
        //    Firstname = firstname;
        //    Lastname = lastname;
        //}

        public abstract double GetMonthlyIncome();
    }
}