using System.Runtime.CompilerServices;

public class Event{
    private string _title;
    private string _description;
    private Address _address;
    private string _date;
    private string _time;
    private int _capacity;

    public Event(string title, string description, Address address, string date, string time){
        _title = title;
        _description = description;
        _address = address;
        _date = date;
        _time = time;
        _capacity = 200;
    }

    public string StandardDetails(){
        return $"{_title}\n{_description}\n{_date}\n{_date} - {_time}\n{_address.GetAddress()}";
    }

    protected string ClassType(){
        Type classType = GetType();
        return $"{classType}";
    }

    public  void SetCapacity(int capacity) {
        _capacity = capacity;
    }

    public int GetCapacity(){
        return _capacity;
    }

    virtual public string FullDetails(){
        return $"{StandardDetails()}\nEvent Type:{ClassType()}";
    }

    public string ShortDescription(){
        return ($"{ClassType()} - {_title} - Date: {_date}");
    }
}