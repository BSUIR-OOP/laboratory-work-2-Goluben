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
        abstract public void DrawFigure(Pen pen, Graphics graphic);
    }
}
