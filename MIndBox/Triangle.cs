using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIndBox
{
   public sealed class Triangle : BasicFigure
   {
        private double b;
        private double c;
        
        public Triangle(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Square()
        {
            double perimetr = (a + b + c) / 2;
            return Math.Sqrt(perimetr * (perimetr - a) * (perimetr - b) * (perimetr - c));
        }
        public bool IsRectTriangle()
        {
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) return true;
            if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) return true;
            if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2)) return true;
            return false;
           
        }
    }
}
