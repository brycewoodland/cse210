public class OutdoorGathering : Event {

    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherStatement) : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public void OutdoorGatheringDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"Weather Statement: {_weatherStatement}");
    }
}