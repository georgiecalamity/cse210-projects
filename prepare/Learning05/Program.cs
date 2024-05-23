public class Program
{
    public static void Main()
    {

        Square mySquare = new Square("Red", 4.0);
        Rectangle myRectangle = new Rectangle( 6.0, 4.0, "blue");
        Circle myCircle = new Circle(10, "green");
   
        string color = mySquare.GetColor();
        Console.WriteLine($"The color of the square is: {color}"); 
        double area = mySquare.GetArea();
        Console.WriteLine($"The area of the square is: {area}");
        
        string rectangleColor = myRectangle.GetColor();
        Console.WriteLine($"the color of rectangle is {rectangleColor}");
        double rectangleArea = myRectangle.GetArea();
        Console.WriteLine($"the area of rectangle is {rectangleArea}");

        string circleColor = myCircle.GetColor();
        Console.WriteLine($"the color of the circle is {circleColor}");
        double circleArea = myCircle.GetArea();
        Console.WriteLine($"The area of the circle is {circleArea}");

        List<Shapes> MyShapes = new List<Shapes>();

        MyShapes.Add(mySquare);
        MyShapes.Add(myRectangle);
        MyShapes.Add(myCircle);

        foreach(Shapes shape in MyShapes)
        {
            string loopsColor = shape.GetColor();
            double loopsArea = shape.GetArea();
            Console.WriteLine($"The color of the shape is {loopsColor}");
            Console.WriteLine($"The area of the shape is {loopsArea}");
        }


    }
}