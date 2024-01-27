using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal sealed class Helper : Worker
    {
        //public Helper(string firstname, string lastname) : base(firstname, lastname)
        //{
        //}

        public override string Fullname => $"{base.Fullname} | H";
    }
}