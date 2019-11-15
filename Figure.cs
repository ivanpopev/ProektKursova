namespace ProektKursova
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Figure : IFigurable
    {
        private int id;
        private double perimeter;
        private double surface;
        private List<IFigurable> figures;

        public Figure()
        {
            this.figures = new List<IFigurable>();
        }

        public int Id 
        {
            get => this.id;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id cannot be zero or negative.");
                }

                this.id = value;
            }
        }
        public double Perimeter 
        {
            get => this.perimeter;

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Perimeter should be positive number.");
                }

                this.perimeter = value;
            }
        }
        public double Surface 
        {
            get => this.surface;
            
           protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Surface should be positive number.");
                }

                this.surface = value;
            }

        }

        public void Delete(int id)
        {
            var shapeToRemove = figures.Where(f => f.Id == id);

            figures.Remove((Figure)shapeToRemove);
        }

        public virtual double FindPerimeter()
        {
            return Perimeter;
        }

        public virtual double FindSurface()
        {
            return Surface;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Select(int id)
        {
            throw new NotImplementedException();
        }
    }
}
