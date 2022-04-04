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
        int x1, y1, x2, y2;

        public Rhombus(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void DrawFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point((x2 + x1) / 2, y1);
            Point b = new Point(x2, (y2 + y1) / 2);
            Point c = new Point((x2 + x1) / 2, y2);
            Point d = new Point(x1, (y2 + y1) / 2);

            graphic.DrawLine(pen, a, b);
            graphic.DrawLine(pen, b, c);
            graphic.DrawLine(pen, c, d);
            graphic.DrawLine(pen, d, a);
        }
    }
}
