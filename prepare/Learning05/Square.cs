
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class Square : Shapes
{
    private double _side;

    public Square(string Color, double Side) : base(Color)
    {
        _side = Side;
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }

    
}
