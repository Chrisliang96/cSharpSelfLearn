using System;
using System.Drawing;

namespace cSharpSelfLearn.BoxingGame.Combat.Tools
{
    public class Distance
    {
        public static float GetDistance(Point p1, Point p2)
        {
            return (float) Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y)) ;
        }
    }
}