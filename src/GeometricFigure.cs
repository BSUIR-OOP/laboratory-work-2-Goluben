using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
     abstract public class GeometricFigure 
     {

        protected string name;
        protected int x1;
        protected int y1;
        protected int x2;
        protected int y2;

        public GeometricFigure (int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public GeometricFigure() { }


        abstract public void DrawFigure(Pen pen, Graphics graphic);

        public int getX1()
        {
            return x1;
        }

        public int getX2()
        {
            return x2;
        }

        public int getY1()
        {
            return y1;
        }

        public int getY2()
        {
            return y2;
        }

        public string getName()
        {
            return name;
        }

        public void setX1(int x1)
        {
            this.x1 = x1;
        }

        public void setX2(int x2)
        {
            this.x2 = x2;
        }

        public void setY1(int y1)
        {
            this.y1 = y1;
        }

        public void setY2(int y2)
        {
            this.y2 = y2;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
