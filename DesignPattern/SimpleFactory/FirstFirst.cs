using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class FirstFirst : Namer
    {
        public FirstFirst(string name)
        {
            int index = name.Trim().IndexOf(" ");
            if (index > 0)
            {
                firstName = name.Substring(0, index).Trim();
                lastName = name.Substring(index + 1).Trim();
            }
            else
            {
                lastName = name;
                firstName = "";
            }
        }
    }
}
