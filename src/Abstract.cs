namespace learn_cs.src
{
    public class Abstract
    {
        public abstract class Shape
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string FillColor { get; set; } = "";
            public string BorderColor { get; set; } = "";

            public abstract void Draw();
        }

        public class Circle : Shape
        {
            public int Radius { get; set; }

            public override void Draw()
            {
                // code here
            }
        }

        public class Triangle : Shape
        {
            public int SideLength { get; set; }

            public override void Draw()
            {
                // code here
            }
        }

        public class Square : Shape
        {
            public int SideLength { get; set; }

            public override void Draw()
            {
                // code here
            }
        }

    }
}