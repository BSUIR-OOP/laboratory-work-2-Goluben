using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1
{
    class Ellipse: GeometricFigure
    {

        public Ellipse(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            
        }

        public Ellipse() {}

        public override void DrawFigure(Pen pen, Graphics graphic)
        {
            graphic.DrawArc(pen, (this.x2 + this.x1) / 2, (this.y2 + this.y1) / 2, Math.Abs(this.x2 - this.x1) / 2, Math.Abs(this.y2 - this.y1) / 2, 0, 360);
        }

    }
}
