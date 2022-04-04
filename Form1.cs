using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        int x1, y1;
        Graphics graphic;
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);

        public Form1()
        {
            InitializeComponent();
            graphic = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pen.Width = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphic.Clear(DefaultBackColor);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            Cursor = Cursors.Cross;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    (new Line(x1, y1, e.X, e.Y)).DrawFigure(pen, graphic);
                    break;
                case 1:
                    (new Triangle(x1, y1, e.X, e.Y)).DrawFigure(pen, graphic);
                    break;
                case 2:
                    (new Rectangle(x1, y1, e.X, e.Y)).DrawFigure(pen, graphic);
                    break;
                case 3:
                    (new Rhombus(x1, y1, e.X, e.Y)).DrawFigure(pen, graphic);
                    break;
                case 4:
                    (new Ellipse(x1, y1, e.X, e.Y)).DrawFigure(pen, graphic);
                    break;
                case 5:
                    (new Hexagon(x1, y1, e.X, e.Y)).DrawFigure(pen, graphic);
                    break;
                default:
                    break;
            }
        }

    }
}
