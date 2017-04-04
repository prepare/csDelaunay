using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

using CsDelaunay;

namespace Test
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.g = this.CreateGraphics();


        }
        static void AddToPath(GraphicsPath path, List<Vector2f> vecs)
        {
            int j = vecs.Count;
            for (int i = 1; i < j; ++i)
            {
                path.AddLine(ToPointF(vecs[i - 1]), ToPointF(vecs[i]));
            }
            path.CloseFigure();
        }
        static PointF ToPointF(Vector2f v)
        {
            float x = v.x;
            float y = v.y;
            if (float.IsNaN(x))
            {
                x = 0;
            }
            if (float.IsNaN(y))
            {
                y = 0;
            }
            return new PointF(x, y);
        }
        static PointF ToPointF(Vertex v)
        {
            float x = v.x;
            float y = v.y;
            if (float.IsNaN(x))
            {
                x = 0;
            }
            if (float.IsNaN(y))
            {
                y = 0;
            }
            return new PointF(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            List<Vector2f> vecs = new List<Vector2f>();
            vecs.Add(new Vector2f(20, 20));
            //vecs.Add(new Vector2f(50, 0));
            //vecs.Add(new Vector2f(70, 100));
            //vecs.Add(new Vector2f(100, 150));
            //vecs.Add(new Vector2f(30, 150));
            //vecs.Add(new Vector2f(0, 0));
            vecs.Add(new Vector2f(40, 20));
            vecs.Add(new Vector2f(40, 60));
            vecs.Add(new Vector2f(20, 60));
            vecs.Add(new Vector2f(20, 20));
            //            vecs.Add(new Vector2f(0, 0));
            //vecs.Add(new Vector2f(25, 100));
            //vecs.Add(new Vector2f(0, 80));
            //vecs.Add(new Vector2f(0, 0));

            //
            GraphicsPath path = new GraphicsPath();
            AddToPath(path, vecs);

            g.DrawPath(Pens.Black, path);

            Voronoi v1 = new Voronoi(vecs, new Rectf(0, 0, 51, 101));
            List<LineSegment> lineSegs = v1.VoronoiDiagram();

            //draw
            GraphicsPath path2 = new GraphicsPath();
            int j = lineSegs.Count;
            for (int i = 0; i < j; ++i)
            {
                LineSegment lineseg = lineSegs[i];
                path2.AddLine(
                    ToPointF(lineseg.p0),
                    ToPointF(lineseg.p1));
            }
            //List<Edge> edgeList = v1.Edges;
            //GraphicsPath path2 = new GraphicsPath();
            //int j = edgeList.Count;
            //for (int i = 0; i < j; ++i)
            //{
            //    Edge edge = edgeList[i];
            //    Vertex left = edge.LeftVertex;
            //    Vertex right = edge.RightVertex;

            //    if (left == null || right == null)
            //    {
            //        continue;
            //    }
            //    path2.AddLine(ToPointF(left), ToPointF(right));
            //}

            g.DrawPath(Pens.Red, path2);
        }
    }
}
