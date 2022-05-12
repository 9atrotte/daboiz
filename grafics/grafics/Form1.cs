using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafics
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            pic_paper.Refresh();

        }

        private void pic_paper_Click(object sender, EventArgs e)
        {

        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            
            Graphics paper;
            paper = pic_paper.CreateGraphics();
            Pen mypen = new Pen(Color.Black, 5);
            paper.DrawLine(mypen, 10, 10, 50, 50);
            this.Location =new Point(0,0);
            var x = pic_paper.Location;
            var y = MousePosition;
            var z = this.Location;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(this);
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(this);
            
        }
    }
}
