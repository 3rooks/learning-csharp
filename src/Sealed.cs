namespace learn_cs.src
{
    public class Sealed
    {
        public sealed class Rectangle
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public double GetArea()
            {
                return width * height;
            }
        }

        // public class Square : Rectangle { }
    }
}