namespace QuiltShape
{
    public abstract class Shape
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }


        public abstract int TotalArea();

        public Shape()
        {

        }

    }
}
