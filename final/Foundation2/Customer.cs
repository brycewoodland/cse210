public class Customer {

    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool USAOrNot()
    {
        return _address.USAOrNot();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}