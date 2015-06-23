using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    public class Plant
    {
        private string name;
        private Brush br;
        private Font font;
        public Plant(string pname)
        {
            name = pname;
            font = new Font("Arial", 12);
            br = new SolidBrush(Color.Black);
        }
        public void draw(Graphics g, int x, int y)
        {
            g.DrawString(name, font, br, x, y);
        }
    }
}
