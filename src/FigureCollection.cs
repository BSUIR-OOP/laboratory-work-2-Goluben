using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class FigureCollection
    {
        public List<GeometricFigure> figures;

        public FigureCollection()
        {

        }

        public FigureCollection(int x1, int y1, int x2, int y2, Graphics graphics)
        {
            figures = new List<GeometricFigure>() 
            {
                new Line(x1, y1, x2, y2, graphics),
                new Triangle(x1, y1, x2, y2, graphics),
                new Rectangle(x1, y1, x2, y2, graphics),
                new Rhombus(x1, y1, x2, y2, graphics),
                new Ellipse(x1, y1, x2, y2, graphics),
                new Hexagon(x1, y1, x2, y2, graphics),
            };
        }
    }
}

