namespace Abstraction
{
    using System;

    public abstract class Figure
    {
        public Figure(double radius)
        {
            this.Radius = radius;
        }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Radius { get; set; }
    }
}
