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
        int x1, y1;
        Pen mypen=new Pen(Color.Black,4);
        Bitmap mybitmap;
        Graphics graphics, gTemp;
        String penstyle = "pen";
        Rectangle rec = Rectangle.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mybitmap = new Bitmap(pic_painter.Width, pic_painter.Height);
            graphics = Graphics.FromImage(mybitmap);
            graphics.Clear(Color.White);
            gTemp = pic_painter.CreateGraphics();
            mypen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Flat);
        }

        private void pic_painter_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
            x1 = e.X;
            y1 = e.Y;
        }

        private void pic_painter_MouseUp(object sender, MouseEventArgs e)
        {
            pic_painter.Cursor = Cursors.Default;
            shouldPaint = false;
            switch (penstyle)
            {
                case "ell":
                    graphics.DrawEllipse(mypen, rec);
                    pic_painter.Refresh();
                    break;
                case "rec":
                    graphics.DrawRectangle(mypen, rec);
                    pic_painter.Refresh();
                    break;
                case "StraightLine":
                    graphics.DrawLine(mypen, x1, y1, e.X, e.Y);
                    pic_painter.Refresh();
                    break;
            }
            rec = Rectangle.Empty;
        }

        private void pic_painter_MouseMove(object sender, MouseEventArgs e)
        {
            //pen1.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            if (shouldPaint)
            {
                if (e.X > x1)
                {
                    rec.X = x1;
                    rec.Width = e.X - x1;

                }
                else
                {
                    rec.X = e.X;
                    rec.Width = x1 - e.X;
                }
                if (e.Y > y1)
                {
                    rec.Y = y1;
                    rec.Height = e.Y - y1;
                }
                else
                {
                    rec.Y = e.Y;
                    rec.Height = y1 - e.Y;
                }

                switch(penstyle)
                {
                    case "pen":
                        graphics.DrawLine(mypen, x1, y1, e.X, e.Y);
                        x1 = e.X;
                        y1 = e.Y;
                        pic_painter.Refresh();
                        break;
                    case "StraightLine":
                        pic_painter.Refresh();
                        gTemp.DrawLine(mypen, x1, y1, e.X, e.Y);
                        break;
                    case "rec":
                        pic_painter.Refresh();
                        gTemp.DrawRectangle(mypen, rec);
                        break;
                    case "ell":
                        pic_painter.Refresh();
                        gTemp.DrawEllipse(mypen, rec);
                        break;
                    case"eraser":
                        Color c = mypen.Color;
                        mypen.Color = Color.White;
                        pic_painter.Cursor = Cursors.Cross;
                        graphics.DrawLine(mypen, x1, y1, e.X, e.Y);
                        x1 = e.X;
                        y1 = e.Y;
                        pic_painter.Refresh();
                        mypen.Color = c;
                        break;
                }
                
            }
        }

        private void pic_painter_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mybitmap, 0, 0);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                mybitmap.Save(sfd1.FileName);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            mybitmap = new Bitmap(pic_painter.Width, pic_painter.Height);
            graphics = Graphics.FromImage(mybitmap);
            graphics.Clear(Color.White);
            pic_painter.Refresh();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            if (cld1.ShowDialog() == DialogResult.OK)
            {
                mypen.Color = cld1.Color;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mybitmap = new Bitmap(pic_painter.Width, pic_painter.Height);
            graphics = Graphics.FromImage(mybitmap);
            graphics.Clear(Color.White);
            pic_painter.Refresh();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                mybitmap.Save(sfd1.FileName);
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cld1.ShowDialog() == DialogResult.OK)
            {
                mypen.Color = cld1.Color;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("啦啦啦");
        }

        private void 小号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.Width = 4;
            小号ToolStripMenuItem.Checked = true;
            中号ToolStripMenuItem.Checked = false;
            大号ToolStripMenuItem.Checked = false;
            其他ToolStripMenuItem.Checked = false;
        }

        private void 中号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.Width = 8;
            小号ToolStripMenuItem.Checked = false;
            中号ToolStripMenuItem.Checked = true;
            大号ToolStripMenuItem.Checked = false;
            其他ToolStripMenuItem.Checked = false;
        }

        private void 大号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.Width = 12;
            小号ToolStripMenuItem.Checked = false;
            中号ToolStripMenuItem.Checked = false;
            大号ToolStripMenuItem.Checked = true;
            其他ToolStripMenuItem.Checked = false;
        }

        private void 其他ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fom = new Form2();
            fom.MessageSent += delegate(object caller, int msg)
            {
                 mypen.Width = msg;
                 小号ToolStripMenuItem.Checked = false;
                 中号ToolStripMenuItem.Checked = false;
                 大号ToolStripMenuItem.Checked = false;
                 其他ToolStripMenuItem.Checked = true;
            };
            fom.ShowDialog();
            
        }

        private void btn_rec_Click(object sender, EventArgs e)
        {
            penstyle = "rec";
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            penstyle = "pen";
        }

        private void btn_ell_Click(object sender, EventArgs e)
        {
            penstyle = "ell";
        }

        private void btn_StraightLine_Click(object sender, EventArgs e)
        {
            penstyle = "StraightLine";
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            penstyle = "eraser";
        }

        private void 打开oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                mybitmap =new Bitmap(Image.FromFile(ofd1.FileName),pic_painter.Width, pic_painter.Height);
                graphics = Graphics.FromImage(mybitmap);
                //graphics.Clear(Color.White);
                pic_painter.Refresh();
            }
        }

        private void ofd1_FileOk(object sender, CancelEventArgs e)
        {

        }

    }
}
