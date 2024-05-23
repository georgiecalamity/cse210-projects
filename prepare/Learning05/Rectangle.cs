public class Rectangle : Shapes
{
    private double _length;
    private double _height;

    public Rectangle(double Length, double Height, string Color) : base(Color)
    {
        _length = Length;
        _height = Height;
    }

    public override double GetArea()
    {
        double area = _length * _height;
        return area;
    }


}