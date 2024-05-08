using System;

public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int Top) {
        _top = Top;
        _bottom = 2;
    }

    public Fraction(int Top, int Bottom) {
        _top = Top;
        _bottom = Bottom;
    }  

    public string GetFractionString() {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue() {
        double number = (double)_top/(double)_bottom;
        return number;
    }
}