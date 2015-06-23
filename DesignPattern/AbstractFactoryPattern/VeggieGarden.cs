using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    public class VeggieGarden : Garden
    {
        public VeggieGarden()
        {
            shade = new Plant("Broccoli");
            border = new Plant("Peas");
            center = new Plant("Corn");
        }
    }
}
