using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1
{
    class Rhombus: GeometricFigure
    {

        public Rhombus(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            
        }

        public Rhombus() { }

        public override void DrawFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point((this.x2 + this.x1) / 2, this.y1);
            Point b = new Point(this.x2, (this.y2 + this.y1) / 2);
            Point c = new Point((this.x2 + this.x1) / 2, this.y2);
            Point d = new Point(this.x1, (this.y2 + this.y1) / 2);

            graphic.DrawLine(pen, a, b);
            graphic.DrawLine(pen, b, c);
            graphic.DrawLine(pen, c, d);
            graphic.DrawLine(pen, d, a);
        }
    }
}
