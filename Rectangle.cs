using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShape
{
    class Rectangle : Shape
    {

    

        public Rectangle()
        {

        }

        
        public Rectangle(string color,int width,int length)
        {
            Name = "Rectangle";
            Color = color;
            Side1 = length;
            Side2 = width;
        }

        public override int TotalArea()
        {
             int result= Side1* Side2;
             return result;
        }
    }
}
