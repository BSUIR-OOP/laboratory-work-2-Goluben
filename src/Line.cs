﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Line: GeometricFigure
    {

        public Line(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            
        }

        public Line() { }

        public override void DrawFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point(this.x1, this.y1);
            Point b = new Point(this.x2, this.y2);

            graphic.DrawLine(pen, a, b);
        }

    }
}
