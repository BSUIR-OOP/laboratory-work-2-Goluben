using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    class Rectangle : GeometricFigure
    {

        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {

        } 

        public Rectangle() { }

        public override void DrawFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point(this.x1, this.y1);
            Point b = new Point(this.x2, this.y1);
            Point c = new Point(this.x2, this.y2);
            Point d = new Point(this.x1, this.y2);

            graphic.DrawLine(pen, a, b);
            graphic.DrawLine(pen, b, c);
            graphic.DrawLine(pen, c, d);
            graphic.DrawLine(pen, d, a);
        }

    }
}
