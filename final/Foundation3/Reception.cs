public class Reception : Event {

    public Reception(string title, string description, Address address, string date, string time) 
            : base(title, description, address, date, time){

        }

    public override string FullDetails()
    {
        string firstPart = base.FullDetails();
        return $"{firstPart} - Capacity: {GetCapacity()}\nPlease Remember to RSVP to the event!";

    }
}