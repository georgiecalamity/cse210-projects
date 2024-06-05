public class Activity {
    private string _date;
    private int _length;

    public Activity(string date, int length){
        _date = date;
        _length = length;
    }

    virtual public double GetDistance(){
        return 0;
    }

    virtual public double GetSpeed(){
        return (GetDistance() / _length * 60);
    }

    virtual public double GetPace(){
        return _length / GetDistance();
    }

    public int GetLength(){
        return _length;
    }

    public string GetDate(){
        return _date;
    }

    public string GetSummary(){
        Type classType = GetType();
        return $"{_date} {classType} ({_length}) - Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
    
}