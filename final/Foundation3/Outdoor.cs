public class Outdoor : Event {
    private string _weather;

    public Outdoor(string title, string description, Address address, string date, string time, string weather)
    :base(title, description, address, date, time){
        _weather = weather;
    }

    override public string FullDetails(){
        string firstPart = base.FullDetails();
        return $"{firstPart}\nThe Weather for the day will be {_weather}";
        
    }
}