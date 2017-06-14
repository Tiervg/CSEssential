using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Figure
    {
        Point a, b, c, d, e;
        string name;

        public Figure(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            name = "Triangle";
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            name = "Tetragon";
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            name = "Pentagon";
        }

        double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.Y - a.Y), 2) + Math.Pow((b.X - a.X), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            if (name == "Triangle")
                perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, a);
            else if (name == "Tetragon")
                perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, a);
            else
                perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e, a);
            Console.WriteLine(perimeter);
        }
    }
}
