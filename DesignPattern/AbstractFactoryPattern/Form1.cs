using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern.AbstractFactoryPattern
{
    public partial class Form1 : Form
    {
        private Garden garden;
        public Form1()
        {
            InitializeComponent();
        }

        private void Annual_CheckedChanged(object sender, EventArgs e)
        {
            setGarden(new AnnualGarden());
        }

        private void Vegetable_CheckedChanged(object sender, EventArgs e)
        {
            setGarden(new VeggieGarden());
        }

        private void Perennial_CheckedChanged(object sender, EventArgs e)
        {
            setGarden(new PerennialGarden());
        }
        private void setGarden(Garden gd)
        {
            garden = gd;
            pictureBox1.SetGarden(gd);
            pictureBox1.Refresh();
            Center.Checked = false;
            Border.Checked = false;
            Shade.Checked = false;
        }

        private void Center_CheckedChanged(object sender, EventArgs e)
        {
            garden.SetCenter();
            pictureBox1.Refresh();
        }

        private void Border_CheckedChanged(object sender, EventArgs e)
        {
            garden.SetBorder();
            pictureBox1.Refresh();
        }

        private void Shade_CheckedChanged(object sender, EventArgs e)
        {
            garden.SetShade();
            pictureBox1.Refresh();
        }
    }
}
