using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSIS8
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Bitmap bitmap;
        public Form1()
        {
            Pen p = new Pen(Color.Black);
            SolidBrush s = new SolidBrush(Color.White);
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.FillEllipse(s, 50, 75, 30, 30);
            graphics.FillEllipse(s, 60, 300, 30, 30);
            graphics.FillEllipse(s, 300, 60, 30, 30);
            graphics.FillEllipse(s, 500, 100, 30, 30);
            graphics.FillEllipse(s, 700, 150, 30, 30);
            graphics.FillEllipse(s, 610, 200, 30, 30);
            graphics.FillEllipse(s, 700, 350, 30, 30);
            graphics.FillEllipse(s, 290, 290, 30, 30);
            SolidBrush s1 = new SolidBrush(Color.Red);
            Point p1 = new Point(150, 145);
            Point p2 = new Point(120, 180);
            Point p3 = new Point(180, 180);
            Point p4 = new Point(150, 145);
            Point[] points1 = { p1, p2, p3, p4 };
            graphics.FillPolygon(s1, points1);
            Point p5 = new Point(150, 190);
            Point p6 = new Point(120, 160);
            Point p7 = new Point(180, 160);
            Point p8 = new Point(150, 190);
            Point[] points2 = { p5, p6, p7, p8 };
            graphics.FillPolygon(s1, points2);
            Point p9 = new Point(200, 250);
            Point p10 = new Point(170, 285);
            Point p11 = new Point(230, 285);
            Point p12 = new Point(200, 250);
            Point[] points3 = { p9, p10, p11, p12 };
            graphics.FillPolygon(s1, points3);
            Point p13 = new Point(200, 295);
            Point p14 = new Point(170, 265);
            Point p15 = new Point(230, 265);
            Point p16 = new Point(200, 295);
            Point[] points4 = { p13, p14, p15, p16 };
            graphics.FillPolygon(s1, points4);
            Point p17 = new Point(400, 200);
            Point p18 = new Point(350, 220);
            Point p19 = new Point(350, 260);
            Point p20 = new Point(400, 280);
            Point p21 = new Point(450, 260);
            Point p22 = new Point(450, 220);
            Point p23 = new Point(400, 200);
            Point[] point5 = { p17, p18, p19, p20, p21, p22, p23 };
            SolidBrush s2 = new SolidBrush(Color.Yellow);
            graphics.FillPolygon(s2, point5);
            Point p24 = new Point(400, 223);
            Point p25 = new Point(387, 240);
            Point p26 = new Point(413, 240);
            Point p27 = new Point(400, 223);
            Point[] points6 = { p24, p25, p26, p27 };
            SolidBrush s3 = new SolidBrush(Color.Green);
            graphics.FillPolygon(s3, points6);
            graphics.FillRectangle(s3, 393, 240, 14, 20);
            Point p28 = new Point(420, 160);
            Point p29 = new Point(415, 170);
            Point p30 = new Point(395, 175);
            Point p31 = new Point(415, 180);
            Point p32 = new Point(420, 190);
            Point p33 = new Point(425, 180);
            Point p34 = new Point(445, 175);
            Point p35 = new Point(425, 170);
            Point p36 = new Point(420, 160);
            Point[] points7 = { p28, p29, p30, p31, p32, p33, p34, p35, p36 };
            graphics.FillPolygon(s3, points7);
            Point p37 = new Point(500, 310);
            Point p38 = new Point(470, 345);
            Point p39 = new Point(530, 345);
            Point p40 = new Point(500, 310);
            Point[] points8 = { p37, p38, p39, p40 };
            graphics.FillPolygon(s1, points8);
            Point p41 = new Point(500, 355);
            Point p42 = new Point(470, 325);
            Point p43 = new Point(530, 325);
            Point p44 = new Point(500, 355);
            Point[] points9 = { p41, p42, p43, p44 };
            graphics.FillPolygon(s1, points9);
            Point p45 = new Point(610, 140);
            Point p46 = new Point(580, 175);
            Point p47 = new Point(640, 175);
            Point p48 = new Point(610, 140);
            Point[] points10 = { p45, p46, p47, p48 };
            graphics.FillPolygon(s1, points10);
            Point pp1 = new Point(610, 185);
            Point pp2 = new Point(580, 150);
            Point pp3 = new Point(640, 150);
            Point pp4 = new Point(610, 185);
            Point[] point = { pp1, pp2, pp3, pp4 };
            graphics.FillPolygon(s1, point);
            pictureBox1.Image = bitmap;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
