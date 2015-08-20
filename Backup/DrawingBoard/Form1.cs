using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingBoard
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false;
        string color = "black";
        int size = 4;
        int x1, x2, y1, y2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnl_painter_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
            x1 = e.X;
            y1 = e.Y;
        }

        private void pnl_painter_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void pnl_painter_MouseMove(object sender, MouseEventArgs e)
        {
            Brush brush1 = new SolidBrush(Color.Black); 
            if (rdo_black.Checked) color = "black";
            else if (rdo_blue.Checked) color = "blue";
            else if (rdo_red.Checked) color = "red";
            switch (color)
            {
                case "black": brush1 = new SolidBrush(Color.Black); break;
                case "blue": brush1 = new SolidBrush(Color.Blue); break;
                case "red": brush1 = new SolidBrush(Color.Red); break;
            }
            if (rdo_small.Checked) size = 4;
            else if (rdo_middle.Checked) size = 8;
            else if (rdo_large.Checked) size = 12;
            
            x2 = e.X;
            y2 = e.Y;

            Pen pen1 = new Pen(brush1, size);
            pen1.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Flat);
            //pen1.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            if (shouldPaint)
            {
                Graphics graphics = pnl_painter.CreateGraphics();
                //graphics.FillEllipse(brush1, e.X, e.Y, size, size);
                graphics.DrawLine(pen1, x1, y1, x2, y2);
                graphics.Dispose();
            }

            x1 = e.X;
            y1 = e.Y;

        }

        private void rdo_black_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
