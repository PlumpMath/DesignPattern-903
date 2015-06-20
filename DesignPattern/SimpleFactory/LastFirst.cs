using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class LastFirst : Namer
    {
        public LastFirst(string name)
        {
            int index = name.IndexOf(",");
            if (index > 0)
            {
                lastName = name.Substring(0, index);
                firstName = name.Substring(index + 1).Trim();
            }
            else
            {
                lastName = name;
                firstName = "";
            }
        }
    }
}
