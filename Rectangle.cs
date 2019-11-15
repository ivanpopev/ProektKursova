namespace ProektKursova
{
    using System;

    public class Rectangle : Figure,IFigurable
    {
        private double firstSide;
        private double secondSide;

        public Rectangle(double firstSide, double secondSide)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.Perimeter = FindPerimeter();
            this.Surface = FindSurface();
        }

        protected double FirstSide
        {
            get => this.firstSide;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side must be positive number.");
                }

                this.firstSide = value;
            }
        }
        protected double SecondSide
        {
            get => this.secondSide;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side must be positive number.");
                }

                this.secondSide = value;
            }
        }

        public override double FindPerimeter()
        {
            var perimeter = 2 * (FirstSide + SecondSide);
            return perimeter;
        }

        public override double FindSurface()
        {
            var surface= FirstSide * SecondSide;
            return surface;
        }

    }
}
