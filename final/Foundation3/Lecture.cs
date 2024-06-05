public class Lecture : Event {
    private string _speaker;

    public Lecture(string title, string description, Address address, string date, string time, string speaker = "") 
    : base(title, description, address, date, time){
        if(speaker != "")
            _speaker = speaker;
        else
            _speaker = "Not Disclosed";

    }

    public void SetSpeaker(string speaker){
        _speaker = speaker;
    }

    override public string FullDetails(){
        string firstPart = base.FullDetails();
        return $"{firstPart} - Capacity: {GetCapacity()}\nSpeaker : {_speaker}";
        
    }
}