public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetLivesInUSA()
    {
        if (_address.GetLivesInUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetCompleteAddress();
    }
}