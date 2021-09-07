using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShape
{
    class Square : Shape
    {
        public Square()
        {

        }

        public Square(string color, int side1)
        {
            Name = "Square";
            Color = color;
            Side1 = side1;
        }
        public override int TotalArea()
        {
             int result = Side1 * Side1;
            return result;
            

        }
    }
}
