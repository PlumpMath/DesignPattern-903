using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    public class Garden
    {
        protected Plant center, shade, border;
        protected bool showCenter, showShade, showBorder;
        //select which ones to display
        public void SetCenter() { showCenter = true; }
        public void SetBorder() { showBorder = true; }
        public void SetShade() { showShade = true; }
        //draw each plant
        public void draw(Graphics g)
        {
            if (showCenter) center.draw(g, 100, 100);
            if (showShade) shade.draw(g, 10, 50);
            if (showBorder) border.draw(g, 50, 150);
        }
    }
}
