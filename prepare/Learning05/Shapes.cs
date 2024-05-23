using System;
using System.Drawing;
using System.Dynamic;

public abstract class Shapes
{
    private string _color;

    public Shapes(string Color)
    {
        _color = Color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string Color)
    {
        _color = Color;
    }

    public abstract double GetArea();
}