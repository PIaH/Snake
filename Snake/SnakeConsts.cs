using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

static class SnakeConsts
{
    public static Size SectionSize = new Size(20, 20);
    public static Pen OutLinePen = new Pen(Color.Black, 3f);
    public static Brush BodyBrush = Brushes.DarkKhaki;
    public static Size GridSize = new Size(20, 10);
}