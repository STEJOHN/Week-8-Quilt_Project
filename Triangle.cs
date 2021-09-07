using System;

namespace QuiltShape
{
    class Triangle : Shape
    {


        public Triangle()
        {

        }
        public Triangle(string color, int sideA, int sideB, int sideC)
        {

            Name = "Triangle";
            Color = color;
            Side1 = sideA;
            Side2 = sideB;
            Side3 = sideC;

        }



        public override int TotalArea()
        {


            int a = (Side1 + Side2 + Side3) / 2;

            int result = (int)Math.Sqrt(a * (a - Side1) * (a - Side2) * (a - Side3));
            return result;
        }

    }
}
