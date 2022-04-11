using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class FigureCollection
    {

        public FigureCollection()
        {

        }

        public GeometricFigure getFigure(String _name)
        {
            switch (_name)
            {
                case ("Линия"): return new Line();
                case ("Треугольник"): return new Triangle();
                case ("Прямоугольник"): return new Rectangle();
                case ("Ромб"): return new Rhombus();
                case ("Эллипс"): return new Ellipse();
                case ("Шестиугольник"): return new Hexagon();                
                default: return new Line();
            }
        }


    }

}

