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

        public override void DrawFigure(Graphics graphic)
        {
            Draw draw = new Draw(x1, y1, x2, y2, graphic);
            draw.PrintFigure(new DrawRhombus());
        }
    }
}
