public class Event {

    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address:\n{_address.GetAddress()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine("Type: Generic Event");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
    }
}