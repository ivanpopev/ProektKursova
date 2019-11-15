namespace ProektKursova
{
    using System;
    
    public class Circle : Figure, IFigurable
    {
        private double diameter;
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
            this.Diameter = Radius * 2;
            this.Perimeter = FindPerimeter();
            this.Surface = FindSurface();
        }

        protected double Diameter 
        {
            get => this.diameter;
            
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The diameter must be positive number.");
                }

                this.diameter = value;
            }
        }
        protected double Radius
        {
            get => this.radius;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The radius of the circle cannot be zero or negative number.");
                }

                this.radius = value;
            }
        }

        public override double FindSurface()
        {
            var surface =Math.Round( Math.PI,2) * Radius * Radius;
            return surface;
        }

        public override double FindPerimeter()
        {
            var perimeter = 2 * Math.Round(Math.PI,2) * Radius;
            return perimeter;
        }
    }
}
