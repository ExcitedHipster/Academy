using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator -(Point p1, Point p2)
        {
            var xResult = p1.X - p2.X;
            var yResult = p1.Y - p2.Y;
            return new Point(xResult, yResult);
        }

        public static Point operator --(Point p)
        {
            var xResult = p.X - 1;
            var yResult = p.Y - 1;
            return new Point(xResult, yResult);
        }

        public static Point operator ++(Point p)
        {
            var xResult = p.X + 1;
            var yResult = p.Y + 1;
            return new Point(xResult, yResult);
        }

        public static Point operator *(Point p1, int value)
        {
            var xResult = p1.X * value;
            var yResult = p1.Y * value;
            return new Point(xResult, yResult);
        }

        public static Point operator +(Point p1, Point p2)
        {
            var xResult = p1.X + p2.X;
            var yResult = p1.Y + p2.Y;
            return new Point(xResult, yResult);
        }



        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }

    }
}
