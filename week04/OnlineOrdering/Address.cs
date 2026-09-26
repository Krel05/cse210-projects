public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country.ToUpper() == "USA" || _country.ToLower() == "united utates of america" || _country.ToLower() == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}