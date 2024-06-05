public class Cycling : Activity {
    private double _speed;

    public Cycling(string Date, int Length, double Speed) : base(Date, Length){
        _speed = Speed;
    }

    override public double GetDistance(){
        return GetLength() / GetPace();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    override public double GetPace(){
        return 60 / GetSpeed();
    }

}