using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIndBox
{
   public abstract class BasicFigure:ISquare
    {
        /*
         * Я изначально хотел искать площадь непоределенной фигуры, через интегралл 
         * Но передумал, поэтому оставил этот класс для базовой реализации фигур
         */
        public double a;
        public BasicFigure()
        {

        }
        public abstract double Square();
      
    }
}
