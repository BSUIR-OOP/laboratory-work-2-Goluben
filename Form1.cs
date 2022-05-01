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

        public Form1()
        {
            InitializeComponent();
            graphic = CreateGraphics();
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
            FigureCollection fc = new FigureCollection(x1, y1, e.X, e.Y, graphic);
            foreach (GeometricFigure element in fc.figures)
            {
                if ((fc.figures.IndexOf(element)) == comboBox1.SelectedIndex)
                {
                    fc.figures[comboBox1.SelectedIndex].DrawFigure();
                }
            }
            Cursor = Cursors.Default;
        }

    }
}
