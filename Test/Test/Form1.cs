using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using csDelaunay;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Vector2f> vecs = new List<Vector2f>();
            vecs.Add(new Vector2f(0, 0));
            vecs.Add(new Vector2f(50, 0));
            vecs.Add(new Vector2f(70, 100));
            vecs.Add(new Vector2f(100, 150));
            vecs.Add(new Vector2f(30, 150));
            vecs.Add(new Vector2f(0, 0));

            Voronoi v1 = new Voronoi(vecs, new Rectf(0, 0, 120, 170));

        }
    }
}
