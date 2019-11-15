namespace ProektKursova
{
    using System;
    public class Triangle : Figure, IFigurable
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;
        private double firstSideHeight;
        private double secondSideHeight;
        private double thirdSideHeight;
        public Triangle(double firstSide, double secondSide, double thirdSide,
            double firstSideHeight, double secondSideHeight, double thirdSideHeight)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
            this.FirstSideHeight = firstSideHeight;
            this.SecondSideHeight = secondSideHeight;
            this.ThirdSideHeight = thirdSideHeight;
            this.Perimeter=FindPerimeter();
            this.Surface = FindSurface();
        }

        protected double FirstSide 
        {
            get => this.firstSide;
            
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Any side of triangle must be positive number.");
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
                    throw new ArgumentException("Any side of triangle must be positive number.");
                }

                this.secondSide = value;
            }
        }
        protected double ThirdSide 
        {
            get => this.thirdSide;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Any side of triangle must be positive number.");
                }

                this.thirdSide = value;
            }
        }

        protected double FirstSideHeight 
        {
            get => this.firstSideHeight;
            
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Any of triangle heights must be positive number.");
                }

                this.firstSideHeight = value;
            }
        }
        protected double SecondSideHeight 
        {
            get => this.secondSideHeight;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Any of triangle heights must be positive number.");
                }

                this.secondSideHeight = value;
            }
        }
        protected double ThirdSideHeight 
        {
            get => this.thirdSideHeight;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Any of triangle heights must be positive number.");
                }

                this.thirdSideHeight = value;
            }
        }

        public override double FindPerimeter()
        {
            var perimeter = FirstSide + SecondSide + ThirdSide;
            return perimeter;
        }

        public override double FindSurface()
        {
            var surface = FirstSide * FirstSideHeight / 2;
            return surface;
        }
    }
}