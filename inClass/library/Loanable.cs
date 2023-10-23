public class Loanable {
    protected bool _isCheckIn = true;

    public void CheckOut()
    {
        _isCheckIn = false;
    }

    public void CheckIn()
    {
        _isCheckIn = true;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Available: {_isCheckIn}");
    }
}