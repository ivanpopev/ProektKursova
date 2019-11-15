namespace ProektKursova
{
    public interface IFigurable
    {
        int Id { get; }
        double Perimeter { get;  }
        double Surface { get;  }

        void Delete(int id);
        void Select(int id);
        void Move();
        double FindPerimeter();
        double FindSurface();
    }
}