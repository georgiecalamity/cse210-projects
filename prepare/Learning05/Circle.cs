public class Circle : Shapes
{
    private double _radius;

    public Circle(double Radius, string Color) : base(Color)
    {
        _radius = Radius;
    }

    public override double GetArea()
        {
            double area = Math.PI * Math.Pow(_radius, 2);
            return area;
        }
}   