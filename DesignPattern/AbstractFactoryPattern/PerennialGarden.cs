using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    public class PerennialGarden : Garden
    {
        public PerennialGarden()
        {
            shade = new Plant("ShadeXXXX");
            center = new Plant("CenterXXXX");
            border = new Plant("BorderXXXX");
        }
    }
}
