using System.Reflection.Metadata;

public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string StreetAddress, string City, string State, string Country) {
        _streetAddress = StreetAddress;
        _city = City;
        _state = State;
        _country = Country;
    }

    public string GetAddress(){
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }

    public bool LivesInUSA(){
        if(_country.ToLower() == "usa"){return true;}
        return false;
    }

    public string GetStreetAddress(){
        return _streetAddress;
    }

    public string GetCity(){
        return _city;
    }

    public string GetState(){
        return _state;
    }

    public string GetCountry(){
        return _country;
    }
}