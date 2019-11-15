namespace ProektKursova
{
    using System;
   public class Square : Figure, IFigurable
    {
        private double side;
        public Square(double lenghtOfSide)
        {
            this.Side = lenghtOfSide;
            this.Perimeter = FindPerimeter();
            this.Surface = FindSurface();
        }
        protected double Side 
        {
            get => this.side;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Any side from square must be positive number.");
                }

                this.side = value;
            }
        }

        public override double FindPerimeter()
        {
            var perimeter = 4 * Side;
            return perimeter;
        }

        public override double FindSurface()
        {
            var surface = Side * Side;
            return surface;
        }
    }
}
