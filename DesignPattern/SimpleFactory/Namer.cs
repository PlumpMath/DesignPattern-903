using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class Namer
    {
        protected string firstName, lastName;

        public string GetFirst()
        {
            return this.firstName;
        }
        public string GetLast()
        {
            return this.lastName;
        }
    }
}
