using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    public class AnnualGarden : Garden
    {
        public AnnualGarden()
        {
            shade = new Plant("Lily");
            border = new Plant("Rose");
            center = new Plant("Tree");
        }
    }
}
