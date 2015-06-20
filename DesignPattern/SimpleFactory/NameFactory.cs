using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class NameFactory
    {
        public Namer GetName(string name)
        {
            int index = name.IndexOf(",");
            if (index > 0)
            {
                return new LastFirst(name);
            }
            else
            {
                return new FirstFirst(name);
            }
        }
    }
}
