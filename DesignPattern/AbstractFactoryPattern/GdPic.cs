using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    public class GdPic : System.Windows.Forms.PictureBox
    {
        private Brush br;
        private Garden gden;
        //------
        private void init()
        {
            br = new SolidBrush(Color.LightGray);
        }
        //------
        public GdPic()
        {
            init();
        }
        public void SetGarden(Garden garden)
        {
            gden = garden;
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            g.FillEllipse(br, 5, 5, 100, 100);
            if (gden != null)
            {
                gden.draw(g);
            }
        }
    }
}
