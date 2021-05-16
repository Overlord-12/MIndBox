using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIndBox
{
   public sealed class Circle : BasicFigure
    {
     
        public Circle(double radius)
        {
            a = radius;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(a, 2);
        }
    }
}
