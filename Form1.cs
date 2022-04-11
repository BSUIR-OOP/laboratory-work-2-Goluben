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
        Graphics graphic;
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
        private GeometricFigure figure;

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
            FigureCollection fc = new FigureCollection();
            this.figure = fc.getFigure(comboBox1.Text);
            this.figure.setX1(e.X);
            this.figure.setY1(e.Y);
            Cursor = Cursors.Cross;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            this.figure.setX2(e.X);
            this.figure.setY2(e.Y);
            this.figure.DrawFigure(pen, graphic);
        }

    }
}
