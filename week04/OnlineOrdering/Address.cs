public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;


    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool GetLivesInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCompleteAddress()
    {
        return $"Street: {_street} \n" +
        $"City: {_city} \n" +
        $"Province: {_province} \n" +
        $"Country: {_country} \n";
    }

}