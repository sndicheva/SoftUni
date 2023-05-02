namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        { 
            get => width; 
            private set 
            {
                width = value;
            } 
        }
        public double Height
        {
            get => height;
            private set
            {
                height = value;
            }
        }

        public override double CalculateArea()
            => Width * Height;

        public override double CalculatePerimeter()
            => 2 * (Width + Height);
    }
}
